namespace VisualBeltShenanigans.visual.prompt
{
	partial class SubtractingScenarioPrompt
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
			this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.BeltsOutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SubtractedLabel = new System.Windows.Forms.Label();
			this.SubtractedNumeric = new System.Windows.Forms.NumericUpDown();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MyOkButton = new System.Windows.Forms.Button();
			this.MyCancelButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.BeltInLabel = new System.Windows.Forms.Label();
			this.BeltInNumeric = new System.Windows.Forms.NumericUpDown();
			this.MyBeltScenarioBaseControl = new VisualBeltShenanigans.visual.control.BeltScenarioBaseControl();
			this.MainPanel.SuspendLayout();
			this.BeltsOutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SubtractedNumeric)).BeginInit();
			this.ButtonPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BeltInNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.AutoSize = true;
			this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainPanel.Controls.Add(this.MyBeltScenarioBaseControl);
			this.MainPanel.Controls.Add(this.flowLayoutPanel1);
			this.MainPanel.Controls.Add(this.BeltsOutPanel);
			this.MainPanel.Controls.Add(this.ButtonPanel);
			this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.MainPanel.Location = new System.Drawing.Point(12, 12);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(736, 354);
			this.MainPanel.TabIndex = 2;
			// 
			// BeltsOutPanel
			// 
			this.BeltsOutPanel.AutoSize = true;
			this.BeltsOutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BeltsOutPanel.Controls.Add(this.SubtractedLabel);
			this.BeltsOutPanel.Controls.Add(this.SubtractedNumeric);
			this.BeltsOutPanel.Location = new System.Drawing.Point(3, 283);
			this.BeltsOutPanel.Name = "BeltsOutPanel";
			this.BeltsOutPanel.Size = new System.Drawing.Size(271, 29);
			this.BeltsOutPanel.TabIndex = 1;
			// 
			// SubtractedLabel
			// 
			this.SubtractedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SubtractedLabel.AutoSize = true;
			this.SubtractedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubtractedLabel.Location = new System.Drawing.Point(3, 6);
			this.SubtractedLabel.Name = "SubtractedLabel";
			this.SubtractedLabel.Size = new System.Drawing.Size(127, 17);
			this.SubtractedLabel.TabIndex = 0;
			this.SubtractedLabel.Text = "Amount to subtract";
			// 
			// SubtractedNumeric
			// 
			this.SubtractedNumeric.AutoSize = true;
			this.SubtractedNumeric.DecimalPlaces = 3;
			this.SubtractedNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubtractedNumeric.Location = new System.Drawing.Point(136, 3);
			this.SubtractedNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.SubtractedNumeric.Name = "SubtractedNumeric";
			this.SubtractedNumeric.Size = new System.Drawing.Size(132, 23);
			this.SubtractedNumeric.TabIndex = 1;
			this.SubtractedNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.AutoSize = true;
			this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPanel.Controls.Add(this.MyOkButton);
			this.ButtonPanel.Controls.Add(this.MyCancelButton);
			this.ButtonPanel.Location = new System.Drawing.Point(3, 318);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(109, 33);
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
			this.MyCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyCancelButton.Location = new System.Drawing.Point(45, 3);
			this.MyCancelButton.Name = "MyCancelButton";
			this.MyCancelButton.Size = new System.Drawing.Size(61, 27);
			this.MyCancelButton.TabIndex = 1;
			this.MyCancelButton.Text = "Cancel";
			this.MyCancelButton.UseVisualStyleBackColor = true;
			this.MyCancelButton.Click += new System.EventHandler(this.MyCancelButton_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.BeltInLabel);
			this.flowLayoutPanel1.Controls.Add(this.BeltInNumeric);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 248);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(191, 29);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// BeltInLabel
			// 
			this.BeltInLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BeltInLabel.AutoSize = true;
			this.BeltInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BeltInLabel.Location = new System.Drawing.Point(3, 6);
			this.BeltInLabel.Name = "BeltInLabel";
			this.BeltInLabel.Size = new System.Drawing.Size(47, 17);
			this.BeltInLabel.TabIndex = 0;
			this.BeltInLabel.Text = "Belt In";
			// 
			// BeltInNumeric
			// 
			this.BeltInNumeric.AutoSize = true;
			this.BeltInNumeric.DecimalPlaces = 3;
			this.BeltInNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BeltInNumeric.Location = new System.Drawing.Point(56, 3);
			this.BeltInNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.BeltInNumeric.Name = "BeltInNumeric";
			this.BeltInNumeric.Size = new System.Drawing.Size(132, 23);
			this.BeltInNumeric.TabIndex = 1;
			// 
			// MyBeltScenarioBaseControl
			// 
			this.MyBeltScenarioBaseControl.AutoSize = true;
			this.MyBeltScenarioBaseControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyBeltScenarioBaseControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyBeltScenarioBaseControl.Location = new System.Drawing.Point(4, 4);
			this.MyBeltScenarioBaseControl.Margin = new System.Windows.Forms.Padding(4);
			this.MyBeltScenarioBaseControl.Name = "MyBeltScenarioBaseControl";
			this.MyBeltScenarioBaseControl.Size = new System.Drawing.Size(728, 237);
			this.MyBeltScenarioBaseControl.TabIndex = 0;
			// 
			// SubtractingScenarioPrompt
			// 
			this.AcceptButton = this.MyOkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.MyCancelButton;
			this.ClientSize = new System.Drawing.Size(764, 376);
			this.Controls.Add(this.MainPanel);
			this.Name = "SubtractingScenarioPrompt";
			this.Text = "SubtractingScenarioPrompt";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.BeltsOutPanel.ResumeLayout(false);
			this.BeltsOutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SubtractedNumeric)).EndInit();
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BeltInNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private control.BeltScenarioBaseControl MyBeltScenarioBaseControl;
		private System.Windows.Forms.FlowLayoutPanel BeltsOutPanel;
		private System.Windows.Forms.Label SubtractedLabel;
		private System.Windows.Forms.NumericUpDown SubtractedNumeric;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		private System.Windows.Forms.Button MyOkButton;
		private System.Windows.Forms.Button MyCancelButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label BeltInLabel;
		private System.Windows.Forms.NumericUpDown BeltInNumeric;
	}
}