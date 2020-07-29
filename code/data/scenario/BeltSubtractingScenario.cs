using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;

using MrpV2.GenericLibrary.code.extensions;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.plan;
using VisualBeltShenanigans.code.util;

namespace VisualBeltShenanigans.code.data.scenario
{
	public class BeltSubtractingScenario : BeltScenario
	{
		public override BeltContext Context { get; }
		public decimal BeltIn { get; }
		public decimal SubtractedAmount { get; }

		public BeltSubtractingScenario(decimal beltIn, decimal subtractedAmount, BeltContext context)
		{
			BeltIn = beltIn;
			SubtractedAmount = subtractedAmount;
			Context = context;
			if (SubtractedAmount > BeltIn)
			{
				throw new ArgumentOutOfRangeException($"The amount to be subtracted ({SubtractedAmount}) is greater than the input ({BeltIn})!");
			}
		}

		public override BeltPlan CalculatePlan()
		{
			if (BeltIn == SubtractedAmount)
			{
				List<Input> inputs = new List<Input>
				{
					new Input(Context, BeltIn)
				};
				BeltPlan bp = new BeltPlan(Context, inputs.ToImmutableList());
				return bp;
			}
			else
			{
				ImmutableList<decimal> rates = ImmutableList<decimal>.Empty.Add(BeltIn);
				int chosenDivisor = 1;
				List<Sum> combinationsForAmount = GetCombinationsToMatchAmount(rates, SubtractedAmount);
				while (combinationsForAmount.Count == 0)
				{
					chosenDivisor++;
					rates = NumberManipulation.DivideList(ImmutableList<decimal>.Empty.Add(BeltIn), chosenDivisor);
					combinationsForAmount = GetCombinationsToMatchAmount(rates, SubtractedAmount);
				}
				Sum chosenSum = null;
				foreach (Sum sum in combinationsForAmount)
				{
					if (chosenSum == null)
					{
						chosenSum = sum;
						continue;
					}
					if (sum.Variety < chosenSum.Variety)
					{
						chosenSum = sum;
					}
					else if (sum.Variety == chosenSum.Variety)
					{
						if (sum.Parts.Count < chosenSum.Parts.Count)
						{
							chosenSum = sum;
						}
					}
				}
				List<Input> inputs = new List<Input>
				{
					new Input(Context, BeltIn)
				};
				List<decimal> remainingRates = new List<decimal>(chosenSum.Parts);
				List<Input> relevantInputs = new List<Input>();
				foreach (Input input in inputs)
				{
					if (remainingRates.Contains(input.OutputRate / chosenDivisor))
					{
						input.Split(chosenDivisor);
						for (int i = 0; i < chosenDivisor; i++)
						{
							remainingRates.Remove(input.OutputRate / chosenDivisor);
						}
						relevantInputs.Add(input);
					}
				}
				List<Output> relevantNodes = new List<Output>();
				foreach (Input input in relevantInputs)
				{
					relevantNodes.AddRange(input.GetFinalOutputs());
				}
				remainingRates = new List<decimal>(chosenSum.Parts);
				List<Output> outputsToMerge = new List<Output>();
				List<Output> otherOutputsToMerge = new List<Output>();
				foreach (Output node in relevantNodes.Reverse<Output>())
				{
					decimal outRate = node.OutputRate;
					if (remainingRates.Contains(outRate))
					{
						outputsToMerge.Add(node);
						remainingRates.Remove(outRate);
					}
					else
					{
						otherOutputsToMerge.Add(node);
					}
				}
				Merger merger = new Merger(Context);
				merger.AddInputsSafe(outputsToMerge);
				merger = new Merger(Context);
				merger.AddInputsSafe(otherOutputsToMerge);
				BeltPlan bp = new BeltPlan(Context, inputs.ToImmutableList());
				bp.Simplify();
				return bp;
			}
		}

		public override string GetOtherDataString()
		{
			return $"Amount subtracted: {SubtractedAmount}";
		}

		private static List<Sum> GetCombinationsToMatchAmount(ImmutableList<decimal> rates, decimal target)
		{
			List<Sum> sums = new List<Sum>();
			foreach (Sum sum in NumberManipulation.AllCombinations(rates))
			{
				if (sum.Total == target)
				{
					sums.Add(sum);
				}
			}
			return sums;
		}

		public override string GetBeltsInString()
		{
			return BeltIn.ToString() + "\n";
		}
	}
}
