namespace VisualBeltShenanigans.visual.control
{
	partial class SpeedControl
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
			this.SpeedPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SpeedLabel = new System.Windows.Forms.Label();
			this.SpeedNumeric = new System.Windows.Forms.NumericUpDown();
			this.SpeedPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpeedNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// SpeedPanel
			// 
			this.SpeedPanel.AutoSize = true;
			this.SpeedPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SpeedPanel.Controls.Add(this.SpeedLabel);
			this.SpeedPanel.Controls.Add(this.SpeedNumeric);
			this.SpeedPanel.Location = new System.Drawing.Point(0, 0);
			this.SpeedPanel.Name = "SpeedPanel";
			this.SpeedPanel.Size = new System.Drawing.Size(388, 29);
			this.SpeedPanel.TabIndex = 7;
			// 
			// SpeedLabel
			// 
			this.SpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SpeedLabel.AutoSize = true;
			this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SpeedLabel.Location = new System.Drawing.Point(3, 6);
			this.SpeedLabel.Name = "SpeedLabel";
			this.SpeedLabel.Size = new System.Drawing.Size(92, 17);
			this.SpeedLabel.TabIndex = 4;
			this.SpeedLabel.Text = "Speed (i/min)";
			// 
			// SpeedNumeric
			// 
			this.SpeedNumeric.AutoSize = true;
			this.SpeedNumeric.DecimalPlaces = 3;
			this.SpeedNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SpeedNumeric.Location = new System.Drawing.Point(101, 3);
			this.SpeedNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.SpeedNumeric.Name = "SpeedNumeric";
			this.SpeedNumeric.Size = new System.Drawing.Size(284, 23);
			this.SpeedNumeric.TabIndex = 1;
			this.SpeedNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// SpeedControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.SpeedPanel);
			this.Name = "SpeedControl";
			this.Size = new System.Drawing.Size(391, 32);
			this.SpeedPanel.ResumeLayout(false);
			this.SpeedPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SpeedNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel SpeedPanel;
		private System.Windows.Forms.Label SpeedLabel;
		private System.Windows.Forms.NumericUpDown SpeedNumeric;
	}
}
