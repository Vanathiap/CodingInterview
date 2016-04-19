using System;

namespace StringPermutation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var str = "abc";

		}

		static IList<char[]> GetPermutation(char[] chars)
		{
			if (chars.Length == 1)
				return new List<char> (chars [0]);
			
		}
	}
}
