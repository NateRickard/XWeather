using Foundation;
using UIKit;

using Microsoft.Azure.Mobile.Distribute;

namespace XWeather.iOS
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }

		public AppDelegate ()
		{
			Shared.Bootstrap.Run ();

			Analytics.Start ();
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{

#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
#endif
			return true;
		}

		/// <summary>
		/// My COmment
		/// </summary>
		/// <returns><c>true</c>, if URL was opened, <c>false</c> otherwise.</returns>
		/// <param name="app">App.</param>
		/// <param name="url">URL.</param>
		/// <param name="options">Options.</param>
		public override bool OpenUrl (UIApplication app, NSUrl url, NSDictionary options)
		{
			Distribute.OpenUrl (url);

			return true;
		}

#if ENABLE_TEST_CLOUD
		[Export ("updateSettingsToImperial")]
		public NSString UpdateSettingsToImperial ()
		{
			SettingsStudio.Settings.UomTemperature = TemperatureUnits.Celsius;
			SettingsStudio.Settings.UomDistance = DistanceUnits.Kilometers;
			SettingsStudio.Settings.UomPressure = PressureUnits.Millibars;
			SettingsStudio.Settings.UomLength = LengthUnits.Millimeters;
			SettingsStudio.Settings.UomSpeed = SpeedUnits.KilometersPerHour;

			return new NSString ("done");
		}
#endif
	}
}