using System;

namespace TimeZones
{
	public class Finder : IFindTimeZones
	{
		public TimeZone FindTimeZone(Coordinates coordinates)
		{
			throw new NotImplementedException();
		}
	}

	public interface IFindTimeZones
	{
		TimeZone FindTimeZone(Coordinates coordinates);
	}
}
