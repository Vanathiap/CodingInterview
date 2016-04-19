using System;

namespace BitOperations
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int l = 1, r = 10;
			int max = Int32.MinValue;

			for (int i = l; i <= r; i++)
				for (int j = r; j >= l; j--) {
					int newMax = i ^ j;
					Console.WriteLine("{0}^{1}={2}",i,j,newMax);
					if (newMax > max)
						max = newMax;
				}
			Console.WriteLine ("Max={0}", max);
		}
	}
}
