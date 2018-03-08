using System;
using AppKit;
using Foundation;

namespace Skeleton.Mac.FilesTableView
{
    public class FileMenuDelegate:NSMenuDelegate
    {
        public FileMenuDelegate()
        {
        }

        public override void MenuWillHighlightItem(NSMenu menu, NSMenuItem item)
        {
            
        }

		public override void DidChange(NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
		{
            base.DidChange(forKey, mutationKind, objects);
		}
	}
}
