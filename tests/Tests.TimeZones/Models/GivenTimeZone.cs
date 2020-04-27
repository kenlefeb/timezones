using System.Collections.Generic;
using FluentAssertions;
using TimeZones;
using Xunit;

namespace Tests.Services.Models
{
	public class GivenTimeZone
	{
		public static IEnumerable<object[]> CastingIanaNameToTimeZone()
		{
			yield return new object[] { "America/Detroit", Zone.Parse("America/Detroit") };
		}

		[Theory]
		[MemberData(nameof(CastingIanaNameToTimeZone))]
		public void WhenIHaveIanaName_ThenICanParseTimeZoneFromIt(string input, Zone expected)
		{
			// act
			var actual = Zone.Parse(input);

			// assert
			actual.Should().Be(expected);
		}

		[Theory]
		[MemberData(nameof(CastingIanaNameToTimeZone))]
		public void WhenIHaveIanaName_ThenIHaveTimeZone(string input, Zone expected)
		{
			// act
			Zone actual = input;

			// assert
			actual.Should().Be(expected);
		}

		[Fact]
		public void WhenIHaveAnEquivalentTimeZone_ThenEqualsIsTrue()
		{
			// arrange
			var a = Zone.Parse("America/Detroit");
			var b = Zone.Parse("America/Detroit");

			// act
			var actual = a == b;

			// assert
			actual.Should().BeTrue();
		}

		[Fact]
		public void WhenIHaveADifferentTimeZone_ThenEqualsIsFalse()
		{
			// arrange
			var a = Zone.Parse("America/NewYork");
			var b = Zone.Parse("America/Detroit");

			// act
			var actual = a == b;

			// assert
			actual.Should().BeFalse();
		}
	}
}