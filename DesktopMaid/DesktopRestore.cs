using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DesktopMaid
{
    public partial class Desktop
    {
        public async void Restore(string destination)
        {
            var currentDesktop = new Desktop();
            var filesToMove = currentDesktop.Files.Except(Files);
            var sizesOfItemsInPercents = GetSizesOfItemsInPercents(filesToMove);
            var destinationFolder = $@"{destination}\{DateTime.Now.Date.ToShortDateString().Replace('/', '.')}";
            CreateFolderIfNonExistent(destinationFolder);

            var tasks =
                filesToMove.Select(item => new Task<FileMoveResult>(() => new ItemMover(item, destinationFolder).Start())).ToList();
            tasks.ForEach(t => t.Start());

            while (tasks.Count > 0)
            {
                var firstFinishedTask = await Task.WhenAny(tasks);
                tasks.Remove(firstFinishedTask);
                var result = await firstFinishedTask;
                result.fileSizeInPercents = sizesOfItemsInPercents[result.SourcePath];
                OnResultReady(result);
            }

            Task.WaitAll(tasks.ToArray());
            OnResultReady(null);
        }

        private Dictionary<string, int> GetSizesOfItemsInPercents(IEnumerable<string> filesToMove)
        {
            var sizes = GetSizesOfItems(filesToMove);
            var sizesInPercents = new Dictionary<string, int>();
            var totalSize = sizes.Values.Sum();
            foreach (var fileSize in sizes)
            {
                var size= (100 * fileSize.Value) / totalSize;
                sizesInPercents.Add(fileSize.Key,(int)size);
            }
            return sizesInPercents;
        }

        private Dictionary<string,long> GetSizesOfItems(IEnumerable<string> filesToMove)
        {
            var sizes=new Dictionary<string,long>(filesToMove.Count());
            foreach (var path in filesToMove)
            {
                if (File.Exists(path))
                {
                    sizes.Add(path, new FileInfo(path).Length);
                }
                else if (Directory.Exists(path))
                {
                    Scripting.FileSystemObject fso = new Scripting.FileSystemObject();
                    Scripting.Folder folder = fso.GetFolder(path);
                    sizes.Add(path, folder.Size);
                }
            }
            return sizes;
        }


        public static event EventHandler<FileMoveResult> ResultReady;

        private void OnResultReady(FileMoveResult result)
        {
            ResultReady?.Invoke(typeof(Desktop), result);
        }

        private void CreateFolderIfNonExistent(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }


    public class FileMoveResult : EventArgs
    {
        public string SourcePath;
        public int fileSizeInPercents;
        public Exception exception;
        public string TargetPath { get; set; }
    }
}
