using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace DesktopMaid
{
    public class Settings
    {
        private bool _autoRestore;
        private decimal _interval;
        private string _path;

        private bool _runAtStartup;

        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                Save();
            }
        }

        public bool RunAtStartup
        {
            get { return _runAtStartup; }
            set
            {
                _runAtStartup = value;
                Save();
            }
        }

        public bool AutoRestore
        {
            get { return _autoRestore; }

            set
            {
                _autoRestore = value;
                Save();
            }
        }

        public decimal Interval
        {
            get { return _interval; }

            set
            {
                _interval = value;
                Save();
            }
        }

        public void Save()
        {
            var stream = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof (Settings));
            ser.WriteObject(stream, this);
            stream.Position = 0;
            var sr = new StreamReader(stream);
            try
            {
                File.WriteAllText(Environment.SpecialFolder.ApplicationData + "/DesktopMaid/settings.json",
                    sr.ReadToEnd());
            }
            catch (Exception)
            {
                MessageBox.Show("Saving failed!");
            }
        }

        public static Settings Load()
        {
            var ser = new DataContractJsonSerializer(typeof (Settings));
            var ms = new MemoryStream();
            var sw = new StreamWriter(ms);

            try
            {
                var path = Environment.SpecialFolder.ApplicationData + "/DesktopMaid/settings.json";
                if (!File.Exists(path))
                {
                    return null;
                }
                var json = File.ReadAllText(path);
                sw.Write(json);
                sw.Flush();
                ms.Position = 0;
                return (Settings) ser.ReadObject(ms);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load settings!");
                return null;
            }
        }
    }
}