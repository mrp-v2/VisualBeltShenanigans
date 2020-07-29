using System;
using System.Windows.Forms;

using VisualBeltShenanigans.code.data.context;

namespace VisualBeltShenanigans.visual.prompt
{
	public partial class BeltSpeedPrompt : Form
	{
		public BeltSpeedPrompt()
		{
			InitializeComponent();
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

		public BeltSpeed GetBeltSpeed()
		{
			return new BeltSpeed((int)TierNumeric.Value, MySpeedControl.Speed);
		}
	}
}
