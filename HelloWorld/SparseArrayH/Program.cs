using System;
using System.Linq;

namespace SparseArrayH
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int nSequence = Convert.ToInt32 (Console.ReadLine ());
			string[] inputSequence = new string[nSequence];

			int count = 0;
			while (count < nSequence) {
				inputSequence [count++] = Console.ReadLine();
			}

			int nQuery = Convert.ToInt32 (Console.ReadLine ());
			string[] querySequence = new string[nQuery];

			count = 0;
			while (count < nQuery) {
				querySequence [count++] = Console.ReadLine();
			}

			foreach (var query in querySequence) {
				Console.WriteLine (inputSequence.Where(item => item.Equals(query)).Count());
			}

			Console.Read ();
		}
	}
}
