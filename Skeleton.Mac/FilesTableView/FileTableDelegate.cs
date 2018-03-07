using System;
using System.Collections;
using System.Collections.Generic;
using Foundation;
using AppKit;

namespace Skeleton.Mac.FilesTableView
{
    public class FileTableDelegate : NSTableViewDelegate
    {
        #region Constants
        private const string CellIdentifier = "FileCell";
        #endregion

        #region Private Variables
        private FileItemTableDataSource DataSource;
        #endregion

        #region Constructors
        public FileTableDelegate(FileItemTableDataSource datasource)
        {
            this.DataSource = datasource;
        }
        #endregion

        #region Override Methods
        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            switch (tableColumn.Title)
            {
                case "Name":
                    view.StringValue = DataSource.Files[(int)row].Name;
                    break;
                case "Type":
                    view.StringValue = DataSource.Files[(int)row].Type;
                    break;
                case "Size":
                    view.StringValue = DataSource.Files[(int)row].Size;
                    break;
                case "Modified":
                    view.StringValue = DataSource.Files[(int)row].Modified.ToString();
                    break;
            }
            return view;
        }

		public override void SelectionDidChange(NSNotification notification)
		{
            
		}
		#endregion
	}
}
