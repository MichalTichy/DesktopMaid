using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DesktopMaid
{
    public partial class Desktop
    {
        public List<string> Files;
        public Desktop(IEnumerable<string> files)
        {
            Files = new List<string>(files);
        }

        public Desktop()
        {
            Files=new List<string>();
            //desktop
            Files.AddRange(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)));
            Files.AddRange(Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)));

            //common desktop
            Files.AddRange(Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory)));
            Files.AddRange(Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory)));

            Files.RemoveAll(s => s.Contains("desktop.ini"));
        }

        public void AddFiles(IEnumerable<string> filesToAdd)
        {
            Files.AddRange(filesToAdd.Where(path => !this.Files.Contains(path)));
            Save();
        }

        public void RemoveFiles(IEnumerable<string> filesToRemove)
        {
            foreach (var path in filesToRemove.Where(path => this.Files.Contains(path)))
            {
                Files.Remove(path);
            }
            Save();
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
                File.WriteAllText(Path.GetDirectoryName(Settings.SettingsPath)+@"\save.json", sr.ReadToEnd());
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
                var path = Path.GetDirectoryName(Settings.SettingsPath)+@"\save.json";
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

    public class FileMoveResult : EventArgs
    {
        string path;
        Exception exception;
    }
}
