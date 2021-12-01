using System;

using AppKit;
using Foundation;

namespace Number
{
    [Register("Document")]
    public class Document : NSDocument
    {
        public Content NumberContent = new Content();
        public class Content : NSObject
        {
            public float NumberValue = 0;
            public Action<float> OnChange;
            public void ChangeNumber(float Number = 0)
            {
                // Set new value
                NumberValue = Number;
                // If Onchange value is set
                if (OnChange != null)
                {
                    //run on change
                    OnChange(NumberValue);
                }
            }
            public void ChangeNumber(string Number = "")
            {
                // If not nothing
                if (Number != "")
                {
                    float FinalNumberValue = float.NaN;
                    // If can parse number
                    if (float.TryParse(Number, out float ParsedFloat))
                    {
                        // Set value
                        FinalNumberValue = ParsedFloat;
                    }
                    // If no, try to round number
                    else if (double.TryParse(Number, out double ParsedInt))
                    {
                        // Set value to rounded double that is rounded into a float
                        FinalNumberValue = (float)Math.Round(ParsedInt);
                    }
                    // If changed successfully
                    if (!float.IsNaN(FinalNumberValue))
                    {
                        // Set new value
                        NumberValue = FinalNumberValue;
                        // If Onchange value is set
                        if (OnChange != null)
                        {
                            // run on change
                            OnChange(NumberValue);
                        }
                    }
                }
            }
            public Content(string Text = "")
            {
                ChangeNumber(Text);
            }
        }
        public Document(IntPtr handle) : base(handle)
        {
            // Add your subclass-specific initialization here.
        }
        public override void WindowControllerDidLoadNib(NSWindowController windowController)
        {
            base.WindowControllerDidLoadNib(windowController);
            // Add any code here that needs to be executed once the windowController has loaded the document's window.
        }
        [Export("autosavesInPlace")]
        public static bool AutosaveInPlace()
        {
            return true;
        }
        public override void MakeWindowControllers()
        {
            // Override to return the Storyboard file name of the document.
            // Vars
            NSStoryboard Storyboard = NSStoryboard.FromName("Main", null);
            NSWindowController WindowController = (NSWindowController)Storyboard.InstantiateControllerWithIdentifier("Document Window Controller");
            // If There's a windowcontroller
            if (WindowController != null) {
                // Add
                AddWindowController(WindowController);
                // Get Viewcontroller
                Number ViewController = (Number)WindowController.ContentViewController;
                // If There's a viewcontroller
                if (ViewController != null)
                {
                    // Set viewcontroller's window to the windowcontroller.window in here
                    ViewController.Window = WindowController.Window;
                    // Set viewcontroller's numbercontent to the numbercontent in here
                    ViewController.NumberContent = NumberContent;
                    // Set onchange to viewcontroller's onchange (UpdateLabel)
                    NumberContent.OnChange = ViewController.OnChange;
                    // Run onchange
                    NumberContent.OnChange(NumberContent.NumberValue);
                }
            }
        }
        public override NSData GetAsData(string typeName, out NSError outError)
        {
            // Insert code here to write your document to data of the specified type. 
            // If outError != NULL, ensure that you create and set an appropriate error when returning nil
            outError = null;
            // Return formatted data
            return(NSData.FromString(NumberContent.NumberValue.ToString()));
            
        }
        public override bool ReadFromData(NSData data, string typeName, out NSError outError)
        {
            // Insert code here to read your document from the given data of the specified type. 
            // If outError != NULL, ensure that you create and set an appropriate error when returning NO.
            // Change Number
            NumberContent.ChangeNumber(data.ToString());
            outError = null;
            return(true);
        }
    }
}
