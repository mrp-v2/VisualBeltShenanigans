using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.code.data.plan;

namespace VisualBeltShenanigans.code.data.scenario
{
	public abstract class BeltScenario
	{
		public abstract BeltContext Context { get; }

		public abstract BeltPlan CalculatePlan();

		public abstract string GetOtherDataString();

		public abstract string GetBeltsInString();
	}
}
