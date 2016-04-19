using System;
using System.Collections.Generic;
using System.Linq;

namespace Subset
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var subsets = GetAllSubsets (new List<int> { 1, 2,3,4 });
			subsets.Add (new List<int> ());
			foreach (var subset in subsets) {
				Console.Write ("{");
				Console.Write ("{0}", string.Join (",", subset));
				Console.Write ("},");
			}
		}

		static List<List<int>> GetAllSubsets(IList<int> arr)
		{
			if (arr.Count == 1) {
				return new List<List<int>> { new List<int> {arr[0]}};
			}
			var lastItem = arr [arr.Count - 1];
			var subsets = GetAllSubsets (arr.Take (arr.Count - 1).ToList());
			List<List<int>> result = new List<List<int>> ();
			result.Add (new List<int>{ lastItem });

			foreach (var item in subsets) {
				var list = new List<int> (item);
				list.Add (lastItem);
				result.Add (list);
			}
			result.AddRange (subsets);
			return result;
		}
	}
}
