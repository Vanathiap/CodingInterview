using System;
using System.Text;

namespace DecToBinScratch
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter decimal number");
			int n = Convert.ToInt32 (Console.ReadLine ());
			var sb = new StringBuilder ();
			while (n != 0) {
				sb.Insert (0, n % 2);
				n /= 2;
			}
			Console.WriteLine (sb.ToString());
		}
	}
}
