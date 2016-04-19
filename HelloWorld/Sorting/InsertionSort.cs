using System;

namespace Sorting
{
	public class InsertionSort
	{
		public static void Sort (int[] array)
		{
			if(array.Length > 1)
			{
			// sort first two items
				if (array [0] > array [1])
					Swap (ref array [0], ref array [1]);
			// insert the later items in the proper position
				for (int i = 2; i < array.Length; i++) {
					int k = 0;
					while (array [k] < array [i])
						k++;
					//k is the index for insertion
					int insertionItem = array[i];
					int j = i;
					while (j != k) {
						array[j]= array[j-1];
						j--;
					}
					array [k] = insertionItem;
					MainClass.Print (array);
				}
			}
		}

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
	}
}

