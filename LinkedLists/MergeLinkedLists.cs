using System;
using System.Collections.Generic;

namespace LinkedLists
{
	public class MergeLinkedLists
	{
		public static LinkedList<T> Merge<T>(LinkedList<T> list1, LinkedList<T> list2) where T:IComparable<T>
		{
			var list = new LinkedList<T> ();
			var list1CurrNode = list1.First;
			var list2CurrNode = list2.First;

			while (list1CurrNode != null && list2CurrNode != null) {
				if (list1CurrNode.Value.CompareTo(list2CurrNode.Value) >0) {
					list.AddLast (list2CurrNode.Value);
					list2CurrNode = list2CurrNode.Next;
				} else {
					list.AddLast (list1CurrNode.Value);
					list1CurrNode = list1CurrNode.Next;
				}
			}

			while (list1CurrNode != null) {
				list.AddLast (list1CurrNode.Value);
				list1CurrNode = list1CurrNode.Next;
			}

			while (list2CurrNode != null) {
				list.AddLast (list2CurrNode.Value);
				list2CurrNode = list2CurrNode.Next;
			}
			return list;
		}


	}
}

