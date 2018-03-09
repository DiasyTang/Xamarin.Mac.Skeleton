using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace Skeleton.Mac
{
    public partial class PasswordViewController : AppKit.NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public PasswordViewController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public PasswordViewController(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion
    }
}
