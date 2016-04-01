using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopMaid
{
    public partial class Desktop
    {
        public async void Restore(string destination)
        {
            var currentDesktop = new Desktop();
            var filesToMove = currentDesktop.Files.Except(Files);

            var destinationFolder = $"{destination}/{DateTime.Now.Date.ToShortDateString().Replace('/', '.')}";

            var Tasks =
                filesToMove.Select(item => new Task<FileMoveResult>(() => MoveItem(item, destinationFolder))).ToList();
            Tasks.ForEach(t => t.Start());

            while (Tasks.Count > 0)
            {
                var firstFinishedTask = await Task.WhenAny(Tasks);
                Tasks.Remove(firstFinishedTask);
                var result = await firstFinishedTask;
                OnResultReady(result);
            }
        }


        public static event EventHandler<FileMoveResult> ResultReady;

        private void OnResultReady(FileMoveResult result)
        {
            ResultReady?.Invoke(typeof(Desktop), result);
        }

        private FileMoveResult MoveItem(string path, string destinationFolder)
        {
            var result = new FileMoveResult { path = path };
            try
            {
                var target = GetTargetPath(path, destinationFolder);
                CreateFolderIfNonExistent(target);
                if (Directory.Exists(path))
                {
                    throw new NotImplementedException();
                }
                else if (File.Exists(path))
                {
                    File.Copy(path, target.FullName);
                    File.Delete(path);
                }
                else
                {
                    throw new FileNotFoundException("Source file was not found.",path);
                }
            }
            catch (Exception ex)
            {
                result.exception = ex;
            }
            return result;
        }

        private FileInfo GetTargetPath(string path, string destinationFolder)
        {
            string fileName = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);
            return MakeFileNameUnique(Path.Combine(destinationFolder, fileName, fileExt));
        }

        private void CreateFolderIfNonExistent(FileInfo dir)
        {
            if (!Directory.Exists(dir.DirectoryName))
            {
                Directory.CreateDirectory(dir.DirectoryName);
            }
        }

        public FileInfo MakeFileNameUnique(string path)
        {
            string dir = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);

            for (int i = 1; ; ++i)
            {
                if (!File.Exists(path))
                    return new FileInfo(path);

                path = Path.Combine(dir, fileName + " " + i + fileExt);
            }
        }
    }


    public class FileMoveResult : EventArgs
    {
        public string path;
        public Exception exception;
    }
}
