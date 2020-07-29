using System;
using System.Collections.Immutable;
using System.Windows.Forms;

using VisualBeltShenanigans.code.data.scenario;
using VisualBeltShenanigans.code.visual.prompt;

namespace VisualBeltShenanigans.visual.prompt
{
	public partial class BalancingScenarioPrompt : Form, IGetScenario
	{
		public BalancingScenarioPrompt()
		{
			InitializeComponent();
		}

		public BalancingScenarioPrompt(BeltBalancingScenario toEdit) : this()
		{
			BeltsIn = toEdit.BeltsIn;
			BeltsOutNumeric.Value = toEdit.BeltsOut;
			MyBeltScenarioBaseControl.BeltContext = toEdit.Context;
		}

		public ImmutableList<decimal> BeltsIn
		{
			get
			{
				ImmutableList<decimal> belts = ImmutableList<decimal>.Empty;
				foreach (decimal d in BeltsInList.Items)
				{
					belts = belts.Add(d);
				}
				return belts;
			}
			set
			{
				BeltsInList.BeginUpdate();
				BeltsInList.Items.Clear();
				foreach (decimal d in value)
				{
					BeltsInList.Items.Add(d);
				}
				BeltsInList.EndUpdate();
			}
		}


		public BeltScenario GetScenario()
		{
			return new BeltBalancingScenario(BeltsIn, (int)BeltsOutNumeric.Value, MyBeltScenarioBaseControl.BeltContext);
		}

		private void MyCancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void MyOkButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void AddBeltInButton_Click(object sender, EventArgs e)
		{
			SpeedPrompt prompt = new SpeedPrompt();
			if (prompt.ShowDialog() == DialogResult.OK)
			{
				BeltsInList.Items.Add(prompt.GetSpeed());
			}
		}

		private void RemoveBeltInButton_Click(object sender, EventArgs e)
		{
			BeltsInList.Items.Remove(BeltsInList.SelectedItem);
		}
	}
}
