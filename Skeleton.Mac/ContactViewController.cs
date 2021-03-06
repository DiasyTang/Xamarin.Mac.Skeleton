// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using Skeleton.Mac.ContactsTableView;

namespace Skeleton.Mac
{
	public partial class ContactViewController : NSViewController
	{
        private bool _selectedState = false;

        [Export("SelectedState")]
        public bool SelectedState
        {
            get => _selectedState;
            set
            {
                WillChangeValue(nameof(SelectedState));
                _selectedState = value;
                DidChangeValue(nameof(SelectedState));
            }
        }

		public ContactViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
		}

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            var DataSource = new ContactTableDataSource();
            DataSource.Contacts.Add(new ContactItem("dfasd"));
            DataSource.Contacts.Add(new ContactItem("dsfas"));
            DataSource.Contacts.Add(new ContactItem("df"));

            ContactTable.DataSource = DataSource;
            ContactTable.Delegate = new ContactTableDelegate(ContactTable, DataSource);
            ContactTable.Clicked += (item) =>
            {
                SelectedState = item != null;
            };
		}
	}
}
