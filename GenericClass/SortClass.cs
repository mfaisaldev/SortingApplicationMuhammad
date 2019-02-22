using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{	
	public class SortClass
	{
		private static List<string> AllSortedSteps = new List<string>();
		public static string[] BubbleSort(int[] arr)
		{
			AllSortedSteps.Clear();
			int temp = 0;						
			AllSortedSteps.Add(string.Join("", arr) + " -> ");
			for (int write = 0; write < arr.Length; write++)
			{
				for (int sort = 0; sort < arr.Length - 1; sort++)
				{
					if (arr[sort] > arr[sort + 1])
					{						
						temp = arr[sort + 1];
						arr[sort + 1] = arr[sort];
						arr[sort] = temp;
						AllSortedSteps.Add(string.Join("",arr) + " -> ");						
					}
				}
			}
			return AllSortedSteps.ToArray();
		}

		public static string[] BubbleSort(string[] arr)
		{
			AllSortedSteps.Clear();
			AllSortedSteps.Add(string.Join("", arr) + " -> ");
			for (var i = 1; i < arr.Length; i++)
			{
				for (var j = 0; j < arr.Length - i; j++)
				{
					if (string.Compare(arr[j], arr[j + 1], StringComparison.Ordinal) <= 0) continue;
					var temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
					AllSortedSteps.Add(string.Join("", arr) + " -> ");
				}
			}
			return AllSortedSteps.ToArray();
		}

		public static bool CheckArray(List<string> strList)
		{
			foreach(var txt in strList)
			{
				try
				{
					int txtt = Convert.ToInt16(txt);
				}
				catch
				{
					return false;
				}				
			}
			return true;
		}
	}
}
