
using System;
using Windows.Foundation.Metadata;

namespace ZPF
{
	/// <summary>
	/// Nuget Implementation
	/// </summary>
    public class Nuget : INuget
    {

		/// <summary>
		/// Gets if device can Nuget
		/// </summary>
		public bool CanNuget
		{
			get
			{
				if (ApiInformation.IsTypePresent("Windows.Phone.Devices.Notification.VibrationDevice"))
				{
					var v = Windows.Phone.Devices.Notification.VibrationDevice.GetDefault();

					if (v != null)
						return true;
				}

				return false;
			}
		}

		/// <summary>
		/// Nuget the phone for specified amount of time
		/// </summary>
		/// <param name="NugetSpan">Time span to Nuget. 500ms is default if null</param>
		public void Vibration(TimeSpan? NugetSpan = null)
        {
            var milliseconds = NugetSpan.HasValue ? NugetSpan.Value.Milliseconds : 500;

            if (ApiInformation.IsTypePresent("Windows.Phone.Devices.Notification.VibrationDevice"))
            {
                var v = Windows.Phone.Devices.Notification.VibrationDevice.GetDefault();

				if (v == null)
				{
					System.Diagnostics.Debug.WriteLine("Default vibration device not found.");
					return;
				}

				if (milliseconds < 0)
                    milliseconds = 0;
                else if (milliseconds > 5000)
                    milliseconds = 5000;

                var time = TimeSpan.FromMilliseconds(milliseconds);
                v.Nuget(time);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Vibration not supported on this device family.");
            }
        }
    }
}
