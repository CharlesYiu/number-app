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
	partial class AppDelegate
	{
		[Outlet]
		AppKit.NSMenuItem ChangeButton { get; set; }

		[Action ("AboutAction:")]
		partial void AboutAction (Foundation.NSObject sender);

		[Action ("ChangeAction:")]
		partial void ChangeAction (Foundation.NSObject sender);

		[Action ("CopyAction:")]
		partial void CopyAction (Foundation.NSObject sender);

		[Action ("DeleteAction:")]
		partial void DeleteAction (Foundation.NSObject sender);

		[Action ("PasteAction:")]
		partial void PasteAction (Foundation.NSObject sender);

		[Action ("PreferencesAction:")]
		partial void PreferencesAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ChangeButton != null) {
				ChangeButton.Dispose ();
				ChangeButton = null;
			}
		}
	}
}
