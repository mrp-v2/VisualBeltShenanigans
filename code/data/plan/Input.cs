using System.Collections.Generic;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.graph;

namespace VisualBeltShenanigans.code.data.plan
{
	public class Input : Node, ISplittable, ICanInsertMergerAfter
	{
		public Input(BeltContext context, decimal rate) : base(context, null, new List<Node>())
		{
			OutputRate = rate;
			Outputs.Add(new Output(context, this));
		}

		public override string DisplayName
		{
			get
			{
				return $"Input: {OutputRate}";
			}
		}

		public Merger InsertMergerAfter()
		{
			Merger merger = new Merger(Context, Outputs[0], this);
			merger.AddInputSafe(this, Outputs[0]);
			return merger;
		}

		public void Split(int count)
		{
			if (count <= 1)
			{
				return;
			}
			Outputs[0] = new Splitter(Context, this);
			(Outputs[0] as Splitter).Split(count);
		}
	}
}
