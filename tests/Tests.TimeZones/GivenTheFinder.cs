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

		[Theory]
		[InlineData("41.3643373,-81.8770663","America/Detroit")]
		[InlineData("39.850067, -86.347219","America/Indiana/Indianapolis")]
		[InlineData("35.4536748,-97.3453418","America/Chicago")]
		public void WhenIHaveCoordinates_ThenIGetTimeZoneForNow(Coordinates coordinates, Zone expected)
		{
			// act
			var actual = _finder.FindTimeZone(coordinates);

			// assert
			actual.Should().Be(expected);
		}
	}
}
