using System;
using System.Collections.Generic;
using System.Windows.Markup;

using GraphX.Common.Models;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.graph;

namespace VisualBeltShenanigans.code.data.plan
{
	public abstract class Node : VertexBase, IEquatable<Node>
	{
		public readonly BeltContext Context;

		public List<Node> Inputs { get; }
		public List<Node> Outputs { get; }

		private decimal _outputRate;
		public decimal OutputRate
		{
			get
			{
				if (_outputRate > 0)
				{
					return _outputRate;
				}
				decimal sum = 0;
				foreach (Node node in Inputs)
				{
					sum += node.OutputRate;
				}
				return Outputs == null ? sum : sum / Outputs.Count;
			}
			set
			{
				_outputRate = value;
			}
		}

		public Node(BeltContext context, List<Node> inputs, List<Node> outputs)
		{
			Context = context;
			Inputs = inputs;
			Outputs = outputs;
			_outputRate = -1;
		}

		public void AssembleVertexes(List<Node> nodes)
		{
			if (nodes.Contains(this))
			{
				return;
			}
			nodes.Add(this);
			if (Inputs != null)
			{
				foreach (Node n in Inputs)
				{
					n.AssembleVertexes(nodes);
				}
			}
			if (Outputs != null)
			{
				foreach (Node n in Outputs)
				{
					n.AssembleVertexes(nodes);
				}
			}
		}

		public void AssembleEdges(List<BeltPlanGraphEdge> edges)
		{
			BeltPlanGraphEdge edge;
			if (Inputs != null)
			{
				foreach (Node n in Inputs)
				{
					edge = new BeltPlanGraphEdge(n, this);
					if (edges.Contains(edge))
					{
						continue;
					}
					edges.Add(edge);
					n.AssembleEdges(edges);
				}
			}
			if (Outputs != null)
			{
				foreach (Node n in Outputs)
				{
					edge = new BeltPlanGraphEdge(this, n);
					if (edges.Contains(edge))
					{
						continue;
					}
					edges.Add(edge);
					n.AssembleEdges(edges);
				}
			}
		}

		public abstract string DisplayName { get; }

		public override string ToString()
		{
			return DisplayName;
		}

		public bool Equals(Node other)
		{
			return other == this;
		}

		public List<Output> GetFinalOutputs()
		{
			List<Output> nodes = new List<Output>();
			GetFinalOutputsRecursive(nodes, new List<Node>());
			return nodes;
		}

		public void GetFinalOutputsRecursive(List<Output> outputs, List<Node> visitedNodes)
		{
			if (ContinueGraphOperation(visitedNodes))
			{
				if (this is Output output)
				{
					outputs.Add(output);
					return;
				}
				if (Outputs.Count == 0)
				{
					throw new IllegalStateException("Node has 0 outputs, but must have at least 1!");
				}
				foreach (Node node in Outputs)
				{
					node.GetFinalOutputsRecursive(outputs, visitedNodes);
				}
			}
		}

		public string GetRateDisplayString(Node output)
		{
			int identicalOutputs = GetIdenticalOutputsCount(output);
			return $"{decimal.Round(OutputRate, 3)}{(identicalOutputs > 1 ? $" x{identicalOutputs}" : "")} i/m";
		}

		private int GetIdenticalOutputsCount(Node output)
		{
			int i = 0;
			foreach (Node node in Outputs)
			{
				if (node is Output)
				{
					continue;
				}
				if (node == output)
				{
					i++;
				}
			}
			return i;
		}

		protected bool ContinueGraphOperation(List<Node> visitedNodes)
		{
			if (visitedNodes.Contains(this))
			{
				return false;
			}
			visitedNodes.Add(this);
			return true;
		}

		public bool Simplify()
		{
			return SimplifyRecursive(new List<Node>());
		}

		private bool SimplifyRecursive(List<Node> visitedNodes)
		{
			if (ContinueGraphOperation(visitedNodes))
			{
				if (Inputs == null)
				{
					return Outputs[0].SimplifyRecursive(visitedNodes);
				}
				if (Outputs == null)
				{
					return Inputs[0].SimplifyRecursive(visitedNodes);
				}
				if (SimplifyPassthroughNode())
				{
					return true;
				}
				if (this is Splitter splitter)
				{
					if (splitter.SimplifyUselessSplit())
					{
						return true;
					}
					if (splitter.SimplifyRedundantSplit())
					{
						return true;
					}
				}
				foreach (Node n in Inputs)
				{
					if (n.SimplifyRecursive(visitedNodes))
					{
						return true;
					}
				}
				foreach (Node n in Outputs)
				{
					if (n.SimplifyRecursive(visitedNodes))
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool SimplifyPassthroughNode()
		{
			if (Inputs.Count != 1)
			{
				return false;
			}
			if (Outputs.Count != 1)
			{
				return false;
			}
			Inputs[0].ReassignOutput(this, Outputs[0]);
			Outputs[0].ReassignInput(this, Inputs[0]);
			return true;
		}

		internal void ReassignOutput(Node oldOutput, Node newOutput)
		{
			if (Outputs == null)
			{
				Inputs[0].ReassignOutput(this, newOutput);
			}
			else if (Outputs.Count == 1)
			{
				Outputs.Clear();
				Outputs.Add(newOutput);
			}
			else if (Outputs.Count > 1)
			{
				Outputs.Remove(oldOutput);
				Outputs.Add(newOutput);
			}
		}

		internal void ReassignInput(Node oldInput, Node newInput)
		{
			if (Inputs == null)
			{
				throw new NotSupportedException();
			}
			else if (Inputs.Count == 1)
			{
				Inputs.Clear();
				Inputs.Add(newInput);
			}
			else if (Inputs.Count > 1)
			{
				Inputs.Remove(oldInput);
				Inputs.Add(newInput);
			}
		}

		protected internal class IllegalStateException : Exception
		{
			public IllegalStateException(string message) : base(message) { }
		}
	}
}
