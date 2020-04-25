// /* This Source Code Form is subject to the terms of the Mozilla Public
//  * License, v. 2.0. If a copy of the MPL was not distributed with this
//  * file, You can obtain one at https://mozilla.org/MPL/2.0/.
//  */

using FluentAssertions;
using TimeZones;
using Xunit;

namespace Tests.Services.Models
{
	public class ExtensionMethodTests
	{
		[Theory]
		[InlineData(1.0, 0)]
		[InlineData(1.1, 1)]
		[InlineData(1.12, 2)]
		[InlineData(1.123, 3)]
		public void GivenADoubleValue_WhenICountDecimals_ThenIGetCorrectCount(double input, int expected)
		{
			// act
			var actual = input.GetDecimalCount();

			// assert
			actual.Should().Be(expected);
		}
	}
}