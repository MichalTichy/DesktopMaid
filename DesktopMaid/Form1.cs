using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        }

        private void BlinkControl(Control control)
        {
            control.BackColor=Color.Red;
            Update();
            Thread.Sleep(100);
            control.ResetBackColor();
        }

        private void UpdateLbItems()
        {
            currentDesktop=new Desktop();
            lbItems.BeginUpdate();
            lbItems.Clear();
            lbItems.SmallImageList = FileListViewManager.GetIcons(currentDesktop.Files.Where(File.Exists));
            FileListViewManager.FillListView(lbItems,currentDesktop,savedDesktop);
            lbItems.EndUpdate();
        }

        private void linkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateLbItems();
        }

        private void butPreserve_Click(object sender, EventArgs e)
        {
            savedDesktop.AddFiles(lbItems.SelectedItems.Cast<ListViewItem>().Select(t=>t.Tag.ToString()));
            UpdateLbItems();
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            savedDesktop.RemoveFiles(lbItems.SelectedItems.Cast<ListViewItem>().Select(t => t.Tag.ToString()));
            UpdateLbItems();
        }

        private void DesktopMaid_Shown(object sender, EventArgs e)
        {
            savedDesktop = Desktop.Load();
            settings=Settings.Load();

            if (savedDesktop == null)
            {
                savedDesktop = new Desktop(new string[] { });
                MessageBox.Show("Now you have to add files that you want to preserve on your desktop.");
                tabControl1.SelectedIndex = 0;
                BlinkControl(butPreserve);
            }
            if (settings!=null)
            {
                LoadDataFromSettings();
            }
            if (string.IsNullOrWhiteSpace(tbPath.Text))
            {
                MessageBox.Show("You also have to select path to copy files to."); //todo rewrite
                tabControl1.SelectedIndex = 1;
                BlinkControl(butBrowse);
            }
            UpdateLbItems();
        }

        private void LoadDataFromSettings()
        {
            tbPath.Text = settings.Path;
            cbRunAtStartup.Checked = settings.RunAtStartup;
            chbAutoRestore.Checked = settings.AutoRestore;
            numInterval.Value = settings.Interval;
        }
    }
}
