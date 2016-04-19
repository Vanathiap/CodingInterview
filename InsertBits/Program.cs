using System;

namespace InsertBits
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (InsertBits(1024,19,2,6));
		}

		static int InsertBits(int n, int m, int i, int j)
		{
			return n | (m << i);
		}
	}
}
