using System;

using AppKit;
using Foundation;

namespace file_XIB;

[Register("PreferencesWindow")]
public partial class PreferencesWindow : NSViewController
{
    public PreferencesWindow() : base("PreferencesWindow", null)
    {
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        // Do any additional setup after loading the view.
    }
}