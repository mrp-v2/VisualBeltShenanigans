using System.Windows.Forms;

using VisualBeltShenanigans.code.data.context;

namespace VisualBeltShenanigans.visual.control
{
	public partial class BeltSpeedControl : UserControl
	{
		public BeltSpeedControl()
		{
			InitializeComponent();
		}

		public BeltSpeed BeltSpeed
		{
			get
			{
				return new BeltSpeed(MyTierControl.Tier, MySpeedControl.Speed);
			}
			set
			{
				MyTierControl.Tier = value.Tier;
				MySpeedControl.Speed = value.Speed;
			}
		}
	}
}
