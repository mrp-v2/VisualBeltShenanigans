using System;
using System.Collections.Generic;
using System.Collections.Immutable;

using MrpV2.GenericLibrary.code.extensions;

namespace VisualBeltShenanigans.code.util
{
	public class Sum : IEquatable<Sum>, IEquatable<decimal>
	{
		public ImmutableList<decimal> Parts { get; }

		public Sum(ImmutableList<decimal> parts)
		{
			Parts = parts;
		}

		public decimal Total
		{
			get
			{
				decimal total = 0;
				foreach (decimal d in Parts)
				{
					total += d;
				}
				return total;
			}
		}

		public decimal Variety
		{
			get
			{
				SortedSet<decimal> uniques = new SortedSet<decimal>();
				foreach (decimal d in Parts)
				{
					uniques.Add(d);
				}
				return uniques.Count / Parts.Count;
			}
		}

		public override int GetHashCode()
		{
			return Total.GetHashCode();
		}

		public bool Equals(Sum other)
		{
			if (other == null)
			{
				return false;
			}

			if (other == this)
			{
				return true;
			}
			return Parts.EqualContents(other.Parts);
		}

		public bool Equals(decimal other)
		{
			return Total == other;
		}

		public override string ToString()
		{
			string str = "{";
			for (int i = 0; i < Parts.Count; i++)
			{
				str += $"{Parts[i]}";
				if (i < Parts.Count - 1)
				{
					str += ",";
				}
			}
			return str + "}";
		}
	}
}
