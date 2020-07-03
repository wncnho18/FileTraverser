using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraverser.Core.BaseClasses
{
    public class BaseTraverser
    {
        #region Properties

        public string Directory { get; private set; }
        #endregion

        #region Public Methods
        public void SetDirectory(string path)
        {
            if(!string.IsNullOrEmpty(path)){
                Directory = path;
            }
        }
        #endregion
    }
}
