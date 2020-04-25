// /* This Source Code Form is subject to the terms of the Mozilla Public
//  * License, v. 2.0. If a copy of the MPL was not distributed with this
//  * file, You can obtain one at https://mozilla.org/MPL/2.0/.
//  */

using System;
using System.Text;

namespace TimeZones
{
	internal static class CoordinatesFormatter
	{
		internal static string FormatDegreesMinutesSeconds(double coordinate, char positive, char negative)
		{
			if (coordinate == 0)
				return $"0° 0' 0\"";

			var degrees = (int)Math.Floor(coordinate);
			var minutes = (int)Math.Floor((coordinate - degrees) * 60);
			var seconds = Math.Round(((coordinate - degrees) * 3600) - minutes, coordinate.GetDecimalCount());

			var builder = new StringBuilder($"{degrees}°");
			builder.Append($" {minutes}'");
			builder.Append($" {seconds}\"");

			if (coordinate > 0)
				builder.Append($" {positive}");

			if (coordinate < 0)
				builder.Append($" {negative}");

			return builder.ToString();
		}

		internal static string FormatDegreesMinutesSeconds(Coordinates coordinates)
		{
			return $"{FormatDegreesMinutesSeconds(coordinates.Latitude, 'N', 'S')}, {FormatDegreesMinutesSeconds(coordinates.Longitude, 'E', 'W')}";
		}
	}
}