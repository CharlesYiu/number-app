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
	[Register ("Preferences")]
	partial class Preferences
	{
		[Outlet]
		AppKit.NSTextField AddValueInput { get; set; }

		[Outlet]
		AppKit.NSTextField DefaultValueInput { get; set; }

		[Outlet]
		AppKit.NSTextField MinusValueInput { get; set; }

		[Outlet]
		AppKit.NSButton RoundDecimalsToggleButton { get; set; }

		[Action ("RoundDecimalsToggleAction:")]
		partial void RoundDecimalsToggleAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AddValueInput != null) {
				AddValueInput.Dispose ();
				AddValueInput = null;
			}

			if (DefaultValueInput != null) {
				DefaultValueInput.Dispose ();
				DefaultValueInput = null;
			}

			if (MinusValueInput != null) {
				MinusValueInput.Dispose ();
				MinusValueInput = null;
			}

			if (RoundDecimalsToggleButton != null) {
				RoundDecimalsToggleButton.Dispose ();
				RoundDecimalsToggleButton = null;
			}
		}
	}
}
