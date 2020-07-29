using System.Collections.Generic;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.graph;

namespace VisualBeltShenanigans.code.data.plan
{
	public class Output : Node
	{
		public Output(BeltContext context, Node input) : base(context, new List<Node>(), null)
		{
			Inputs.Add(input);
		}

		public override string DisplayName
		{
			get
			{
				return "Output";
			}
		}
	}
}
