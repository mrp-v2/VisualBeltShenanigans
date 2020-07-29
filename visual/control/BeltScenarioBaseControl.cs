using System.Windows.Forms;

using VisualBeltShenanigans.code.data.context;

namespace VisualBeltShenanigans.visual.control
{
	public partial class BeltScenarioBaseControl : UserControl
	{
		public BeltScenarioBaseControl()
		{
			InitializeComponent();
		}

		public BeltContext BeltContext
		{
			get
			{
				return MyContextControl.BeltContext;
			}
			set
			{
				MyContextControl.BeltContext = value;
			}
		}
	}
}
