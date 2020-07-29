using System;
using System.Windows.Forms;

using VisualBeltShenanigans.code.data.scenario;
using VisualBeltShenanigans.code.visual.prompt;

namespace VisualBeltShenanigans.visual.prompt
{
	public partial class SubtractingScenarioPrompt : Form, IGetScenario
	{
		public SubtractingScenarioPrompt()
		{
			InitializeComponent();
		}

		public SubtractingScenarioPrompt(BeltSubtractingScenario toEdit) : this()
		{
			BeltInNumeric.Value = toEdit.BeltIn;
			SubtractedNumeric.Value = toEdit.SubtractedAmount;
			MyBeltScenarioBaseControl.BeltContext = toEdit.Context;
		}

		public BeltScenario GetScenario()
		{
			return new BeltSubtractingScenario(BeltInNumeric.Value, SubtractedNumeric.Value, MyBeltScenarioBaseControl.BeltContext);
		}

		private void MyOkButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void MyCancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
