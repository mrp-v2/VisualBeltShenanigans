using System;
using System.Windows.Forms;

namespace VisualBeltShenanigans.visual.prompt
{
	public partial class SpeedPrompt : Form
	{
		public SpeedPrompt()
		{
			InitializeComponent();
		}

		private void MyOkButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void MyCancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		public decimal GetSpeed()
		{
			return MySpeedControl.Speed;
		}
	}
}
