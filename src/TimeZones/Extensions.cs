using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZones
{
	/// <summary>  Extension methods</summary>
	public static class Extensions
	{
		/// <summary>Gets the number of significant decimal places in the value.</summary>
		/// <param name="value">The value.</param>
		/// <returns>System.Int32.</returns>
		public static int GetDecimalCount(this double value)
		{
			var text = value.ToString();
			var separator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
			var position = text.IndexOf(separator);
			return (position == -1) ? 0 : text.Length - position - 1;
		}
	}
}
