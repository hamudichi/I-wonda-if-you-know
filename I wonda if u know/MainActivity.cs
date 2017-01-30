/*
 * I-Wonda-If-U-Know
 * Is a small app that runs on any smartphone. It detects the acceleration of a car or speed
 * and accordingly play the song.
 * If you are unfamiliar with Fast'n Furious movies, then this will not make any sense to you.
 * 
 * Next Steps:
 *  - Look for sensory information
 *  - Licensing
 *  * 
 */


using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace I_wonda_if_u_know
{
    [Activity(Label = "I_wonda_if_u_know", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

