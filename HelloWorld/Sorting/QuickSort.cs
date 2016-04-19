using System;

namespace Sorting
{
	public class QuickSort
	{
		public static void Sort (int[] array, int startIndex, int endIndex)
		{
			if (startIndex != endIndex) {
				//find pivot element
				int pivotIndex = Partition(array, startIndex, endIndex);
				MainClass.Print (array);

				// keep elements left or right with respect to pivot
				if(pivotIndex > startIndex)
					Sort (array, startIndex, pivotIndex-1);
				if(pivotIndex < endIndex)
					Sort (array, pivotIndex + 1, endIndex);
			}
		}

		public static int Partition(int[] array, int startIndex, int endIndex)
		{
			int midIndex = (endIndex-startIndex) / 2;
			int midItem = array [midIndex];
			int i = startIndex;
			int j = endIndex;
			while (i < j) {
				while (array [i] < midItem)
					i++;
				while (array [j] > midItem)
					j--;

				if (i < j) {
					int temp = array [i];
					array [i] = array [j];
					array [j] = temp;
				}
			}
			return i;
		}
	}
}