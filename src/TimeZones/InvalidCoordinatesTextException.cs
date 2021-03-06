﻿// /* This Source Code Form is subject to the terms of the Mozilla Public
//  * License, v. 2.0. If a copy of the MPL was not distributed with this
//  * file, You can obtain one at https://mozilla.org/MPL/2.0/.
//  */

using System;

namespace TimeZones
{
	/// <summary>
	/// Exception that occurs when an attempt was made to parse geographic coordinates from text that doesn't properly represent coordinates.
	/// Implements the <see cref="System.Exception" />
	/// </summary>
	/// <seealso cref="System.Exception" />
	/// <autogeneratedoc />
	public class InvalidCoordinatesTextException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InvalidCoordinatesTextException"/> class.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <autogeneratedoc />
		public InvalidCoordinatesTextException(string text) : base($"This text could not be parsed into geographic coordinates: \"{text}\".") { }
	}
}