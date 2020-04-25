using System;

namespace TimeZones
{
	/// <summary>
	/// Class Finder.
	/// Implements the <see cref="TimeZones.IFindTimeZones" />
	/// </summary>
	/// <seealso cref="TimeZones.IFindTimeZones" />
	public class Finder : IFindTimeZones
	{
		/// <summary>
		/// Finds the time zone.
		/// </summary>
		/// <param name="coordinates">The coordinates.</param>
		/// <returns>Zone.</returns>
		/// <exception cref="NotImplementedException"></exception>
		public Zone FindTimeZone(Coordinates coordinates)
		{
			var result = GeoTimeZone.TimeZoneLookup.GetTimeZone(coordinates.Latitude, coordinates.Longitude);
			return Zone.Parse(result.Result);
		}
	}
}
