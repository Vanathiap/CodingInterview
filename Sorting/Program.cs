using System;

namespace Sorting
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Various sorting techniques:");
			var array = new int[] {7,9,2,8,3,4};

			Console.WriteLine ("Bubble sort");
			BubbleSort.Sort (array);
			Print (array);

			array = new int[] {7,9,2,8,3,4};
			Console.WriteLine ("Selection sort");
			SelectionSort.Sort (array);
			Print (array);

			array = new int[] {7,9,2,8,3,4};
			Console.WriteLine ("Insertion sort");
			InsertionSort.Sort (array);
			Print (array);
		}

		public static void Print(int[] array)
		{
			Console.WriteLine ("{0}", string.Join(",", array));
		}
	}
}
