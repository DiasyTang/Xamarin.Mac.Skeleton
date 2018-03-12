using System;
using AppKit;
using Foundation;

namespace Skeleton.Mac.ContactsTableView
{
    public class ContactTableDelegate : NSTableViewDelegate
    {
        #region Constants
        private const string CellIdentifier = "ContactCell";
        #endregion

        #region Private Variables
        private ContactTableDataSource DataSource;
        private ContactTableView Controller;
        #endregion

        #region Constructors
        public ContactTableDelegate(ContactTableView controller,ContactTableDataSource datasource)
        {
            this.Controller = controller;
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
                    view.StringValue = DataSource.Contacts[(int)row].Name;
                    break;
                case "E-Mail":
                    view.StringValue = DataSource.Contacts[(int)row].EMail;
                    break;
                case "Phone":
                    view.StringValue = DataSource.Contacts[(int)row].Phone;
                    break;
                case "Bitmessage":
                    view.StringValue = DataSource.Contacts[(int)row].BitMessage;
                    break;
            }

            return view;
        }

		public override bool ShouldSelectRow(NSTableView tableView, nint row)
		{
            return DataSource.Contacts.Count > row;
		}

        public override void SelectionDidChange(NSNotification notification)
        {
            NSIndexSet selectedIndex = Controller.SelectedRows;

            if (selectedIndex.Count != 1)
            {
                Controller.RaiseClickedEvent(null);
            }
            else
            {
                var item = DataSource.Contacts[(int)selectedIndex.FirstIndex];
                if (item != null)
                {
                    Controller.RaiseClickedEvent(item);
                }
            }
        }
		#endregion
	}
}
