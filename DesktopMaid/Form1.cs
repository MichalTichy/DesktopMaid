using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopMaid
{
    public partial class DesktopMaid : Form
    {
        private Desktop currentDesktop = new Desktop();
        private Desktop savedDesktop = new Desktop();
        public DesktopMaid()
        {
            InitializeComponent();
        }

        private void DesktopMaid_Load(object sender, EventArgs e)
        {
            UpdateLbItems();
        }

        private void UpdateLbItems()
        {
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
            savedDesktop.AddFiles(lbItems.SelectedItems.Cast<string>());
            UpdateLbItems();
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            savedDesktop.RemoveFiles(lbItems.SelectedItems.Cast<string>());
            UpdateLbItems();
        }
    }
}
