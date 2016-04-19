using System;

namespace Sorting
{
	public class SelectionSort
	{
		public static void Sort (int[] array)
		{
			for (int i = 0; i < array.Length; i++) {
				for (int j = i+1; j < array.Length; j++) {
					if (array [i] > array [j]) {
						int temp = array [i];
						array [i] = array [j];
						array [j] = temp;
						MainClass.Print (array);
					}
				}
			}
		}
	}
}

