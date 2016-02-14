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
        }

        public void AddFiles(IEnumerable<string> files)
        {
            this.files.AddRange(files.Where(path => !this.files.Contains(path)));
        }

        public void RemoveFiles(IEnumerable<string> files)
        {
            foreach (string path in files.Where(path => this.files.Contains(path)))
            {
                this.files.Remove(path);
            }
        }

        public static IEnumerable<string> GetCommonItems(Desktop desktopA , Desktop desktopB)
        {
            return desktopA.Files.Intersect(desktopB.Files);
        }
    }
}
