﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Merging linked lists");
			var list1 = new LinkedList<int>(new[]{1,3,5,7,9});
			var list2 = new LinkedList<int>(new[] {2,4,6,8,10});
			Print (list1);
			Print (list2);
			Print (MergeLinkedLists.Merge (list1, list2));

			Console.WriteLine ("Reverse singly linked list");
			var sll = new SinglyLinkedList (new[] { 1, 2, 3, 4, 5 });
			Console.WriteLine (sll);
			//ReverseLinkedList.ReverseSLL (sll);
			//Console.WriteLine (sll);
			var node = sll.Tail;
			ReverseLinkedList.Reverse (sll.Head, null);

			while (node != null) {
				Console.Write ("{0}->", node.Data);
				node = node.Next;
			}
			Console.Write ("null");
			//Console.WriteLine (sll);
		}

		public static void Print(LinkedList<int> list)
		{
			var currNode = list.First;
			while (currNode != null) {
				Console.Write ("{0}->", currNode.Value);
				currNode = currNode.Next;
			}
			Console.Write ("null");
			Console.WriteLine ();
		}
	}
}
