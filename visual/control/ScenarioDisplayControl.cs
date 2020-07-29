using System.Windows.Forms;

using VisualBeltShenanigans.code.data.scenario;

namespace VisualBeltShenanigans.visual.control
{
	public partial class ScenarioDisplayControl : UserControl
	{
		public ScenarioDisplayControl()
		{
			InitializeComponent();
		}

		public void SetScenario(BeltScenario scenario)
		{
			ContextNameValue.Text = scenario.Context.DisplayName;
			SplitterOutputsValue.Text = scenario.Context.SplitterOutputs.ToString();
			MergerInputsValue.Text = scenario.Context.MergerInputs.ToString();
			BeltTiersValue.Text = scenario.Context.GetBeltTiersString();
			BeltsInValue.Text = scenario.GetBeltsInString();
			OtherDataValue.Text = scenario.GetOtherDataString();
		}
	}
}
