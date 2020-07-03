using FileTraverser.Core.BaseClasses;
using FileTraverser.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraverser.Core
{
    public class FileTraverser : BaseTraverser, IFileTraverser
    {
        #region Private Fields
        bool ExtentionFormatted = false;
        List<MyFile> Files { get; } = new List<MyFile>();
        #endregion

        public FileTraverser()
        {
        }

        public void PopulateFiles(string directory, string extention = "txt", double daysBack = 0)
        {
            string formatedExtention = FormateExtentionType(extention);
            var files = System.IO.Directory.GetFiles(directory, formatedExtention);

            foreach (string filePath in files)
                AddFile(filePath, daysBack);

            var directories = System.IO.Directory.GetDirectories(directory);
            foreach (string directoryPath in directories)
                PopulateFiles(directoryPath, formatedExtention, daysBack);
        }

        private void ProccessDirectoryArray(string[] tempFiles, int daysBack)
        {
            throw new NotImplementedException();
        }

        private void AddFile(string absolutePath, double days)
        {
            string fileName = absolutePath.Split('\\').Last();
            DateTime lastWrite = System.IO.File.GetLastWriteTime(absolutePath);

            var daysThreshold = days > 0 ? DateTime.Now.AddDays(-days) : lastWrite;

            if (lastWrite >= daysThreshold)
            {
                Files.Add(new MyFile()
                {
                    ExtentionType = absolutePath.Split('.').Last(),
                    Directory = absolutePath.Replace("\\" + fileName, ""),
                    Name = fileName,
                    LastModify = lastWrite
                });
            }
            
        }

        private string FormateExtentionType(string extention)
        {
            if (!ExtentionFormatted)
            {
                ExtentionFormatted = true;
                return extention.StartsWith(".") ? "*" + extention : "*." + extention;
            }
            else
                return extention;
        }

        public List<MyFile> GetFiles()
        {
            return Files;
        }
    }
}
