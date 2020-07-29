namespace VisualBeltShenanigans.visual.control
{
	partial class ContextControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.PresetSelection = new System.Windows.Forms.ListBox();
			this.NodePanel = new System.Windows.Forms.FlowLayoutPanel();
			this.ContextName = new System.Windows.Forms.TextBox();
			this.SplitterPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SplitterLabel = new System.Windows.Forms.Label();
			this.SplitterNumeric = new System.Windows.Forms.NumericUpDown();
			this.MergerPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MergerLabel = new System.Windows.Forms.Label();
			this.MergerNumeric = new System.Windows.Forms.NumericUpDown();
			this.BeltSpeedsPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.BeltSpeedsControlPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.AddBeltSpeedButton = new System.Windows.Forms.Button();
			this.RemoveBeltSpeedButton = new System.Windows.Forms.Button();
			this.BeltSpeedList = new System.Windows.Forms.ListBox();
			this.PresetLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.PresetsLabel = new System.Windows.Forms.Label();
			this.MainPanel.SuspendLayout();
			this.NodePanel.SuspendLayout();
			this.SplitterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitterNumeric)).BeginInit();
			this.MergerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MergerNumeric)).BeginInit();
			this.BeltSpeedsPanel.SuspendLayout();
			this.BeltSpeedsControlPanel.SuspendLayout();
			this.PresetLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.AutoSize = true;
			this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainPanel.Controls.Add(this.PresetLayout);
			this.MainPanel.Controls.Add(this.NodePanel);
			this.MainPanel.Controls.Add(this.BeltSpeedsPanel);
			this.MainPanel.Location = new System.Drawing.Point(0, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(540, 183);
			this.MainPanel.TabIndex = 11;
			// 
			// PresetSelection
			// 
			this.PresetSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PresetSelection.FormattingEnabled = true;
			this.PresetSelection.ItemHeight = 16;
			this.PresetSelection.Location = new System.Drawing.Point(3, 20);
			this.PresetSelection.Name = "PresetSelection";
			this.PresetSelection.Size = new System.Drawing.Size(176, 148);
			this.PresetSelection.TabIndex = 0;
			this.PresetSelection.SelectedIndexChanged += new System.EventHandler(this.PresetSelection_SelectedIndexChanged);
			// 
			// NodePanel
			// 
			this.NodePanel.AutoSize = true;
			this.NodePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.NodePanel.Controls.Add(this.ContextName);
			this.NodePanel.Controls.Add(this.SplitterPanel);
			this.NodePanel.Controls.Add(this.MergerPanel);
			this.NodePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.NodePanel.Location = new System.Drawing.Point(191, 3);
			this.NodePanel.Name = "NodePanel";
			this.NodePanel.Size = new System.Drawing.Size(172, 99);
			this.NodePanel.TabIndex = 7;
			// 
			// ContextName
			// 
			this.ContextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ContextName.Location = new System.Drawing.Point(3, 3);
			this.ContextName.MaxLength = 50;
			this.ContextName.Name = "ContextName";
			this.ContextName.Size = new System.Drawing.Size(163, 23);
			this.ContextName.TabIndex = 9;
			this.ContextName.Text = "Context Name";
			// 
			// SplitterPanel
			// 
			this.SplitterPanel.AutoSize = true;
			this.SplitterPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SplitterPanel.Controls.Add(this.SplitterLabel);
			this.SplitterPanel.Controls.Add(this.SplitterNumeric);
			this.SplitterPanel.Location = new System.Drawing.Point(3, 32);
			this.SplitterPanel.Name = "SplitterPanel";
			this.SplitterPanel.Size = new System.Drawing.Size(166, 29);
			this.SplitterPanel.TabIndex = 5;
			// 
			// SplitterLabel
			// 
			this.SplitterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SplitterLabel.AutoSize = true;
			this.SplitterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SplitterLabel.Location = new System.Drawing.Point(3, 6);
			this.SplitterLabel.Name = "SplitterLabel";
			this.SplitterLabel.Size = new System.Drawing.Size(106, 17);
			this.SplitterLabel.TabIndex = 3;
			this.SplitterLabel.Text = "Splitter Outputs";
			// 
			// SplitterNumeric
			// 
			this.SplitterNumeric.AutoSize = true;
			this.SplitterNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SplitterNumeric.Location = new System.Drawing.Point(115, 3);
			this.SplitterNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.SplitterNumeric.Name = "SplitterNumeric";
			this.SplitterNumeric.Size = new System.Drawing.Size(48, 23);
			this.SplitterNumeric.TabIndex = 1;
			this.SplitterNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// MergerPanel
			// 
			this.MergerPanel.AutoSize = true;
			this.MergerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MergerPanel.Controls.Add(this.MergerLabel);
			this.MergerPanel.Controls.Add(this.MergerNumeric);
			this.MergerPanel.Location = new System.Drawing.Point(3, 67);
			this.MergerPanel.Name = "MergerPanel";
			this.MergerPanel.Size = new System.Drawing.Size(155, 29);
			this.MergerPanel.TabIndex = 6;
			// 
			// MergerLabel
			// 
			this.MergerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.MergerLabel.AutoSize = true;
			this.MergerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MergerLabel.Location = new System.Drawing.Point(3, 6);
			this.MergerLabel.Name = "MergerLabel";
			this.MergerLabel.Size = new System.Drawing.Size(95, 17);
			this.MergerLabel.TabIndex = 4;
			this.MergerLabel.Text = "Merger Inputs";
			// 
			// MergerNumeric
			// 
			this.MergerNumeric.AutoSize = true;
			this.MergerNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MergerNumeric.Location = new System.Drawing.Point(104, 3);
			this.MergerNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.MergerNumeric.Name = "MergerNumeric";
			this.MergerNumeric.Size = new System.Drawing.Size(48, 23);
			this.MergerNumeric.TabIndex = 2;
			this.MergerNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// BeltSpeedsPanel
			// 
			this.BeltSpeedsPanel.AutoSize = true;
			this.BeltSpeedsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BeltSpeedsPanel.Controls.Add(this.BeltSpeedsControlPanel);
			this.BeltSpeedsPanel.Controls.Add(this.BeltSpeedList);
			this.BeltSpeedsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.BeltSpeedsPanel.Location = new System.Drawing.Point(369, 3);
			this.BeltSpeedsPanel.Name = "BeltSpeedsPanel";
			this.BeltSpeedsPanel.Size = new System.Drawing.Size(168, 177);
			this.BeltSpeedsPanel.TabIndex = 8;
			// 
			// BeltSpeedsControlPanel
			// 
			this.BeltSpeedsControlPanel.AutoSize = true;
			this.BeltSpeedsControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BeltSpeedsControlPanel.Controls.Add(this.AddBeltSpeedButton);
			this.BeltSpeedsControlPanel.Controls.Add(this.RemoveBeltSpeedButton);
			this.BeltSpeedsControlPanel.Location = new System.Drawing.Point(3, 3);
			this.BeltSpeedsControlPanel.Name = "BeltSpeedsControlPanel";
			this.BeltSpeedsControlPanel.Size = new System.Drawing.Size(125, 33);
			this.BeltSpeedsControlPanel.TabIndex = 0;
			// 
			// AddBeltSpeedButton
			// 
			this.AddBeltSpeedButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.AddBeltSpeedButton.AutoSize = true;
			this.AddBeltSpeedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddBeltSpeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddBeltSpeedButton.Location = new System.Drawing.Point(3, 3);
			this.AddBeltSpeedButton.Name = "AddBeltSpeedButton";
			this.AddBeltSpeedButton.Size = new System.Drawing.Size(43, 27);
			this.AddBeltSpeedButton.TabIndex = 0;
			this.AddBeltSpeedButton.Text = "Add";
			this.AddBeltSpeedButton.UseVisualStyleBackColor = true;
			this.AddBeltSpeedButton.Click += new System.EventHandler(this.AddBeltSpeedButton_Click);
			// 
			// RemoveBeltSpeedButton
			// 
			this.RemoveBeltSpeedButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.RemoveBeltSpeedButton.AutoSize = true;
			this.RemoveBeltSpeedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.RemoveBeltSpeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RemoveBeltSpeedButton.Location = new System.Drawing.Point(52, 3);
			this.RemoveBeltSpeedButton.Name = "RemoveBeltSpeedButton";
			this.RemoveBeltSpeedButton.Size = new System.Drawing.Size(70, 27);
			this.RemoveBeltSpeedButton.TabIndex = 1;
			this.RemoveBeltSpeedButton.Text = "Remove";
			this.RemoveBeltSpeedButton.UseVisualStyleBackColor = true;
			this.RemoveBeltSpeedButton.Click += new System.EventHandler(this.RemoveBeltSpeedButton_Click);
			// 
			// BeltSpeedList
			// 
			this.BeltSpeedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BeltSpeedList.FormattingEnabled = true;
			this.BeltSpeedList.ItemHeight = 16;
			this.BeltSpeedList.Location = new System.Drawing.Point(3, 42);
			this.BeltSpeedList.Name = "BeltSpeedList";
			this.BeltSpeedList.Size = new System.Drawing.Size(162, 132);
			this.BeltSpeedList.TabIndex = 1;
			// 
			// PresetLayout
			// 
			this.PresetLayout.AutoSize = true;
			this.PresetLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.PresetLayout.Controls.Add(this.PresetsLabel);
			this.PresetLayout.Controls.Add(this.PresetSelection);
			this.PresetLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.PresetLayout.Location = new System.Drawing.Point(3, 3);
			this.PresetLayout.Name = "PresetLayout";
			this.PresetLayout.Size = new System.Drawing.Size(182, 171);
			this.PresetLayout.TabIndex = 9;
			// 
			// PresetsLabel
			// 
			this.PresetsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.PresetsLabel.AutoSize = true;
			this.PresetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PresetsLabel.Location = new System.Drawing.Point(3, 0);
			this.PresetsLabel.Name = "PresetsLabel";
			this.PresetsLabel.Size = new System.Drawing.Size(107, 17);
			this.PresetsLabel.TabIndex = 1;
			this.PresetsLabel.Text = "Context Presets";
			// 
			// ContextControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.MainPanel);
			this.Name = "ContextControl";
			this.Size = new System.Drawing.Size(543, 186);
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.NodePanel.ResumeLayout(false);
			this.NodePanel.PerformLayout();
			this.SplitterPanel.ResumeLayout(false);
			this.SplitterPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitterNumeric)).EndInit();
			this.MergerPanel.ResumeLayout(false);
			this.MergerPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MergerNumeric)).EndInit();
			this.BeltSpeedsPanel.ResumeLayout(false);
			this.BeltSpeedsPanel.PerformLayout();
			this.BeltSpeedsControlPanel.ResumeLayout(false);
			this.BeltSpeedsControlPanel.PerformLayout();
			this.PresetLayout.ResumeLayout(false);
			this.PresetLayout.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private System.Windows.Forms.ListBox PresetSelection;
		private System.Windows.Forms.FlowLayoutPanel NodePanel;
		private System.Windows.Forms.TextBox ContextName;
		private System.Windows.Forms.FlowLayoutPanel SplitterPanel;
		private System.Windows.Forms.Label SplitterLabel;
		private System.Windows.Forms.NumericUpDown SplitterNumeric;
		private System.Windows.Forms.FlowLayoutPanel MergerPanel;
		private System.Windows.Forms.Label MergerLabel;
		private System.Windows.Forms.NumericUpDown MergerNumeric;
		private System.Windows.Forms.FlowLayoutPanel BeltSpeedsPanel;
		private System.Windows.Forms.FlowLayoutPanel BeltSpeedsControlPanel;
		private System.Windows.Forms.Button AddBeltSpeedButton;
		private System.Windows.Forms.Button RemoveBeltSpeedButton;
		private System.Windows.Forms.ListBox BeltSpeedList;
		private System.Windows.Forms.FlowLayoutPanel PresetLayout;
		private System.Windows.Forms.Label PresetsLabel;
	}
}
