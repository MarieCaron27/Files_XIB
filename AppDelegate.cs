namespace file_XIB;

[Register ("AppDelegate")]
public class AppDelegate : NSApplicationDelegate
{
    public MainWindow mainWindowController { get; set; }

    public AppDelegate ()
    {
    }

    public override void DidFinishLaunching (NSNotification notification)
    {
        // Insert code here to initialize your application
        mainWindowController = new MainWindow ();
        mainWindowController.Window.MakeKeyAndOrderFront (this);
        
        [Export ("openDocument:")]
        void OpenDialog (NSObject sender)
        {
            var dlg = NSOpenPanel.OpenPanel;
            dlg.CanChooseFiles = false;
            dlg.CanChooseDirectories = true;

            if (dlg.RunModal () == 1) {
                var alert = new NSAlert () {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = "At this point we should do something with the folder that the user just selected in the Open File Dialog box...",
                    MessageText = "Folder Selected"
                };
                alert.RunModal ();
            }
        }
    }

    public override void WillTerminate (NSNotification notification)
    {
        // Insert code here to tear down your application
    }
}