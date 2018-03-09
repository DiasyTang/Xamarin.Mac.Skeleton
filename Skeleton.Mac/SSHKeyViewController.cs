using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace Skeleton.Mac
{
    public partial class SSHKeyViewController : AppKit.NSView
    {
        #region Constructors

        // Called when created from unmanaged code
        public SSHKeyViewController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public SSHKeyViewController(NSCoder coder) : base(coder)
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
