using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DesktopMaid
{
    public partial class DesktopMaid : Form
    {
        private Desktop currentDesktop;
        private Desktop savedDesktop;
        private Settings settings;

        public DesktopMaid()
        {
            InitializeComponent();
            Desktop.ResultReady += ResultReady;
        }

        private void BlinkControl(Control control)
        {
            control.BackColor = Color.Red;
            Update();
            Thread.Sleep(100);
            control.ResetBackColor();
        }

        private void UpdateLbItems()
        {
            currentDesktop = new Desktop();
            lbItems.BeginUpdate();
            lbItems.Clear();
            lbItems.SmallImageList = FileListViewManager.GetIcons(currentDesktop.Files.Where(File.Exists));
            lbItems.FillWithDeskopItems(currentDesktop, savedDesktop);
            lbItems.EndUpdate();
        }

        private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateLbItems();
        }

        private void butPreserve_Click(object sender, EventArgs e)
        {
            savedDesktop.AddFiles(lbItems.SelectedItems.Cast<ListViewItem>().Select(t => t.Tag.ToString()));
            UpdateLbItems();
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            savedDesktop.RemoveFiles(lbItems.SelectedItems.Cast<ListViewItem>().Select(t => t.Tag.ToString()));
            UpdateLbItems();
        }

        private void DesktopMaid_Shown(object sender, EventArgs e)
        {
            if (savedDesktop == null)
            {
                savedDesktop = new Desktop(new string[] {});
                MessageBox.Show("Now you have to add files that you want to preserve on your desktop.");
                tabControl1.SelectedIndex = 0;
                BlinkControl(butPreserve);
            }
            if (string.IsNullOrWhiteSpace(tbPath.Text))
            {
                MessageBox.Show("You also have to select path to copy files to."); //todo rewrite
                tabControl1.SelectedIndex = 1;
                BlinkControl(butBrowse);
            }
            UpdateLbItems();
        }

        private void butBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                settings.Path = fbd.SelectedPath;
                tbPath.Text = settings.Path;
            }
        }

        private void ResultReady(object sender, FileMoveResult result)
        {
            var status = result.exception == null ? "OK" : "Error";
            var line = new ListViewItem
            {
                BackColor = result.exception == null ? Color.Green : Color.Red,
                Text = $"{Path.GetFileName(result.SourcePath)}: {status}",
                ToolTipText =
                    result.exception == null ? result.TargetPath : TryToGetUserFriendlyExceptionDescription(result.exception)
            };
            lVLog.Items.Add(line);
            progressBar.Value += result.fileSizeInPercents;
        }

        private string TryToGetUserFriendlyExceptionDescription(Exception exception)
        {
            string message="";

            if (exception is UnauthorizedAccessException)
            {
                message = "You dont have the required permission to create or delete this file!";
#if DEBUG
                message += $"\n{exception.Message}";
#endif
            }
            else if (exception is FileNotFoundException)
            {
                message = "Source file was not found!";
#if DEBUG
                message += $"\n{exception.Message}";
#endif
            }
            else
            {
                message = exception.Message;
            }
            return message;
        }

        private void cbRunAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            settings.RunAtStartup = cbRunAtStartup.Checked;
        }

        private void chbAutoRestore_CheckedChanged(object sender, EventArgs e)
        {
            settings.AutoRestore = chbAutoRestore.Checked;
            autoRestoreTimer.Interval = (int)(settings.Interval * 60 * 1000);
            if (settings.AutoRestore)
                autoRestoreTimer.Start();
            else
                autoRestoreTimer.Stop();
        }

        private void numInterval_ValueChanged(object sender, EventArgs e)
        {
            settings.Interval = numInterval.Value;
        }

        private void butClean_Click(object sender, EventArgs e)
        {
            RestoreDesktop();
        }

        private void RestoreDesktop()
        {
            lVLog.Clear();
            progressBar.Value = 0;
            try
            {
                savedDesktop.Restore(settings.Path);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Access denied!/n/n{ex.Message}");
            }
            UpdateLbItems();
        }

        private void autoRestoreTimer_Tick(object sender, EventArgs e)
        {
            RestoreDesktop();
        }

        private void chbStartMinimalized_CheckedChanged(object sender, EventArgs e)
        {
            settings.StartMinimalized =chbStartMinimalized.Checked;
        }

        public void ChangeWindowState(FormWindowState windowState)
        {
            switch (windowState)
            {
                case FormWindowState.Minimized:
                    notifyIcon.Visible = true;
                    ShowInTaskbar = false;
                    this.Hide();
                    break;
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Normal;
                    notifyIcon.Visible = false;
                    ShowInTaskbar = true;
                    this.Show();
                    break;
            }
        }

        private void DesktopMaid_Resize(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Minimized)
            {
                ChangeWindowState(WindowState);
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ChangeWindowState(FormWindowState.Normal);
        }

        private void trayRestoreNow_Click(object sender, EventArgs e)
        {
            RestoreDesktop();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lVLog_DoubleClick(object sender, EventArgs e)
        {
            if (lVLog.SelectedItems.Count!=0)
            {
                MessageBox.Show(lVLog.SelectedItems[0].ToolTipText);
            }
        }

        private void DesktopMaid_Load(object sender, EventArgs e)
        {
            savedDesktop = Desktop.Load();
            settings = Settings.Load();

            if (settings != null)
            {
                tbPath.Text = settings.Path;
                cbRunAtStartup.Checked = settings.RunAtStartup;
                chbAutoRestore.Checked = settings.AutoRestore;
                numInterval.Value = settings.Interval;
                if (settings.StartMinimalized)
                {
                    ChangeWindowState(FormWindowState.Minimized);
                }
            }
            else
            {
                settings = new Settings();
            }

        }
    }
}