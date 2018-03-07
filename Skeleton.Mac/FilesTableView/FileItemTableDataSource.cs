using System;
using Foundation;
using System.Collections;
using System.Collections.Generic;
using AppKit;

namespace Skeleton.Mac.FilesTableView
{
    public class FileItemTableDataSource : NSTableViewDataSource
    {
        #region Public Varibles
        public List<FileItem> Files = new List<FileItem>();
        #endregion

        #region Constructors
        public FileItemTableDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return Files.Count;
        }
        #endregion
    }
}
