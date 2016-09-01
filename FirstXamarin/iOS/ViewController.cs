using System;

using UIKit;

namespace FirstXamarin.iOS
{
	public partial class ViewController : UIViewController
	{
		//int count = 1;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//btnConfirm.TouchUpInside += delegate {

			//};

			btnToMap.TouchUpInside += (sender, e) => {
				//moveToMapViewSegue
				PerformSegue("moveToMap", this);
			};

			btnToWeb.TouchUpInside += (sender, e) =>{
				//moveToWebViewSegue
				PerformSegue("moveToWeb", this);
			};

			//// Perform any additional setup after loading the view, typically from a nib.
			//Button.AccessibilityIdentifier = "myButton";
			//Button.TouchUpInside += delegate
			//{
			//	var title = string.Format("{0} clicks!", count++);
			//	Button.SetTitle(title, UIControlState.Normal);
			//};
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			//if ("moveToMap" == segue.Identifier)
			//{
			//	if (segue.DestinationViewController is MyMapViewController)
			//	{
			//		var dest = segue.DestinationViewController as MyMapViewController;

			//		dest.TitleString = "Bye Bye !";
			//	}
			//}

		}
	}
}
