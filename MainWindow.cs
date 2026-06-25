using System;

using AppKit;
using Foundation;

namespace file_XIB;

[Register("MainWindow")]
public partial class MainWindow : NSWindowController
{
    private int numberOfTimesClicked = 0;
    
    public MainWindow() : base("MainWindow", null)
    {
    }
    
    public override void AwakeFromNib ()
    {
        base.AwakeFromNib ();

        // Set the initial value for the label
        ClickedLabel.StringValue = "Button has not been clicked yet.";
    }
    
    partial void ClickedButton (AppKit.NSButton sender) 
    {

        // Update counter and label
        ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.",++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
    }
}