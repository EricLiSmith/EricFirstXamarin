// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FirstXamarin.iOS
{
	[Register ("MyWebViewController")]
	partial class MyWebViewController
	{
		[Outlet]
		UIKit.UIButton btnGoWeb { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint btnGoWebBottomConstraint { get; set; }

		[Outlet]
		UIKit.UITextField tfWebUrl { get; set; }

		[Outlet]
		UIKit.UIWebView wvWebContent { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnGoWebBottomConstraint != null) {
				btnGoWebBottomConstraint.Dispose ();
				btnGoWebBottomConstraint = null;
			}

			if (btnGoWeb != null) {
				btnGoWeb.Dispose ();
				btnGoWeb = null;
			}

			if (tfWebUrl != null) {
				tfWebUrl.Dispose ();
				tfWebUrl = null;
			}

			if (wvWebContent != null) {
				wvWebContent.Dispose ();
				wvWebContent = null;
			}
		}
	}
}
