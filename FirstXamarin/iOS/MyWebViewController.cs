using System;

using UIKit;
using Foundation;
namespace FirstXamarin.iOS
{
	public partial class MyWebViewController : UIViewController
	{
		//public MyWebViewController() : base("MyWebViewController", null)
		//{
		//}

		public MyWebViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			Title = "Web";
			//Default
			wvWebContent.LoadRequest(new NSUrlRequest(new NSUrl(@"https://developer.apple.com/ios/human-interface-guidelines/")));

			btnGoWeb.TouchUpInside += (sender, e) =>{
				if (tfWebUrl.IsFirstResponder)
				{
					tfWebUrl.ResignFirstResponder();
				}

				wvWebContent.LoadRequest(new NSUrlRequest(new NSUrl(tfWebUrl.Text)));
			};

			UIKeyboard.Notifications.ObserveWillChangeFrame((sender, e) => {
				var beginRect = e.FrameBegin;
				var endRect = e.FrameEnd;



			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


