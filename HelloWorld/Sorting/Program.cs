using System;

namespace Sorting
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Insertion sort");
			var array = new int[] { 6, 5, 3, 1, 8, 7, 2, 4, 6, 6 };
			InsertionSort.Sort (array);

			Console.WriteLine ("Quick sort");
			array = new int[] { 6, 5, 3, 1, 8, 7, 2, 4};
			QuickSort.Sort (array, 0, array.Length-1);
			Print (array);

			Console.WriteLine ("Merge sort");
			array = new int[] { 6, 5, 3, 1, 8, 7, 2, 4};
			var result = MergeSort.Sort (array);
			Print (result);
		}

		public static void Print(int[] array)
		{
			Console.WriteLine ("{0}", string.Join(",", array));
		}
	}
}
