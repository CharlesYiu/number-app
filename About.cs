// This file has been autogenerated from a class added in the UI designer.

using System;

using CoreGraphics;
using AppKit;
using Foundation;

namespace Number
{
	public partial class About : NSViewController
	{
		public About (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // set background color
            View.MakeBackingLayer();
            View.Layer.BackgroundColor = new CGColor(CGConstantColor.White);
        }
        partial void ClickProfileAction(NSObject sender)
        {
            // go to https://github.com/charlesyiu
            NSWorkspace.SharedWorkspace.OpenUrl(new NSUrl("https", "github.com", "/charlesyiu"));
        }
        partial void ClickSourceAction(NSObject sender)
        {
            // go to https://github.com/charlesyiu/number-app
            NSWorkspace.SharedWorkspace.OpenUrl(new NSUrl("https", "github.com", "/charlesyiu/number-app"));
        }
    }
}
