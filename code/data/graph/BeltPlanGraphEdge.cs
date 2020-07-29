using System;

using GraphX.Common.Models;

using VisualBeltShenanigans.code.data.plan;

namespace VisualBeltShenanigans.code.data.graph
{
	public class BeltPlanGraphEdge : EdgeBase<Node>, IEquatable<BeltPlanGraphEdge>
	{
		public BeltPlanGraphEdge(Node source, Node target, double weight) : base(source, target, weight) { }

		public BeltPlanGraphEdge(Node source, Node target) : this(source, target, 1) { }

		public BeltPlanGraphEdge() : this(null, null, 1) { }

		public override string ToString()
		{
			return $"{decimal.Round(Source.OutputRate, 3)} i/m";
		}

		public bool Equals(BeltPlanGraphEdge other)
		{
			return Source.Equals(other.Source) && Target.Equals(other.Target);
		}
	}
}
