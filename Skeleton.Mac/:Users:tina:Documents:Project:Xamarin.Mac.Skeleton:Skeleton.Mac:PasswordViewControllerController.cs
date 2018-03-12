sing System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace Skeleton.Mac
{
    public partial class PasswordViewControllerController : AppKit.NSViewController
    {
        #region Constructors

        // Called when created from unmanaged code
        public PasswordViewControllerController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public PasswordViewControllerController(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Call to load from the XIB/NIB file
        public PasswordViewControllerController() : base("PasswordViewController", NSBundle.MainBundle)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        //strongly typed view accessor
        public new PasswordViewController View
        {
            get
            {
                return (PasswordViewController)base.View;
            }
        }
    }
}
