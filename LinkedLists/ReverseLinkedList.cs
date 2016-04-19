using System;
using System.Collections.Generic;

namespace LinkedLists
{
	public class ReverseLinkedList
	{
		//DLL - doubly linked list
		public static LinkedList<T> ReverseDLL<T>(LinkedList<T> list)
		{
			var currNode = list.First;

			//while (currNode != null) {
			//	var temp = currNode.Next;
			//	currNode.Next = currNode.Previous;
			//	currNode.Previous = temp;
			//}

			return list;
		}

		public static void ReverseSLL(SinglyLinkedList list)
		{
			var currNode = list.Head;
			Node prevNode = null;
			Node nextNode = null;

			while (currNode != null) {
				nextNode = currNode.Next;
				currNode.Next = prevNode;
				prevNode = currNode;
				currNode = nextNode;
			}
			list.Head = prevNode;
		}

		public static void Reverse(Node currNode, Node prevNode)
		{
			if (currNode.Next == null)				
				return;
			var next = currNode.Next;
			currNode.Next = prevNode;
			Reverse (next, currNode);
		}
	}
}