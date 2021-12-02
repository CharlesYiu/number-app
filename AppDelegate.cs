using AppKit;
using Foundation;

namespace Number
{
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate
    {
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
            return ((Number)NSApplication.SharedApplication.KeyWindow.ContentViewController);
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
            CurrentViewController.NumberContent.ChangeNumber(0);
        }
        partial void CopyAction(NSObject sender)
        {
            GetCurrentViewController().NumberContent.CopyNumber();
        }
        partial void PasteAction(NSObject sender)
        {
            GetCurrentViewController().NumberContent.PasteNumber();
        }
    }
}