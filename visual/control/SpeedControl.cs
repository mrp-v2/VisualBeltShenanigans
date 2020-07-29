using System.Windows.Forms;

namespace VisualBeltShenanigans.visual.control
{
	public partial class SpeedControl : UserControl
	{
		public SpeedControl()
		{
			InitializeComponent();
		}

		public decimal Speed
		{
			get
			{
				return SpeedNumeric.Value;
			}
			set
			{
				SpeedNumeric.Value = value;
			}
		}
	}
}
