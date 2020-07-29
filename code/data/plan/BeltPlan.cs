using System;
using System.Collections.Generic;
using System.Collections.Immutable;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.graph;

namespace VisualBeltShenanigans.code.data.plan
{
	public class BeltPlan
	{
		public BeltContext Context { get; }

		private readonly ImmutableList<Input> _inputNodes;

		public BeltPlan(BeltContext context, ImmutableList<Input> inputNodes)
		{
			Context = context;
			_inputNodes = inputNodes;
		}

		public List<Node> AssembleVertexes()
		{
			List<Node> vertexes = new List<Node>();
			foreach (Node n in _inputNodes)
			{
				n.AssembleVertexes(vertexes);
			}
			return vertexes;
		}

		public List<BeltPlanGraphEdge> AssembleEdges()
		{
			List<BeltPlanGraphEdge> edges = new List<BeltPlanGraphEdge>();
			foreach (Node n in _inputNodes)
			{
				n.AssembleEdges(edges);
			}
			return edges;
		}

		public void Simplify()
		{
			while (_inputNodes[0].Simplify()) { }
		}
	}
}
