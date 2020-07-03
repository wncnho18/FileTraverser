using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraverser.Core.Interfaces
{
    public interface IFileTraverser
    {
        void PopulateFiles(string directoryPath,string extention = "txt", double DaysBack = 0.0);
        List<MyFile> GetFiles();
    }
}
