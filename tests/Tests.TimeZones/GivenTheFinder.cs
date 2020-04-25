using System.Collections.Generic;
using AutoFixture;
using AutoFixture.Xunit2;
using FakeItEasy;
using FluentAssertions;
using TimeZones;
using Xunit;

namespace Tests.Services
{
	public class GivenTheFinder
	{
		private IFindTimeZones _finder;
		public GivenTheFinder()
		{
			_finder = new Finder();
		}

		private static IEnumerable<object[]> SampleCoordinatesWithCorrectTimeZones()
		{
			yield return new object[] { Coordinates.Parse("41.3643373,-81.8770663"), Zone.Parse("America/Detroit") };
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
