// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Skeleton.Mac
{
    [Register ("ContactViewController")]
    partial class ContactViewController
    {
        [Outlet]
        AppKit.NSMenu ContactMenu { get; set; }

        [Outlet]
        Skeleton.Mac.ContactTableView ContactTable { get; set; }
        
        void ReleaseDesignerOutlets ()
        {
            if (ContactMenu != null) {
                ContactMenu.Dispose ();
                ContactMenu = null;
            }

            if (ContactTable != null) {
                ContactTable.Dispose ();
                ContactTable = null;
            }
        }
    }
}
