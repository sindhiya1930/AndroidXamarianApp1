using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidXamarianApp1
{
    [Activity(Label = "AndroidXamarianApp1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource.
            // and attach an event to it.
            Button button = FindViewById<Button>(Resource.);

            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
            };

        }
    }
}

