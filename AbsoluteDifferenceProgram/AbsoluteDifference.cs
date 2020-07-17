using System;

namespace AbsoluteDifferenceProgram
{
	public class AbsoluteDifference
	{
		public static void Main(string[] args)
		{
			int k = 3;
			int[] a = new int[] { 1, 4, 6, 9 };
			int n = a.Length;
			Console.WriteLine(KthDiff(a, n, k));
		}
		// returns number of pairs with absolute 
		// difference less than or equal to mid 
		public static int CountPairs(int[] a, int n, int mid)
		{
			int res = 0;
			for (int i = 0; i < n; i++)
			{
				// Upper bound returns pointer to position 
				// of next higher number than a[i]+mid in 
				// a[i..n-1]. We subtract (ub + i + 1) from 
				// this position to count 
				int ub = Upperbound(a, n, a[i] + mid);
				res += (ub - (i - 1));
			}
			return res;
		}

		// returns the upper bound 
		public static int Upperbound(int[] a, int n, int value)
		{
			int low = 0;
			int high = n;
			while (low < high)
			{
			
				int mid = (low + high) / 2;
				if (value >= a[mid])
				{
					low = mid + 1;
				}
				else
				{
					high = mid;
				}
			}

			return low;
		}

		// Returns k-th absolute difference 
		public static int KthDiff(int[] a, int n, int k)
		{
			// Sort array 
			Array.Sort(a);
			// Minimum absolute difference 
			int low = a[1] - a[0];
			for (int i = 1; i <= n - 2; ++i)
			{
				low = Math.Min(low, a[i + 1] - a[i]);
			}

			// Maximum absolute difference 
			int high = a[n - 1] - a[0];

			// Do binary search for k-th absolute difference 
			while (low < high)
			{
				int mid = (low + high) >> 1;
				if (CountPairs(a, n, mid) < k)
				{
					low = mid + 1;
				}
				else
				{
					high = mid;
				}
			}

			return low;
		}
	}
}

