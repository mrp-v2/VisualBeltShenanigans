using System.Windows.Forms;

namespace VisualBeltShenanigans.visual.control
{
	public partial class TierControl : UserControl
	{
		public TierControl()
		{
			InitializeComponent();
		}

		public int Tier
		{
			get
			{
				return (int)TierNumeric.Value;
			}
			set
			{
				TierNumeric.Value = value;
			}
		}
	}
}
