namespace TimeZones
{
	/// <summary>
	/// Interface IFindTimeZones
	/// </summary>
	public interface IFindTimeZones
	{
		/// <summary>
		/// Finds the time zone.
		/// </summary>
		/// <param name="coordinates">The coordinates.</param>
		/// <returns>Zone.</returns>
		Zone FindTimeZone(Coordinates coordinates);
	}
}