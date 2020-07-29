namespace VisualBeltShenanigans.visual.control
{
	partial class TierControl
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
			this.TierPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.TierLabel = new System.Windows.Forms.Label();
			this.TierNumeric = new System.Windows.Forms.NumericUpDown();
			this.TierPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TierNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// TierPanel
			// 
			this.TierPanel.AutoSize = true;
			this.TierPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TierPanel.Controls.Add(this.TierLabel);
			this.TierPanel.Controls.Add(this.TierNumeric);
			this.TierPanel.Location = new System.Drawing.Point(0, 0);
			this.TierPanel.Margin = new System.Windows.Forms.Padding(4);
			this.TierPanel.Name = "TierPanel";
			this.TierPanel.Size = new System.Drawing.Size(341, 31);
			this.TierPanel.TabIndex = 6;
			// 
			// TierLabel
			// 
			this.TierLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TierLabel.AutoSize = true;
			this.TierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TierLabel.Location = new System.Drawing.Point(4, 7);
			this.TierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TierLabel.Name = "TierLabel";
			this.TierLabel.Size = new System.Drawing.Size(33, 17);
			this.TierLabel.TabIndex = 3;
			this.TierLabel.Text = "Tier";
			// 
			// TierNumeric
			// 
			this.TierNumeric.AutoSize = true;
			this.TierNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TierNumeric.Location = new System.Drawing.Point(45, 4);
			this.TierNumeric.Margin = new System.Windows.Forms.Padding(4);
			this.TierNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.TierNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.TierNumeric.Name = "TierNumeric";
			this.TierNumeric.Size = new System.Drawing.Size(292, 23);
			this.TierNumeric.TabIndex = 0;
			this.TierNumeric.ThousandsSeparator = true;
			this.TierNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// TierControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.TierPanel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TierControl";
			this.Size = new System.Drawing.Size(345, 35);
			this.TierPanel.ResumeLayout(false);
			this.TierPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TierNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel TierPanel;
		private System.Windows.Forms.Label TierLabel;
		private System.Windows.Forms.NumericUpDown TierNumeric;
	}
}
