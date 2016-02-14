using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopMaid
{
    public class Desktop
    {
        private List<string> files;
        public ReadOnlyCollection<string> Files => files.AsReadOnly();
        public Desktop(IEnumerable<string> files)
        {
            this.files = new List<string>(files);
        }

        public Desktop()
        {
            files=new List<string>();
            //desktop
            files.AddRange(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)));
            files.AddRange(Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)));

            //common desktop
            files.AddRange(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory)));
            files.AddRange(Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory)));

            files.RemoveAll(s => s.Contains("desktop.ini"));
        }

        public void AddFiles(IEnumerable<string> filesToAdd)
        {
            files.AddRange(filesToAdd.Where(path => !this.files.Contains(path)));
        }

        public void RemoveFiles(IEnumerable<string> filesToRemove)
        {
            foreach (string path in filesToRemove.Where(path => this.files.Contains(path)))
            {
                files.Remove(path);
            }
        }
    }
}
