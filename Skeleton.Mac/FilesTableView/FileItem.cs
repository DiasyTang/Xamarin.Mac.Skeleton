using System;
namespace Skeleton.Mac.FilesTableView
{
    public class FileItem
    {
        #region Public Properties
        public string Name { get; set; } = "";
        public string Type { get; set; } = "Folder";
        public string Size { get; set; } = "";
        public DateTime Modified { get; set; } = DateTime.Now;
        #endregion

        #region Constructors
        public FileItem()
        {
        }

        public FileItem(string name, string type, string size, DateTime modified)
        {
            this.Name = name;
            this.Size = size;
            this.Type = type;
            this.Modified = modified;
        }
        #endregion
    }
}
