using System;

namespace VisualBeltShenanigans.code.data.context
{
	public struct BeltSpeed : IEquatable<BeltSpeed>
	{
		public int Tier { get; }
		/// <summary>
		/// The speed of the belt in items/minute
		/// </summary>
		public decimal Speed { get; }

		public BeltSpeed(int tier, decimal speed)
		{
			Tier = tier;
			Speed = speed;
		}

		public static readonly BeltSpeed SatisfactoryTier1 = new BeltSpeed(1, 60);
		public static readonly BeltSpeed SatisfactoryTier2 = new BeltSpeed(2, 120);
		public static readonly BeltSpeed SatisfactoryTier3 = new BeltSpeed(3, 270);
		public static readonly BeltSpeed SatisfactoryTier4 = new BeltSpeed(4, 480);
		public static readonly BeltSpeed SatisfactoryTier5 = new BeltSpeed(5, 780);

		public static readonly BeltSpeed FactorioTier1 = new BeltSpeed(1, 900);
		public static readonly BeltSpeed FactorioTier2 = new BeltSpeed(2, 1800);
		public static readonly BeltSpeed FactorioTier3 = new BeltSpeed(3, 2700);

		public override string ToString()
		{
			return $"{Tier}, {Speed} i/min";
		}

		public override int GetHashCode()
		{
			return Speed.GetHashCode() + Tier;
		}

		public bool Equals(BeltSpeed other)
		{
			return Tier == other.Tier && Speed == other.Speed;
		}
	}
}
