using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using ImageCircle;

namespace MySabinoRoad.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
            var statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;

            if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
            {
                statusBar.BackgroundColor = UIColor.White;
                
            }

            global::Xamarin.Forms.Forms.Init();
			ImageCircle.Forms.Plugin.iOS.ImageCircleRenderer.Init();
			LoadApplication(new App());
            

            return base.FinishedLaunching(app, options);
		}
	}
}
