using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraverser.Core.BaseClasses
{
    public class BaseFile
    {
        #region Properties
        public string Name { get; set; }
        public string Directory { get; set; }
        public string AbsolutePath => System.IO.Path.Combine(Directory, Name);
        public string  ExtentionType { get; set; }
        public DateTime LastModify { get; set; }
        #endregion 

    }
}
