using System;
using System.Windows.Forms;

using GraphX.Common.Enums;

using VisualBeltShenanigans.code.data.scenario;
using VisualBeltShenanigans.code.visual.prompt;
using VisualBeltShenanigans.visual.prompt;

namespace VisualBeltShenanigans.visual.form
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private BeltScenario _scenario;

		private void CreateScenarioButton_Click(object sender, System.EventArgs e)
		{
			ShowScenarioPrompt(new ScenarioPrompt());
		}

		private void ShowScenarioPrompt<T>(T prompt) where T : Form, IGetScenario
		{
			if (prompt.ShowDialog() == DialogResult.OK)
			{
				_scenario = prompt.GetScenario();
				MyScenarioDiaplayControl.SetScenario(_scenario);
			}
		}

		private void EditScenarioButton_Click(object sender, EventArgs e)
		{
			ScenarioPrompt prompt;
			if (_scenario == null)
			{
				prompt = new ScenarioPrompt();
			}
			else
			{
				prompt = new ScenarioPrompt(_scenario);
			}

			ShowScenarioPrompt(prompt);
		}

		private void GenerateGraphButton_Click(object sender, EventArgs e)
		{
			if (_scenario == null)
			{
				return;
			}
			if (LayoutModeSelection.SelectedItem == null)
			{
				return;
			}
			GraphForm graphForm = new GraphForm(_scenario.CalculatePlan(), (LayoutAlgorithmTypeEnum)LayoutModeSelection.SelectedItem);
			graphForm.Show();
		}
	}
}
