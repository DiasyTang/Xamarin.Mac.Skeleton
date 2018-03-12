using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using CoreGraphics;

namespace Skeleton.Mac
{
    public partial class PasswordOutlineView : NSOutlineView
    {
        private int Row = -1;
        #region Constructors

        // Called when created from unmanaged code
        public PasswordOutlineView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public PasswordOutlineView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            foreach (var item in this.Menu.ItemArray())
            {
                switch (item.Title)
                {
                    case "Copy Password":
                        item.Activated += CopyPasswordMenu;
                        break;
                    case "Copy UserName":
                        item.Activated += CopyUserNameMenu;
                        break;
                    case "View as QR Code":
                        item.Activated += ViewAsQRCodeMenu;
                        break;
                    case "Edit":
                        item.Activated += EditMenu;
                        break;
                    case "Share":
                        item.Activated += ShareMenu;
                        break;
                    case "Delete":
                        item.Activated += DeleteMenu;
                        break;
                }
            }
        }

        private void DeleteMenu(object sender, EventArgs e)
        {

        }

        private void ShareMenu(object sender, EventArgs e)
        {

        }

        private void EditMenu(object sender, EventArgs e)
        {

        }

        private void ViewAsQRCodeMenu(object sender, EventArgs e)
        {

        }

        private void CopyUserNameMenu(object sender, EventArgs e)
        {

        }

        private void CopyPasswordMenu(object sender, EventArgs e)
        {

        }

        public override void WillOpenMenu(NSMenu menu, NSEvent theEvent)
        {
            base.WillOpenMenu(menu, theEvent);
            if (Row == -1)
            {
                menu.CancelTracking();
            }
        }

        public override NSView HitTest(CGPoint aPoint)
        {
            Row = (int)GetRow(aPoint);
            return base.HitTest(aPoint);
        }
    }
}
