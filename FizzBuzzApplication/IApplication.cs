using System.Collections.Generic;

namespace FizzBuzzApplication
{
	public interface IApplication
	{
		IEnumerable<string> Play(int value);
	}
}
