using System;
using System.Collections.Generic;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.graph;

namespace VisualBeltShenanigans.code.data.plan
{
	public class Splitter : Node, ISplittable
	{
		public override string DisplayName
		{
			get
			{
				return "Splitter";
			}
		}

		public Splitter(BeltContext context, Node input) : this(context, input, 1) { }

		public Splitter(BeltContext context, Node input, int outputs) : base(context, new List<Node>(), new List<Node>())
		{
			if (outputs > context.SplitterOutputs)
			{
				throw new ArgumentException("Can't have more outputs than the context allows!");
			}

			Inputs.Add(input);
			for (int i = 0; i < outputs; i++)
			{
				Outputs.Add(new Output(context, this));
			}
		}

		public void Split(int count)
		{
			Outputs.Clear();
			int smallestPower = Context.GetSmallestPower(count);
			SplitIntoPower(smallestPower);
			//do the merging
			List<Output> finals = GetFinalOutputs();
			List<Output> outputsToAdd = new List<Output>();
			for (int i = 0; i < smallestPower - count; i++)
			{
				outputsToAdd.Add(finals[i]);
			}
			if (outputsToAdd.Count > 0)
			{
				Node oldInput = Inputs[0];
				Merger merger = (oldInput as ICanInsertMergerAfter).InsertMergerAfter();
				merger.AddInputsSafe(outputsToAdd);
				merger.OutputRate = oldInput.OutputRate + oldInput.OutputRate / count * (smallestPower - count);
			}
		}

		private void SplitIntoPower(int outputs)
		{
			if (outputs == 1)
			{
				return;
			}
			int tempOutputs = outputs;
			int thisOutputs = 0;
		Dividing:
			for (int i = Context.SplitterOutputs; i > 0; i--)
			{
				if (tempOutputs % i == 0)
				{
					tempOutputs /= i;
					if (tempOutputs == 1)
					{
						thisOutputs = i;
						break;
					}
					goto Dividing;
				}
			}
			if (thisOutputs == 0)
			{
				throw new ArgumentException("The given number of outputs is not divisible by the possible number of outputs or any integer less than the possible number of outputs!");
			}

			if (outputs / thisOutputs > 1)
			{
				for (int i = 0; i < thisOutputs; i++)
				{
					base.Outputs.Add(new Splitter(Context, this, 0));
				}
				foreach (Node node in base.Outputs)
				{
					(node as Splitter).SplitIntoPower(outputs / thisOutputs);
				}
			}
			else
			{
				for (int i = 0; i < thisOutputs; i++)
				{
					base.Outputs.Add(new Output(Context, this));
				}
			}
		}

		internal bool SimplifyUselessSplit()
		{
			foreach (Node node in Outputs)
			{
				if (!(node is Output))
				{
					return false;
				}
			}
			Inputs[0].ReassignOutput(this, new Output(Context, Inputs[0]));
			return true;
		}

		internal bool SimplifyRedundantSplit()
		{
			for (int i = 1; i < Outputs.Count; i++)
			{
				if (Outputs[0] != Outputs[i])
				{
					return false;
				}
			}
			Inputs[0].ReassignOutput(this, Outputs[0]);
			for (int i = 1; i < Outputs.Count; i++)
			{
				Outputs[0].Inputs.Remove(this);
			}
			Outputs[0].ReassignInput(this, Inputs[0]);
			return true;
		}
	}
}
