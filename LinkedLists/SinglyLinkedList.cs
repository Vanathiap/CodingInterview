using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedLists
{
	public class SinglyLinkedList
	{
		IList<Node> nodes;

		public SinglyLinkedList ()
		{
			nodes = new List<Node> ();
		}

		public SinglyLinkedList (IList<int> list)
		{
			nodes = new List<Node> (list.Count);
			for (int i = 0; i < list.Count; i++) {
				nodes.Add (new Node () { Data = list [i] });
			}
			for (int i = 0; i < list.Count-1; i++) {
				nodes [i].Next = nodes [i + 1];
			}
		}

		public Node Head {
			get { return nodes.Count == 0? null :nodes [0]; }
			set { nodes [0] = value;}
		}

		public Node Tail {
			get { return nodes.Count == 0? null :nodes [nodes.Count-1];}
			set	{ int index = nodes.Count == 0 ? 0 : nodes.Count - 1;
				nodes [index] = value;}
		}

		public override string ToString ()
		{
			var sb = new StringBuilder ();
			var currNode = Head;
			while (currNode != null) {
				sb.AppendFormat ("{0}->", currNode.Data);
				currNode = currNode.Next;
			}
			sb.Append ("null");
			return sb.ToString ();
		}
	}

	public class Node
	{
		public int Data {
			get;
			set;
		}

		public Node Next {
			get;
			set;
		}
	}
}