using System;
using AppKit;
using Foundation;

namespace Skeleton.Mac.SSHKeysCollectionView
{
    public partial class SSHKeyItemController:NSCollectionViewItem
    {
        private SSHKeyItem sSHKey;

        public new SSHKeyItemCell View{
            get => (SSHKeyItemCell)base.View;
        }

        public SSHKeyItem SSHKey{
            get => sSHKey;
            set{
                WillChangeValue(nameof(SSHKey));
                sSHKey = value;
                DidChangeValue(nameof(SSHKey));
            }
        }


        public SSHKeyItemController()
        {
        }
    }
}
