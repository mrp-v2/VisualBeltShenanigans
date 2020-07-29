using System;
using System.Windows.Forms;

using VisualBeltShenanigans.code.data.scenario;
using VisualBeltShenanigans.code.visual.prompt;

namespace VisualBeltShenanigans.visual.prompt
{
	public partial class ScenarioPrompt : Form, IGetScenario
	{
		public ScenarioPrompt()
		{
			InitializeComponent();
		}

		private readonly BeltScenario _toEdit;

		public ScenarioPrompt(BeltScenario toEdit) : this()
		{
			_toEdit = toEdit;
			Load += Form_Load;
		}

		private void Form_Load(object sender, EventArgs e)
		{
			if (_toEdit is BeltBalancingScenario)
			{
				ShowScenarioPrompt(new BalancingScenarioPrompt(_toEdit as BeltBalancingScenario));
			}
			else if (_toEdit is BeltSubtractingScenario)
			{
				ShowScenarioPrompt(new SubtractingScenarioPrompt(_toEdit as BeltSubtractingScenario));
			}
		}

		private BeltScenario scenario;

		private void MyCancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void BalancingScenarioButton_Click(object sender, EventArgs e)
		{
			ShowScenarioPrompt(new BalancingScenarioPrompt());
		}

		private void SubtractingScenarioButton_Click(object sender, EventArgs e)
		{
			ShowScenarioPrompt(new SubtractingScenarioPrompt());
		}

		public BeltScenario GetScenario()
		{
			return scenario;
		}

		private void ShowScenarioPrompt<T>(T prompt) where T : Form, IGetScenario
		{
			if (prompt.ShowDialog() == DialogResult.OK)
			{
				scenario = prompt.GetScenario();
				DialogResult = DialogResult.OK;
				Close();
			}
		}
	}
}
