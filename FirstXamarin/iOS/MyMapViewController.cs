using System;

using UIKit;

namespace FirstXamarin.iOS
{
	public partial class MyMapViewController : UIViewController
	{

		public string TitleString { get; set; }

		//因為要在xcode內使用，所以不需要xib的建構
		public MyMapViewController(IntPtr handle) : base(handle) 
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			Title = "Map";
			//Title = TitleString;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


