using System;

namespace Trees
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var sortedArray = new int[] { 1, 2, 3, 4, 5, 6 };
			var root = BST.Create (sortedArray, 0, sortedArray.Length - 1);

			var node = BST.Search (10, root);
			if (node == null)
				Console.WriteLine ("10 not found");
			else
				Console.WriteLine ("Found, 10->Left {0}, Right= {1}", node.Left == null ? "null" : node.Left.Data.ToString(), node.Right == null ? "null" : node.Right.Data.ToString());

			node = BST.Search (4, root);
			if (node == null)
				Console.WriteLine ("4 not found");
			else
				Console.WriteLine ("Found, 4->Left {0}, Right= {1}", node.Left == null ? "null" : node.Left.Data.ToString(), node.Right == null ? "null" : node.Right.Data.ToString());
		}
	}
}
