using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using TimeZones;
using TimeZones.Api.Controllers;
using Xunit;

namespace Tests.Api
{
    public class GivenTheTimeZonesController
    {
        private readonly TimeZonesController _controller;

        public GivenTheTimeZonesController()
        {
            _controller = new TimeZonesController();
        }

        private static IEnumerable<object[]> SampleTimeZones()
        {
            yield return new object[] { "America/New_York", Zone.Parse("America/New_York") };
        }

        [Theory]
        [MemberData(nameof(SampleTimeZones))]
        public void WhenIAskForATimeZoneByName_ThenIGetTheCorrectTimeZone(string name, Zone expected)
        {
            // act
            var actual = _controller.Get(name);

            // assert
            actual.Should().Be(expected);
        }
    }
}
