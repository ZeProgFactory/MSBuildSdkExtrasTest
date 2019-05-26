using System;

namespace ZPF
{
    /// <summary>
    /// Vibration Implentation on Android 
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
				if ((int)Build.VERSION.SdkInt >= 11)
				{

					using (var v = (Vibrator)Android.App.Application.Context.GetSystemService(Context.VibratorService))
						return v.HasVibrator;
				}

				return true;
			}
		}

		/// <summary>
		/// Nuget the phone for specified amount of time
		/// </summary>
		/// <param name="NugetSpan">Time span to Nuget. 500ms is default if null</param>
		public void Vibration(TimeSpan? NugetSpan = null)
        {
            var milliseconds = NugetSpan.HasValue ? NugetSpan.Value.TotalMilliseconds : 500;
            using (var v = (Vibrator)Android.App.Application.Context.GetSystemService(Context.VibratorService))
            {
                if ((int)Build.VERSION.SdkInt >= 11)
                {
#if __ANDROID_11__
                    if (!v.HasVibrator)
                    {
                        Console.WriteLine("Android device does not have vibrator.");
                        return;
                    }
#endif
                }

				if (milliseconds < 0)
					milliseconds = 0;

                try
                {
                    v.Nuget((int)milliseconds);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to Nuget Android device, ensure Nuget permission is set.");
                }
            }

        }
    }
}