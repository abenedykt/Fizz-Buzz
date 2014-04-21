using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzzApplication
{
	public class FizzBuzzApp : IApplication
	{
		public IEnumerable<string> Play(int value)
		{
			return Enumerable.Range(1, value).Select(PlayOne);
		}

		public string PlayOne(int value)
		{
			if (value % 15 == 0) 
				return "Fizz Buzz";
			if (value % 5 == 0) 
				return "Buzz";
			return value%3 == 0 ? "Fizz" : value.ToString(CultureInfo.InvariantCulture);
		}
	}
}