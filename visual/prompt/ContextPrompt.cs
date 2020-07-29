using System;
using System.Windows.Forms;

using VisualBeltShenanigans.code.data.context;

namespace VisualBeltShenanigans.visual.prompt
{
	public partial class ContextPrompt : Form
	{
		public ContextPrompt()
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

		public BeltContext GetBeltContext()
		{
			return MyContextControl.BeltContext;
		}
	}
}
