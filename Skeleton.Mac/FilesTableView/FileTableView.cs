// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using Skeleton.Mac.FilesTableView;
using ObjCRuntime;

namespace Skeleton.Mac
{
	public partial class FileTableView : NSTableView
	{
		public FileTableView (IntPtr handle) : base (handle)
		{
            
		}

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            var filemenu = new NSMenu();
            var menuitem = new NSMenuItem("ddd");
            menuitem.Activated += (s, e) =>
            {

            };
            filemenu.AddItem(menuitem);
            //menuitem.Title = "aaa";
            //filemenu.AddItem(menuitem);
            //menuitem.Title = "ccc";
            //filemenu.AddItem(menuitem);
            this.Menu = filemenu;
            this.Menu.Delegate = new FileMenuDelegate();
            this.DoubleClick += (s,e) =>
            {

            };
		}

		public override void SelectCell(NSCell aCell)
		{
            base.SelectCell(aCell);
		}

		public override void SelectRows(NSIndexSet indexes, bool byExtendingSelection)
		{
            base.SelectRows(indexes, byExtendingSelection);
		}
	}
}
