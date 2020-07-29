using System.Collections.Generic;
using System.Collections.Immutable;

namespace VisualBeltShenanigans.code.util
{
	public static class NumberManipulation
	{
		public static HashSet<Sum> AllCombinations(ImmutableList<decimal> numbers)
		{
			HashSet<Sum> sums = new HashSet<Sum>();
			for (int count = 1; count <= numbers.Count; count++)
			{
				foreach (Sum sum in AllCombinationsOfCount(count, numbers))
				{
					sums.Add(sum);
				}
			}
			return sums;
		}

		private static HashSet<Sum> AllCombinationsOfCount(int count, ImmutableList<decimal> numbers)
		{
			SortedSet<decimal> uniqueNumbers = new SortedSet<decimal>(numbers);
			HashSet<Sum> sums = new HashSet<Sum>();
			foreach (decimal uniqueNumber in uniqueNumbers)
			{
				if (count > 1)
				{
					foreach (Sum sum in AllCombinationsOfCount(count - 1, numbers.Remove(uniqueNumber)))
					{
						sums.Add(new Sum(sum.Parts.Add(uniqueNumber)));
					}
				}
				else
				{
					sums.Add(new Sum(ImmutableList<decimal>.Empty.Add(uniqueNumber)));
				}
			}
			return sums;
		}

		public static ImmutableList<decimal> DivideList(ImmutableList<decimal> list, int divisor)
		{
			List<decimal> newList = new List<decimal>();
			foreach (decimal d in list)
			{
				for (int i = 0; i < divisor; i++)
				{
					newList.Add(d / divisor);
				}
			}
			return newList.ToImmutableList();
		}
	}
}
