using AppKit;
using Foundation;
using System;

namespace Number
{
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate
    {
        NSWindow PreferencesWindow;
        NSWindow AboutWindow;
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }
        // Get current view controller
        Number GetCurrentViewController()
        {
            return((Number)NSApplication.SharedApplication.KeyWindow.ContentViewController);
        }
        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
        public void SetChangeButtonTitle(string Text)
        {
            // Change title to passed text
            ChangeButton.Title = Text;
        }
        partial void ChangeAction(NSObject sender)
        {
            Number CurrentViewController = GetCurrentViewController();
            // Toggle editing
            CurrentViewController.SetChangable(!CurrentViewController.Changable);
        }
        partial void DeleteAction(NSObject sender)
        {
            Number CurrentViewController = GetCurrentViewController();
            // If changable
            if (CurrentViewController.Changable)
            {
                // set changable to false
                CurrentViewController.SetChangable(false);
            }
            // Reset
            CurrentViewController.NumberContent.ChangeNumber(PreferencesData.DefaultNumber);
        }
        partial void CopyAction(NSObject sender)
        {
            GetCurrentViewController().NumberContent.CopyNumber();
        }
        partial void PasteAction(NSObject sender)
        {
            GetCurrentViewController().NumberContent.PasteNumber();
        }
        void FindPreferences(NSWindow Window, ref bool Stop)
        {
            try
            {
                // if is window
                _ = (Preferences)Window.ContentViewController;
                PreferencesWindow = Window;
                // stop
                Stop = true;
            }
            catch (InvalidCastException) {};
        }
        partial void PreferencesAction(NSObject sender)
        {
            // find preferences window
            PreferencesWindow = null;
            NSApplication.SharedApplication.EnumerateWindows(
                NSWindowListOptions.OrderedFrontToBack,
                new NSApplicationEnumerateWindowsHandler(FindPreferences)
            );
            // if there is a preferences window
            if (PreferencesWindow != null)
            {
                // focus
                PreferencesWindow.MakeKeyWindow();
                return;
            }
            // else create new window
            // Vars
            NSStoryboard Storyboard = NSStoryboard.FromName("Main", null);
            NSWindowController WindowController = (NSWindowController)Storyboard.InstantiateControllerWithIdentifier("Preferences");
            // If There's a windowcontroller
            if (WindowController != null)
            {
                // Show
                WindowController.ShowWindow(WindowController.Window);
            }
        }
        void FindAbout(NSWindow Window, ref bool Stop)
        {
            try
            {
                // if is window
                _ = (About)Window.ContentViewController;
                PreferencesWindow = Window;
                // stop
                Stop = true;
            }
            catch (InvalidCastException) { };
        }
        partial void AboutAction(NSObject sender)
        {
            // find about window
            AboutWindow = null;
            NSApplication.SharedApplication.EnumerateWindows(
                NSWindowListOptions.OrderedFrontToBack,
                new NSApplicationEnumerateWindowsHandler(FindAbout)
            );
            // if there is an about window
            if (AboutWindow != null)
            {
                // focus
                AboutWindow.MakeKeyWindow();
                return;
            }
            // else create new window
            // Vars
            NSStoryboard Storyboard = NSStoryboard.FromName("Main", null);
            NSWindowController WindowController = (NSWindowController)Storyboard.InstantiateControllerWithIdentifier("About");
            // If There's a windowcontroller
            if (WindowController != null)
            {
                // Show
                WindowController.ShowWindow(WindowController.Window);
            }
        }
    }
}