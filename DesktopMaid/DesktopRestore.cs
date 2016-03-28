using System;
using System.Collections.Generic;
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
            var filesToMove = Files.Except(currentDesktop.Files);

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
            throw new NotImplementedException();
        }
    }
}
