namespace VisualBeltShenanigans.visual.control
{
	partial class BeltSpeedControl
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
			this.MyTierControl = new VisualBeltShenanigans.visual.control.TierControl();
			this.MySpeedControl = new VisualBeltShenanigans.visual.control.SpeedControl();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.AutoSize = true;
			this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainPanel.Controls.Add(this.MyTierControl);
			this.MainPanel.Controls.Add(this.MySpeedControl);
			this.MainPanel.Controls.Add(this.ButtonPanel);
			this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.MainPanel.Location = new System.Drawing.Point(0, 0);
			this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(406, 98);
			this.MainPanel.TabIndex = 3;
			// 
			// MyTierControl
			// 
			this.MyTierControl.AutoSize = true;
			this.MyTierControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyTierControl.Location = new System.Drawing.Point(5, 5);
			this.MyTierControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.MyTierControl.Name = "MyTierControl";
			this.MyTierControl.Size = new System.Drawing.Size(345, 35);
			this.MyTierControl.TabIndex = 10;
			this.MyTierControl.Tier = 1;
			// 
			// MySpeedControl
			// 
			this.MySpeedControl.AutoSize = true;
			this.MySpeedControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MySpeedControl.Location = new System.Drawing.Point(5, 50);
			this.MySpeedControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.MySpeedControl.Name = "MySpeedControl";
			this.MySpeedControl.Size = new System.Drawing.Size(396, 35);
			this.MySpeedControl.Speed = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MySpeedControl.TabIndex = 9;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.AutoSize = true;
			this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPanel.Location = new System.Drawing.Point(4, 94);
			this.ButtonPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(0, 0);
			this.ButtonPanel.TabIndex = 8;
			// 
			// BeltSpeedControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.MainPanel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "BeltSpeedControl";
			this.Size = new System.Drawing.Size(410, 102);
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private SpeedControl MySpeedControl;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		private TierControl MyTierControl;
	}
}
