// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using CoreGraphics;

namespace Skeleton.Mac
{
	public partial class WindowController : NSWindowController
	{
		public WindowController (IntPtr handle) : base (handle)
		{
		}

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
		}

		public override void WindowDidLoad()
		{
            base.WindowDidLoad();
            Window.SetContentSize(new CGSize(1100, 650));
            Window.TitleVisibility = NSWindowTitleVisibility.Hidden;
		}
	}
}
