﻿using UIKit;
using Foundation;

namespace EntryUITest.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            global::Xamarin.Forms.Forms.Init();

#if DEBUG
			// Code for starting up the Xamarin Test Cloud Agent
            Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}

