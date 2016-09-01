using Android.App;
using Android.Widget;
using Android.OS;

namespace FirstXamarin.Droid
{
	[Activity(Label = "MainActivity", MainLauncher = true, Icon = "@mipmap/icon")] //MainLanuncher 進入點, Icon AppIcon
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button>(Resource.Id.myButton);

			//button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

			//測試修改

			Button btnGoToWeb = FindViewById<Button>(Resource.Id.btnGoToWeb);
			Button btnGoToMap = FindViewById<Button>(Resource.Id.btnGoToMap);

			btnGoToWeb.Click += (sender, e) => {
				StartActivity(typeof(WebActivity));
			};

			btnGoToMap.Click += (sender, e) => {
				//Intent itMap = new Intent(this, typeof(MapActivity));
			};
		}
	}
}


