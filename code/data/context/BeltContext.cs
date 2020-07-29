using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace VisualBeltShenanigans.code.data.context
{
	public class BeltContext : IEquatable<BeltContext>
	{
		public ImmutableHashSet<BeltSpeed> BeltSpeeds { get; }
		public int SplitterOutputs { get; }
		public int MergerInputs { get; }
		public string DisplayName { get; }

		private readonly SortedSet<int> _powers;
		private int _lastGeneratedBatch;

		public BeltContext(ImmutableHashSet<BeltSpeed> beltSpeeds, int splitterOutputs, int mergerInputs, string displayName)
		{
			if (splitterOutputs < 2)
			{
				throw new ArgumentException("Splitters must have at least 2 outputs!");
			}

			if (mergerInputs < 2)
			{
				throw new ArgumentException("Mergers must have at least 2 inputs!");
			}

			BeltSpeeds = beltSpeeds;
			SplitterOutputs = splitterOutputs;
			MergerInputs = mergerInputs;
			DisplayName = displayName;
			_powers = new SortedSet<int>() { 1 };
			_lastGeneratedBatch = 0;
		}

		public static readonly BeltContext SatisfactoryMk1 = new BeltContext(
			ImmutableHashSet<BeltSpeed>.Empty
			.Add(BeltSpeed.SatisfactoryTier1), 3, 3, "Satisfactory Mk1");
		public static readonly BeltContext SatisfactoryMk2 = new BeltContext(
			ImmutableHashSet<BeltSpeed>.Empty
			.Add(BeltSpeed.SatisfactoryTier1)
			.Add(BeltSpeed.SatisfactoryTier2), 3, 3, "Satisfactory Mk2");
		public static readonly BeltContext SatisfactoryMk3 = new BeltContext(
			ImmutableHashSet<BeltSpeed>.Empty
			.Add(BeltSpeed.SatisfactoryTier1)
			.Add(BeltSpeed.SatisfactoryTier2)
			.Add(BeltSpeed.SatisfactoryTier3), 3, 3, "Satisfactory Mk3");
		public static readonly BeltContext SatisfactoryMk4 = new BeltContext(
			ImmutableHashSet<BeltSpeed>.Empty
			.Add(BeltSpeed.SatisfactoryTier1)
			.Add(BeltSpeed.SatisfactoryTier2)
			.Add(BeltSpeed.SatisfactoryTier3)
			.Add(BeltSpeed.SatisfactoryTier4), 3, 3, "Satisfactory Mk4");
		public static readonly BeltContext SatisfactoryMk5 = new BeltContext(
			ImmutableHashSet<BeltSpeed>.Empty
			.Add(BeltSpeed.SatisfactoryTier1)
			.Add(BeltSpeed.SatisfactoryTier2)
			.Add(BeltSpeed.SatisfactoryTier3)
			.Add(BeltSpeed.SatisfactoryTier4)
			.Add(BeltSpeed.SatisfactoryTier5), 3, 3, "Satisfactory Mk5");

		public static readonly BeltContext FactorioMk1 = new BeltContext(
			ImmutableHashSet<BeltSpeed>.Empty
			.Add(BeltSpeed.FactorioTier1), 2, 2, "Factorio Mk1");
		public static readonly BeltContext FactorioMk2 = new BeltContext(
			ImmutableHashSet<BeltSpeed>.Empty
			.Add(BeltSpeed.FactorioTier1)
			.Add(BeltSpeed.FactorioTier2), 2, 2, "Factorio Mk2");
		public static readonly BeltContext FactorioMk3 = new BeltContext(
			ImmutableHashSet<BeltSpeed>.Empty
			.Add(BeltSpeed.FactorioTier1)
			.Add(BeltSpeed.FactorioTier2)
			.Add(BeltSpeed.FactorioTier3), 2, 2, "Factorio Mk3");

		public int GetSmallestPower(int target)
		{
			while (Math.Pow(2, _lastGeneratedBatch) < target)
			{
				GenerateNextBatch();
			}
			foreach (int i in _powers)
			{
				if (i >= target)
				{
					return i;
				}
			}
			throw new Exception();
		}

		public void GenerateNextBatch()
		{
			SortedSet<int> additions = new SortedSet<int>();
			for (int i = 2; i <= SplitterOutputs; i++)
			{
				foreach (int number in _powers)
				{
					additions.Add(number * i);
				}
			}
			foreach (int addition in additions)
			{
				_powers.Add(addition);
			}
			_lastGeneratedBatch++;
		}

		public override string ToString()
		{
			return DisplayName;
		}

		public string GetBeltTiersString()
		{
			string str = "";
			foreach (BeltSpeed tier in BeltSpeeds)
			{
				str += tier.ToString() + "\n";
			}
			return str;
		}

		public override int GetHashCode()
		{
			return (SplitterOutputs << 16) + (MergerInputs << 8) + DisplayName.GetHashCode();
		}

		public bool Equals(BeltContext other)
		{
			if (SplitterOutputs != other.SplitterOutputs)
			{
				return false;
			}

			if (MergerInputs != other.MergerInputs)
			{
				return false;
			}

			if (DisplayName != other.DisplayName)
			{
				return false;
			}

			return BeltSpeeds.SetEquals(other.BeltSpeeds);
		}

		public ImmutableSortedSet<int> GetCalculatedPowers()
		{
			return _powers.ToImmutableSortedSet();
		}
	}
}
