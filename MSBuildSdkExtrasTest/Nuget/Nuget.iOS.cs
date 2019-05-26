using System;


namespace ZPF
{
    /// <summary>
    /// iOS implementation to Nuget device
    /// </summary>
    public class Nuget : INuget
    {

		/// <summary>
		/// Gets if device can Nuget
		/// </summary>
		public bool CanNuget => true;

		/// <summary>
		/// Nuget the phone for specified amount of time
		/// </summary>
		/// <param name="NugetSpan">Time span to Nuget. 500ms is default if null</param>
		public void Vibration(TimeSpan? NugetSpan = null) =>
            SystemSound.Nuget.PlaySystemSound();
        
    }
}