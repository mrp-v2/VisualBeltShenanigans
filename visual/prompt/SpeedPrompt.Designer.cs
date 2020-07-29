namespace VisualBeltShenanigans.visual.prompt
{
	partial class SpeedPrompt
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
			this.MySpeedControl = new VisualBeltShenanigans.visual.control.SpeedControl();
			this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MyOkButton = new System.Windows.Forms.Button();
			this.MyCancelButton = new System.Windows.Forms.Button();
			this.MainPanel.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MySpeedControl
			// 
			this.MySpeedControl.AutoSize = true;
			this.MySpeedControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MySpeedControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MySpeedControl.Location = new System.Drawing.Point(4, 4);
			this.MySpeedControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MySpeedControl.Name = "MySpeedControl";
			this.MySpeedControl.Size = new System.Drawing.Size(244, 35);
			this.MySpeedControl.Speed = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MySpeedControl.TabIndex = 0;
			// 
			// MainPanel
			// 
			this.MainPanel.AutoSize = true;
			this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainPanel.Controls.Add(this.MySpeedControl);
			this.MainPanel.Controls.Add(this.ButtonPanel);
			this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.MainPanel.Location = new System.Drawing.Point(12, 12);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(252, 83);
			this.MainPanel.TabIndex = 1;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.AutoSize = true;
			this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPanel.Controls.Add(this.MyOkButton);
			this.ButtonPanel.Controls.Add(this.MyCancelButton);
			this.ButtonPanel.Location = new System.Drawing.Point(3, 46);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(106, 34);
			this.ButtonPanel.TabIndex = 2;
			// 
			// MyOkButton
			// 
			this.MyOkButton.AutoSize = true;
			this.MyOkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyOkButton.Location = new System.Drawing.Point(3, 3);
			this.MyOkButton.Name = "MyOkButton";
			this.MyOkButton.Size = new System.Drawing.Size(36, 27);
			this.MyOkButton.TabIndex = 0;
			this.MyOkButton.Text = "Ok";
			this.MyOkButton.UseVisualStyleBackColor = true;
			this.MyOkButton.Click += new System.EventHandler(this.MyOkButton_Click);
			// 
			// MyCancelButton
			// 
			this.MyCancelButton.AutoSize = true;
			this.MyCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.MyCancelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyCancelButton.Location = new System.Drawing.Point(45, 3);
			this.MyCancelButton.Name = "MyCancelButton";
			this.MyCancelButton.Size = new System.Drawing.Size(58, 28);
			this.MyCancelButton.TabIndex = 1;
			this.MyCancelButton.Text = "Cancel";
			this.MyCancelButton.UseVisualStyleBackColor = true;
			this.MyCancelButton.Click += new System.EventHandler(this.MyCancelButton_Click);
			// 
			// SpeedPrompt
			// 
			this.AcceptButton = this.MyOkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.MyCancelButton;
			this.ClientSize = new System.Drawing.Size(424, 106);
			this.Controls.Add(this.MainPanel);
			this.Name = "SpeedPrompt";
			this.Text = "SpeedPrompt";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private control.SpeedControl MySpeedControl;
		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		private System.Windows.Forms.Button MyOkButton;
		private System.Windows.Forms.Button MyCancelButton;
	}
}