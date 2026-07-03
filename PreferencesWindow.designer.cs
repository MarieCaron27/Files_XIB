// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace file_XIB
{
	partial class PreferencesWindow
	{
		[Outlet]
		AppKit.NSToolbar MyToolBar { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyToolBar != null) {
				MyToolBar.Dispose ();
				MyToolBar = null;
			}

		}
	}
}
