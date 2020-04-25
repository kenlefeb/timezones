using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZones
{
	public class TimeZone
	{
		public string Name { get; set; }

		public static TimeZone Parse(string name)
		{
			return new TimeZone
			{
				Name = name,
			};
		}

		public static implicit operator TimeZone(string name)
		{
			return Parse(name);
		}
	}
}
