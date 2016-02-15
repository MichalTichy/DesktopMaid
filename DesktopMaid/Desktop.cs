using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (var path in filesToRemove.Where(path => this.files.Contains(path)))
            {
                files.Remove(path);
            }
        }

        public void Save()
        {
            var stream=new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof (Desktop));
            ser.WriteObject(stream,this);
            stream.Position = 0;
            var sr=new StreamReader(stream);
            try
            {
                File.WriteAllText(Environment.SpecialFolder.ApplicationData + "/DesktopMaid/save.json", sr.ReadToEnd());
            }
            catch (Exception)
            {
                MessageBox.Show("Saving failed!");
            }
        }

        public static Desktop Load()
        {
            var ser = new DataContractJsonSerializer(typeof (Desktop));
            var ms=new MemoryStream();
            var sw=new StreamWriter(ms);

            try
            {
                var path = Environment.SpecialFolder.ApplicationData + "/DesktopMaid/save.json";
                if (!File.Exists(path))
                {
                    return null;
                }
                var json = File.ReadAllText(path);
                sw.Write(json);
                sw.Flush();
                ms.Position = 0;
                return (Desktop) ser.ReadObject(ms);
            }
            catch(Exception)
            {
                MessageBox.Show("Could not load saved desktop!");
                return null;
            }

        }
    }
}
