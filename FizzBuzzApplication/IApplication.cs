using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzzApplication
{
	public interface IApplication
	{
		IEnumerable<string> Play(int value);
	}

	public class FizzBuzzApp : IApplication
	{
		public IEnumerable<string> Play(int value)
		{
			for (var i = 1; i <= value; i++)
			{
				if (i % 15 == 0) { yield return "Fizz Buzz"; }
				else if (i % 5 == 0) { yield return "Buzz"; }
					else if (i % 3 == 0) { yield return "Fizz"; }
						else yield return i.ToString(CultureInfo.InvariantCulture);
			}
		}
	}
}
