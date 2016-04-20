using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DesktopMaid
{
    public class ItemMover
    {
        private string itemPath;
        private string destinationFolder;
        private List<FileStream> sourceLocks=new List<FileStream>();
        private List<FileStream> destinationLocks=new List<FileStream>();

        public ItemMover(string itemPath, string destinationFolder)
        {
            this.itemPath = itemPath;
            this.destinationFolder = destinationFolder;
        }
        public FileMoveResult Start()
        {

            var result = new FileMoveResult { path = itemPath };
            try
            {
                var target = GetTargetPath(itemPath, destinationFolder);

                if (Directory.Exists(itemPath)) //if is directory
                {
                    string uniqueTargetName = MakeFileNameUnique(target);
                    AddLocks(itemPath,sourceLocks);
                    try
                    {
                        MoveDirectory(itemPath, uniqueTargetName);
                    }
                    catch (Exception)
                    {
                        MoveDirectory(uniqueTargetName,itemPath,false);
                        throw;
                    }
                }
                else if (File.Exists(itemPath)) //if is file
                {
                    MoveFile(itemPath, target);
                }
                else
                {
                    throw new FileNotFoundException("Source file was not found.", itemPath);
                }
            }
            catch (Exception ex)
            {
                result.exception = ex;
                return result;
            }

            return result;
        }

        private void ReleaseLocks(List<FileStream> locks)
        {
            if (locks == null)
                return;

            foreach (var fileLock in locks)
            {
                fileLock.Close();
                fileLock.Dispose();
            }
        }

        private void AddLocks(string path,List<FileStream> collection)
        {
            try
            {
                if (File.Exists(path))
                {
                    collection.Add(new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.Inheritable));
                }
                else if (Directory.Exists(path))
                {
                    var dir = new DirectoryInfo(path);
                    foreach (var file in dir.GetFiles())
                    {
                        AddLocks(file.FullName,collection);
                    }
                    foreach (var directory in dir.GetDirectories())
                    {
                        AddLocks(directory.FullName,collection);
                    }
                }
            }
            catch (Exception)
            {
                ReleaseLocks(sourceLocks);
                throw;
            }
        }

        private void MoveDirectory(string path, string target,bool useLocks=true)
        {
            Directory.CreateDirectory(target);

            foreach (var file in Directory.GetFiles(path))
            {
                if (useLocks)
                {
                    var fileLock = sourceLocks.Single(t => t.Name == file);
                    sourceLocks.Remove(fileLock);
                    fileLock.Close();
                    fileLock.Dispose();
                }

                var destFileName = Path.Combine(target, Path.GetFileName(file));
                MoveFile(file, destFileName);

                if (useLocks)
                {
                    AddLocks(destFileName, destinationLocks);
                }
            }
            foreach (var directory in Directory.GetDirectories(path))
            {
                MoveDirectory(directory, Path.Combine(target, Path.GetFileName(directory)),useLocks);
            }
            new DirectoryInfo(path).Delete();
        }

        private string GetTargetPath(string path, string destinationFolder)
        {
            string fileName = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);
            return MakeFileNameUnique(Path.Combine(destinationFolder, fileName + fileExt));
        }

        public string MakeFileNameUnique(string path)
        {
            string dir = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);

            for (int i = 1; ; ++i)
            {
                if (!File.Exists(path) && !Directory.Exists(path))
                    return path;

                path = Path.Combine(dir, fileName + " " + i + fileExt);
            }
        }

        private void MoveFile(string source,string target)
        {
            var attributes = File.GetAttributes(source);
            File.SetAttributes(source,FileAttributes.Normal);
            File.Move(source,target);
            File.SetAttributes(target,attributes);
        }
    }
}
