namespace VisualBeltShenanigans.visual.prompt
{
	partial class BeltSpeedPrompt
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TierNumeric = new System.Windows.Forms.NumericUpDown();
			this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.TierPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.TierLabel = new System.Windows.Forms.Label();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MyOkButton = new System.Windows.Forms.Button();
			this.MyCancelButton = new System.Windows.Forms.Button();
			this.MySpeedControl = new VisualBeltShenanigans.visual.control.SpeedControl();
			((System.ComponentModel.ISupportInitialize)(this.TierNumeric)).BeginInit();
			this.MainPanel.SuspendLayout();
			this.TierPanel.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TierNumeric
			// 
			this.TierNumeric.AutoSize = true;
			this.TierNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TierNumeric.Location = new System.Drawing.Point(42, 3);
			this.TierNumeric.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
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
			// MainPanel
			// 
			this.MainPanel.AutoSize = true;
			this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainPanel.Controls.Add(this.TierPanel);
			this.MainPanel.Controls.Add(this.MySpeedControl);
			this.MainPanel.Controls.Add(this.ButtonPanel);
			this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.MainPanel.Location = new System.Drawing.Point(12, 12);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(404, 117);
			this.MainPanel.TabIndex = 2;
			// 
			// TierPanel
			// 
			this.TierPanel.AutoSize = true;
			this.TierPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TierPanel.Controls.Add(this.TierLabel);
			this.TierPanel.Controls.Add(this.TierNumeric);
			this.TierPanel.Location = new System.Drawing.Point(3, 3);
			this.TierPanel.Name = "TierPanel";
			this.TierPanel.Size = new System.Drawing.Size(337, 29);
			this.TierPanel.TabIndex = 5;
			// 
			// TierLabel
			// 
			this.TierLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TierLabel.AutoSize = true;
			this.TierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TierLabel.Location = new System.Drawing.Point(3, 6);
			this.TierLabel.Name = "TierLabel";
			this.TierLabel.Size = new System.Drawing.Size(33, 17);
			this.TierLabel.TabIndex = 3;
			this.TierLabel.Text = "Tier";
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.AutoSize = true;
			this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPanel.Controls.Add(this.MyOkButton);
			this.ButtonPanel.Controls.Add(this.MyCancelButton);
			this.ButtonPanel.Location = new System.Drawing.Point(3, 81);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(109, 33);
			this.ButtonPanel.TabIndex = 8;
			// 
			// MyOkButton
			// 
			this.MyOkButton.AutoSize = true;
			this.MyOkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyOkButton.Location = new System.Drawing.Point(3, 3);
			this.MyOkButton.Name = "MyOkButton";
			this.MyOkButton.Size = new System.Drawing.Size(36, 27);
			this.MyOkButton.TabIndex = 3;
			this.MyOkButton.Text = "Ok";
			this.MyOkButton.UseVisualStyleBackColor = true;
			this.MyOkButton.Click += new System.EventHandler(this.MyOkButton_Click);
			// 
			// MyCancelButton
			// 
			this.MyCancelButton.AutoSize = true;
			this.MyCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.MyCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyCancelButton.Location = new System.Drawing.Point(45, 3);
			this.MyCancelButton.Name = "MyCancelButton";
			this.MyCancelButton.Size = new System.Drawing.Size(61, 27);
			this.MyCancelButton.TabIndex = 7;
			this.MyCancelButton.Text = "Cancel";
			this.MyCancelButton.UseVisualStyleBackColor = true;
			this.MyCancelButton.Click += new System.EventHandler(this.MyCancelButton_Click);
			// 
			// MySpeedControl
			// 
			this.MySpeedControl.AutoSize = true;
			this.MySpeedControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MySpeedControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MySpeedControl.Location = new System.Drawing.Point(4, 39);
			this.MySpeedControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MySpeedControl.Name = "MySpeedControl";
			this.MySpeedControl.Size = new System.Drawing.Size(396, 35);
			this.MySpeedControl.Speed = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MySpeedControl.TabIndex = 9;
			// 
			// BeltSpeedPrompt
			// 
			this.AcceptButton = this.MyOkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.MyCancelButton;
			this.ClientSize = new System.Drawing.Size(424, 136);
			this.Controls.Add(this.MainPanel);
			this.Name = "BeltSpeedPrompt";
			this.Text = "BeltSpeedPrompt";
			((System.ComponentModel.ISupportInitialize)(this.TierNumeric)).EndInit();
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.TierPanel.ResumeLayout(false);
			this.TierPanel.PerformLayout();
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown TierNumeric;
		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private System.Windows.Forms.Label TierLabel;
		private System.Windows.Forms.FlowLayoutPanel TierPanel;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		private System.Windows.Forms.Button MyOkButton;
		private System.Windows.Forms.Button MyCancelButton;
		private control.SpeedControl MySpeedControl;
	}
}