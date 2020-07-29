using System;
using System.Collections.Generic;
using System.Windows.Documents;

using MrpV2.GenericLibrary.code.extensions;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.graph;

namespace VisualBeltShenanigans.code.data.plan
{
	public class Merger : Node, ISplittable, ICanInsertMergerAfter
	{
		public override string DisplayName
		{
			get
			{
				return "Merger";
			}
		}

		public Merger(BeltContext context) : base(context, new List<Node>(), new List<Node>())
		{
			Outputs.Add(new Output(Context, this));
		}

		public Merger(BeltContext context, Node output, Node outputsOldInput) : base(context, new List<Node>(), new List<Node>())
		{
			Outputs.Add(output);
			output.ReassignInput(outputsOldInput, this);
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

		public Merger InsertMergerAfter()
		{
			Merger merger = new Merger(Context, Outputs[0], this);
			merger.AddInputSafe(this, Outputs[0]);
			return merger;
		}

		public void AddInputSafe(Node node, Node nodesOldOutput)
		{
			node.ReassignOutput(nodesOldOutput, this);
			Inputs.Add(node);
		}

		public void AddInputSafe(Output node)
		{
			if (Inputs.Count < Context.MergerInputs)
			{
				node.Inputs[0].ReassignOutput(node, this);
				Inputs.Add(node.Inputs[0]);
			}
			else
			{
				int lowestDepth = int.MaxValue;
				Merger bestMerger = null;
				foreach (Node input in Inputs)
				{
					if (input is Merger merger)
					{
						int i = merger.AddInputSafeDepth();
						if (i < lowestDepth)
						{
							lowestDepth = i;
							bestMerger = merger;
						}
					}
				}
				if (bestMerger == null)
				{
					Node temp = Inputs[Context.MergerInputs - 1];
					Merger merger = new Merger(Context, this, temp);
					merger.AddInputSafe(temp, this);
					merger.AddInputSafe(node);
				}
				else
				{
					bestMerger.AddInputSafe(node);
				}
			}
		}

		public void AddInputsSafe(List<Output> nodes)
		{
			for (int i = 0; i < nodes.Count; i++)
			{
				if (nodes[i].Inputs[0] is Splitter splitter)
				{
					if (nodes.Cast<List<Node>, Node, Output>().ContainsAll(splitter.Outputs))
					{
						nodes.RemoveAll(splitter.Outputs.Contains);
						Output newOutput = new Output(Context, splitter.Inputs[0]);
						nodes.Add(newOutput);
						splitter.Inputs[0].ReassignOutput(splitter, newOutput);
						i = -1;
					}
				}
			}
			foreach (Output node in nodes)
			{
				AddInputSafe(node);
			}
		}

		private int AddInputSafeDepth()
		{
			if (Inputs.Count < Context.MergerInputs)
			{
				return 0;
			}
			int lowest = int.MaxValue;
			foreach (Node node in Inputs)
			{
				if (node is Merger merger)
				{
					int i = merger.AddInputSafeDepth() + 1;
					if (i < lowest)
					{
						lowest = i;
					}
				}
			}
			return lowest == int.MaxValue ? 1 : lowest;
		}
	}
}
