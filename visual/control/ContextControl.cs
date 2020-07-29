using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Windows.Forms;

using VisualBeltShenanigans.code.data.context;
using VisualBeltShenanigans.visual.prompt;

namespace VisualBeltShenanigans.visual.control
{
	public partial class ContextControl : UserControl
	{
		private static readonly HashSet<BeltContext> ContextPresets = new HashSet<BeltContext>() { BeltContext.SatisfactoryMk1, BeltContext.SatisfactoryMk2, BeltContext.SatisfactoryMk3, BeltContext.SatisfactoryMk4, BeltContext.SatisfactoryMk5, BeltContext.FactorioMk1, BeltContext.FactorioMk2, BeltContext.FactorioMk3 };

		public ContextControl()
		{
			InitializeComponent();
			PresetSelection.BeginUpdate();
			foreach (BeltContext context in ContextPresets)
			{
				PresetSelection.Items.Add(context);
			}
			PresetSelection.EndUpdate();
		}

		private void AddBeltSpeedButton_Click(object sender, EventArgs e)
		{
			BeltSpeedPrompt prompt = new BeltSpeedPrompt();
			if (prompt.ShowDialog() == DialogResult.OK)
			{
				BeltSpeedList.Items.Add(prompt.GetBeltSpeed());
			}
		}

		private void RemoveBeltSpeedButton_Click(object sender, EventArgs e)
		{
			BeltSpeedList.Items.Remove(BeltSpeedList.SelectedItem);
		}

		public BeltContext BeltContext
		{
			get
			{
				ImmutableHashSet<BeltSpeed> speeds = ImmutableHashSet<BeltSpeed>.Empty;
				foreach (BeltSpeed beltSpeed in BeltSpeedList.Items)
				{
					speeds = speeds.Add(beltSpeed);
				}
				BeltContext context = new BeltContext(speeds, (int)SplitterNumeric.Value, (int)MergerNumeric.Value, ContextName.Text);
				ContextPresets.Add(context);
				return context;
			}
			set
			{
				ContextName.Text = value.DisplayName;
				SplitterNumeric.Value = value.SplitterOutputs;
				MergerNumeric.Value = value.MergerInputs;
				BeltSpeedList.BeginUpdate();
				BeltSpeedList.Items.Clear();
				foreach (BeltSpeed beltSpeed in value.BeltSpeeds)
				{
					BeltSpeedList.Items.Add(beltSpeed);
				}
				BeltSpeedList.EndUpdate();
			}
		}

		private void PresetSelection_SelectedIndexChanged(object sender, EventArgs e)
		{
			BeltContext = PresetSelection.SelectedItem as BeltContext;
		}
	}
}
