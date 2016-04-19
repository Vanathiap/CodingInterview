using System;

namespace DecimalToBinary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("1.Decimal to Binary, 2.Binary to decimal");
			while (true) {
				Console.WriteLine ("Enter choice:");
				var n = Convert.ToInt32 (Console.ReadLine ());
				switch(n)
				{
				case 1:
					Console.WriteLine ("Enter Decimal");
					long i = Convert.ToInt64 (Console.ReadLine ());
					Console.WriteLine ("Binary {0}", Convert.ToString (i, 2));
					break;
				case 2:
					Console.WriteLine ("Enter Binary");
					var binaryInput = Console.ReadLine ();
					Console.WriteLine ("Decimal {0}", Convert.ToInt32 (binaryInput, 2));
					break;
				}
			}
		}
	}
}
