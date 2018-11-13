using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AndroidXamarianApp1
{
    [Activity(Label = "AndroidXamarianApp1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
        
            AppCenter.Start("9b922c57-15af-4317-89fc-b024f84030b6", typeof(Analytics), typeof(Crashes));
            
            
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource.
            // and attach an event to it.
            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
            };

        }
    }
}

