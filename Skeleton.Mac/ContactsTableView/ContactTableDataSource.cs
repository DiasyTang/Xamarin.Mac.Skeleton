using System;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace Skeleton.Mac.ContactsTableView
{
    public class ContactTableDataSource : NSTableViewDataSource
    {
        #region Public Properties
        public List<ContactItem> Contacts { get; set; } = new List<ContactItem>();
        #endregion

        #region Contructors
        public ContactTableDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return Contacts.Count;
        }
        #endregion

    }
}
