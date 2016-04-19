using System;

namespace Sorting
{
	public class BubbleSort
	{
		public static void Sort (int[] array)
		{
			var swapped = true;
			int j = 0;
			while (swapped) {
				swapped = false;
				j++;

				for (int i = 0; i < array.Length - j; i++) {
					if (array [i] > array [i + 1]) {
						int temp = array [i];
						array [i] = array [i + 1];
						array [i + 1] = temp;
						swapped = true;
					}
				}
				MainClass.Print (array);
			}
		}
	}
}

