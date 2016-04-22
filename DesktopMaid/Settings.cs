using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DesktopMaid
{
    public class Settings
    {
        private bool _autoRestore;
        private decimal _interval;
        private string _path;

        private bool _runAtStartup;
        private bool _startMinimalized;
        public static readonly string SettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/DesktopMaid/settings.json";

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
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (value)
                {
                    registryKey.SetValue("DesktopMaid", Application.ExecutablePath);
                }
                else if (registryKey.GetValueNames().Contains("DesktopMaid"))
                {
                    registryKey.DeleteValue("DesktopMaid");
                }
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

        public bool StartMinimalized
        {
            get { return _startMinimalized; }
            set
            {
                _startMinimalized = value;
                Save();
            }
        }

        public Settings()
        {
            Save();
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
                CreateDirectoryIfNonexistent();
                File.WriteAllText(SettingsPath, sr.ReadToEnd());
            }
            catch (Exception)
            {
                MessageBox.Show("Saving failed!");
            }
        }

        private static void CreateDirectoryIfNonexistent()
        {
            var dir = System.IO.Path.GetDirectoryName(SettingsPath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public static Settings Load()
        {
            var ser = new DataContractJsonSerializer(typeof (Settings));
            var ms = new MemoryStream();
            var sw = new StreamWriter(ms);

            try
            {
                var path = SettingsPath;
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