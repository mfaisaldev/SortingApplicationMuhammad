using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
	public class QuickSort
	{
		public static List<string> sortedArray = new List<string>();
		
		public static string[] QuickSortMethod(int[] A, int left, int right)
		{
			if (left > right || left < 0 || right < 0) return new string[0];

			int index = Partition(A, left, right);
			
			if (index != -1)
			{
				QuickSortMethod(A, left, index - 1);
				QuickSortMethod(A, index + 1, right);				
			}
			
			return sortedArray.ToArray();
		}

		private static int Partition(int[] A, int left, int right)
		{
			if (left > right) return -1;

			int end = left;

			int pivot = A[right];
			for (int i = left; i < right; i++)
			{
				if (A[i] < pivot)
				{
					Swap(A, i, end);
					end++;					
				}
			}

			Swap(A, end, right);

			return end;
		}

		private static void Swap(int[] A, int left, int right)
		{
			int tmp = A[left];
			A[left] = A[right];
			A[right] = tmp;
			sortedArray.Add(string.Join("", A) + " -> ");
		}

		// Quick Sort for String

		public static string[] QuickSortMethod(string[] elements, int left, int right)
		{
			
			int i = left, j = right;
			string pivot = elements[(left + right) / 2];

			while (i <= j)
			{
				while (elements[i].CompareTo(pivot) < 0)
				{
					i++;
				}

				while (elements[j].CompareTo(pivot) > 0)
				{
					j--;
				}

				if (i <= j)
				{
					// Swap
					string tmp = elements[i];
					elements[i] = elements[j];
					elements[j] = tmp;
					sortedArray.Add(string.Join("", elements) + " -> ");
					i++;
					j--;
				}
			}

			// Recursive calls
			if (left < j)
			{
				QuickSortMethod(elements, left, j);
			}

			if (i < right)
			{
				QuickSortMethod(elements, i, right);
			}
			return sortedArray.ToArray();
		}
	}
}
