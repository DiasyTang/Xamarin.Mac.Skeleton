// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using Skeleton.Mac.FilesTableView;

namespace Skeleton.Mac
{
	public partial class FileViewController : NSViewController
	{
        private bool _selectedState = false;

        [Export("SelectedState")]
        public bool SelectedState{
            get => _selectedState;
            set{
                WillChangeValue(nameof(SelectedState));
                _selectedState = value;
                DidChangeValue(nameof(SelectedState));
            }
        }
		public FileViewController (IntPtr handle) : base (handle)
		{
		}

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
		}

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();
            var DataSource = new FileItemTableDataSource();
            DataSource.Files.Add(new FileItem());
            DataSource.Files.Add(new FileItem());
            DataSource.Files.Add(new FileItem());

            FileTable.DataSource = DataSource;
            FileTable.Delegate = new FileTableDelegate(FileTable,DataSource);
            FileTable.Clicked += (item) =>
            {
                SelectedState = item != null;
            };
		}
	}
}
