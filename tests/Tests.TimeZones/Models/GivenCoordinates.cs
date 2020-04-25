using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using TimeZones;
using Xunit;

namespace Tests.Services.Models
{
	public class GivenCoordinates
	{
		[Theory]
		[InlineData("41.5057367,-81.6945422", 41.5057367, -81.6945422)]
		public void WhenIHaveTextCoordinates_ThenIKnowDoubleCoordinates(string input, double latitude, double longitude)
		{
			// act
			var actual = Coordinates.Parse(input);

			// assert
			actual.Latitude.Should().Be(latitude);
			actual.Longitude.Should().Be(longitude);
		}

		public static IEnumerable<object[]> CastingTextCoordinatesToCoordinates()
		{
			yield return new object[] { "41.5057367,-81.6945422", Coordinates.Parse("41.5057367, -81.6945422") };
		}

		[Theory]
		[MemberData(nameof(CastingTextCoordinatesToCoordinates))]
		public void WhenIHaveTextCoordinates_ThenIHaveCoordinates(string input, Coordinates expected)
		{
			// act
			var actual = (Coordinates)input;

			// assert
			actual.Should().Be(expected);
		}

	}
}
