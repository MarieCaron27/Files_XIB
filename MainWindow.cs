using System;

using AppKit;
using Foundation;

namespace file_XIB;

[Register("MainWindow")]
public partial class MainWindow : NSWindowController
{
    private int numberOfTimesClicked = 0;
    private SubViewType ViewType = SubViewType.None;
    private NSViewController SubviewController = null;
    private NSView Subview = null;
    
    public MainWindow() : base("MainWindow")
    {
    }
    
    public override void AwakeFromNib ()
    {
        base.AwakeFromNib ();

        // Set the initial value for the label
        ClickedLabel.StringValue = "Button has not been clicked yet.";
        
        DisplaySubview(new SubViewTable(), SubViewType.TableView); //Display the table view
    }
    
    partial void ClickedButton (AppKit.NSButton sender) 
    {
        // Update counter and label
        ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.",++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
    }
    
    private void DisplaySubview(NSViewController controller, SubViewType type) 
    {

        // Is this view already displayed?
        if (ViewType == type) return;

        // Is there a view already being displayed?
        if (Subview != null) {
            // Yes, remove it from the view
            Subview.RemoveFromSuperview ();

            // Release memory
            Subview = null;
            SubviewController = null;
        }

        // Save values
        ViewType = type;
        SubviewController = controller;
        Subview = controller.View;

        // Define frame and display
        Subview.Frame = new CGRect (0, 0, Window.ContentView.Frame.Width, Window.ContentView.Frame.Height);
        Window.ContentView.AddSubview (Subview);
    }
}