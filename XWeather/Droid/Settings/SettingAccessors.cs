/* This file was generated by Settings Studio
 *
 * Copyright © 2015 Colby Williams. All Rights Reserved.
 */

namespace SettingsStudio
{

	public static partial class Settings
	{

		#region Visible Settings


		public static string VersionNumber => StringForKey (SettingsKeys.VersionNumber);

		public static string BuildNumber => StringForKey (SettingsKeys.BuildNumber);

		public static string GitHash => StringForKey (SettingsKeys.GitCommitHash);

		public static string UserReferenceKey => StringForKey (SettingsKeys.UserReferenceKey);

		public static bool RandomBackgrounds {
			get { return BoolForKey (SettingsKeys.RandomBackgrounds); }
			set { SetSetting (SettingsKeys.RandomBackgrounds, value); }
		}

		public static int UomTemperature {
			get { return Int32ForKey (SettingsKeys.UomTemperature); }
			set { SetSetting (SettingsKeys.UomTemperature, value); }
		}


		#endregion


		#region Hidden Settings


		public static string LocationsJson {
			get { return StringForKey (SettingsKeys.LocationsJson); }
			set { SetSetting (SettingsKeys.LocationsJson, value ?? string.Empty); }
		}


		public static int WeatherPage {
			get { return Int32ForKey (SettingsKeys.WeatherPage); }
			set { SetSetting (SettingsKeys.WeatherPage, value); }
		}


		#endregion
	}
}
