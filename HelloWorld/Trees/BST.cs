using System;

namespace Trees
{
	public class BSNode
	{
		int data;
		BSNode left;
		BSNode right;

		public BSNode ()
		{
			
		}

		public BSNode (int data, BSNode left, BSNode right)
		{
			this.data = data;
			this.left = left;
			this.right = right;
		}

		public int Data {
			get { return data;}
			set { data = value; }
		}

		public BSNode Left {
			get { return left;}
			set { left = value; }
		}

		public BSNode Right {
			get { return right;}
			set { left = value; }
		}
	}

	public static class BST
	{
		public static BSNode Search(int data, BSNode node)
		{
			if (node == null)
				return null;
			else if (node.Data == data)
				return node;
			else if (node.Data < data)
				return Search (data, node.Right);
			else
				return Search (data, node.Left);
		}

		public static BSNode Create(int[] sortedArray, int startIndex, int endIndex)
		{
			if (startIndex > endIndex)
				return null;
			else {
				var rootNode = new BSNode ();
				int midIndex = (endIndex + startIndex) / 2;
				rootNode.Data = sortedArray [midIndex];
				rootNode.Left = Create (sortedArray, startIndex, midIndex - 1);
				rootNode.Right = Create (sortedArray, midIndex + 1, endIndex);
				return rootNode;
			}
		}
	}
}