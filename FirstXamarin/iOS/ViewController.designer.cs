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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnConfirm { get; set; }

		[Outlet]
		UIKit.UIButton btnToMap { get; set; }

		[Outlet]
		UIKit.UIButton btnToWeb { get; set; }

		[Outlet]
		UIKit.UIButton Button { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnConfirm != null) {
				btnConfirm.Dispose ();
				btnConfirm = null;
			}

			if (btnToMap != null) {
				btnToMap.Dispose ();
				btnToMap = null;
			}

			if (btnToWeb != null) {
				btnToWeb.Dispose ();
				btnToWeb = null;
			}

			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}
		}
	}
}
