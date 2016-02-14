using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopMaid
{
    public static class FileListViewManager
    {
        public static void FillListView(ListView listView, Desktop currentDesktop,Desktop savedDesktop)
        {
            var colors = GetColors(currentDesktop,savedDesktop);
            for (int index = 0; index < currentDesktop.Files.Count; index++)
            {
                var path = currentDesktop.Files[index];

                if (File.Exists(path))
                {
                    listView.Items.Add(FromFile(path, colors[index]));
                }
                else if (Directory.Exists(path))
                {
                    listView.Items.Add(FromDirectory(path, colors[index]));
                }
            }
        }


        private static Color[] GetColors(Desktop currentDesktop, Desktop savedDesktop)
        {
            return currentDesktop.Files.Select(path => savedDesktop.Files.Contains(path) ? Color.DarkGreen : Color.DarkRed).ToArray();
        }

        public static ImageList GetIcons(IEnumerable<string> files)
        {
            var icons=new ImageList();
            foreach (var file in files)
            {
                var extension = Path.GetExtension(file);
                if (extension == ".exe" || extension == ".lnk")
                {
                    var icon = Icon.ExtractAssociatedIcon(file);
                    if (icon != null)
                    {
                        icons.Images.Add(Path.GetFileName(file), icon);
                    }
                }
                else if (!icons.Images.ContainsKey(extension))
                {
                    var icon = Icon.ExtractAssociatedIcon(file);
                    if (icon!=null)
                    {
                        icons.Images.Add(extension, icon);
                    }
                }
            }
            return icons;
        }

        private static ListViewItem FromFile(string path, Color color)
        {
            var lwItem = new ListViewItem()
            {
                Tag = path,
                Text = Path.GetFileName(path),
                ImageKey = Path.GetExtension(path) == ".exe" || Path.GetExtension(path) == ".lnk" ? Path.GetFileName(path) : Path.GetExtension(path),
                ForeColor = color
            };
            return lwItem;
        }
        private static ListViewItem FromDirectory(string path, Color color)
        {
            var lwItem = new ListViewItem
            {
                Tag = path,
                Text = new DirectoryInfo(path).Name,
                ForeColor = color
            };
            return lwItem;
        }
    }
}
