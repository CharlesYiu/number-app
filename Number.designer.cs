// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Number
{
	[Register ("Number")]
	partial class Number
	{
		[Outlet]
		AppKit.NSTextField NumberInput { get; set; }

		[Outlet]
		AppKit.NSRotationGestureRecognizer SwirlGesture { get; set; }

		[Outlet]
		AppKit.NSMagnificationGestureRecognizer ZoomGesture { get; set; }

		[Action ("ClickAction:")]
		partial void ClickAction (Foundation.NSObject sender);

		[Action ("NumberInputAction:")]
		partial void NumberInputAction (Foundation.NSObject sender);

		[Action ("SecondaryClickAction:")]
		partial void SecondaryClickAction (Foundation.NSObject sender);

		[Action ("SwirlAction:")]
		partial void SwirlAction (Foundation.NSObject sender);

		[Action ("ZoomAction:")]
		partial void ZoomAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (NumberInput != null) {
				NumberInput.Dispose ();
				NumberInput = null;
			}

			if (SwirlGesture != null) {
				SwirlGesture.Dispose ();
				SwirlGesture = null;
			}

			if (ZoomGesture != null) {
				ZoomGesture.Dispose ();
				ZoomGesture = null;
			}
		}
	}
}
