using System.Collections.Generic;
using System.Collections.Immutable;

using MrpV2.GenericLibrary.code.extensions;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.plan;

namespace VisualBeltShenanigans.code.data.scenario
{
	public class BeltBalancingScenario : BeltScenario
	{
		public override BeltContext Context { get; }
		public ImmutableList<decimal> BeltsIn { get; }
		public int BeltsOut { get; }

		public BeltBalancingScenario(ImmutableList<decimal> beltsIn, int beltsOut, BeltContext context)
		{
			BeltsIn = beltsIn;
			BeltsOut = beltsOut;
			Context = context;
		}

		public decimal BeltsOutRate
		{
			get
			{
				decimal sum = 0;
				foreach (decimal d in BeltsIn)
				{
					sum += d;
				}
				return sum / BeltsOut;
			}
		}

		public override BeltPlan CalculatePlan()
		{
			List<Input> inputs = new List<Input>();
			foreach (decimal d in BeltsIn)
			{
				inputs.Add(new Input(Context, d));
			}
			BeltPlan plan = new BeltPlan(Context, ImmutableList.CreateRange(inputs));
			List<List<Output>> allNodes = new List<List<Output>>();
			foreach (Input input in inputs)
			{
				(input as ISplittable).Split(BeltsOut);
				allNodes.Add(input.GetFinalOutputs());
			}
			for (int i = 0; i < BeltsOut; i++)
			{
				Merger merger = new Merger(Context);
				foreach (List<Output> nodes in allNodes)
				{
					merger.AddInputSafe(nodes[i]);
				}
			}
			plan.Simplify();
			return plan;
		}

		public override string GetOtherDataString()
		{
			return $"Belts Out: {BeltsOut} x {BeltsOutRate}";
		}

		public override string GetBeltsInString()
		{
			string str = "";
			foreach (decimal d in BeltsIn)
			{
				str += d.ToString() + "\n";
			}
			return str;
		}
	}
}
