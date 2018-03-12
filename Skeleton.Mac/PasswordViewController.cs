using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace Skeleton.Mac
{
    public partial class PasswordViewController : AppKit.NSViewController
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
        
        #region Constructors

        // Called when created from unmanaged code
        public PasswordViewController(IntPtr handle) : base(handle)
        {
            
        }
        #endregion
    }
}
