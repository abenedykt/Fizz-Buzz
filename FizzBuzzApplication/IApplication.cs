using System.Collections.Generic;

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
			yield return "Hello";
			yield return "world";
		}
	}
}
