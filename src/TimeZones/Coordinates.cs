// /* This Source Code Form is subject to the terms of the Mozilla Public
//  * License, v. 2.0. If a copy of the MPL was not distributed with this
//  * file, You can obtain one at https://mozilla.org/MPL/2.0/.
//  */

namespace TimeZones
{
	public class Coordinates
	{
		public double Latitude  { get; set; }
		public double Longitude { get; set; }

		public static Coordinates Parse(string text)
		{
			return new Coordinates { };
		}

		public static implicit operator Coordinates(string text)
		{
			return Parse(text);
		}
	}

}