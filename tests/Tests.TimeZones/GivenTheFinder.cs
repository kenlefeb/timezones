using System.Collections.Generic;
using FluentAssertions;
using TimeZones;
using Xunit;

namespace Tests.Services
{
	// Given some condition or prerequisite, When something happens, Then some result occurs.
	public class GivenTheFinder
	{
		private IFindTimeZones _finder;
		public GivenTheFinder()
		{
			_finder = new Finder();
		}

		private static IEnumerable<object[]> SampleCoordinatesWithCorrectTimeZones()
        {
            yield return new object[] { Coordinates.Parse("51.5098055,-0.1380042"), Zone.Parse("Europe/London") };
			yield return new object[] { Coordinates.Parse("41.3643373,-81.8770663"), Zone.Parse("America/New_York") };
			yield return new object[] { Coordinates.Parse("39.850067, -86.347219"), Zone.Parse("America/Indiana/Indianapolis") };
			yield return new object[] { Coordinates.Parse("35.4536748,-97.3453418"), Zone.Parse("America/Chicago") };
		}

		[Theory]
		[MemberData(nameof(SampleCoordinatesWithCorrectTimeZones))]
		public void WhenIHaveCoordinates_ThenIGetTimeZoneForNow(Coordinates coordinates, Zone expected)
		{
			// act
			var actual = _finder.FindTimeZone(coordinates);

			// assert
			actual.Should().Be(expected);
		}
	}
}
