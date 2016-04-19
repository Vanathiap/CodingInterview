using System;
using System.Linq;

namespace Sorting
{
	public class MergeSort
	{
		public static int[] Sort(int[] array)
		{
			if (array.Length == 1)
				return array;
			//split
			var splitLength = array.Length / 2;
			int[] arr1 = Sort (array.Take (splitLength).ToArray());
			int[] arr2 = Sort (array.Skip (splitLength).ToArray());

			//merge
			int i = 0, j = 0, k=0;
			var sortedArray = new int[arr1.Length + arr2.Length];
			while (i < arr1.Length && j < arr2.Length) {
				if (arr1 [i] > arr2 [j]) {
					sortedArray [k++] = arr2 [j++];
				} else {
					sortedArray [k++] = arr1 [i++];
				}
			}
			while (i != arr1.Length) {
				sortedArray [k++] = arr1 [i++];
			}
			while (j != arr2.Length) {
				sortedArray [k++] = arr2 [j++];
			}

			return sortedArray;
		}
	}
}

