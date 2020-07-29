namespace  VisualBeltShenanigans.visual.prompt
{
	partial class ScenarioPrompt
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
			this.BalancingScenarioButton = new System.Windows.Forms.Button();
			this.SubtractingScenarioButton = new System.Windows.Forms.Button();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MyCancelButton = new System.Windows.Forms.Button();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BalancingScenarioButton
			// 
			this.BalancingScenarioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BalancingScenarioButton.AutoSize = true;
			this.BalancingScenarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BalancingScenarioButton.Location = new System.Drawing.Point(3, 3);
			this.BalancingScenarioButton.Name = "BalancingScenarioButton";
			this.BalancingScenarioButton.Size = new System.Drawing.Size(75, 27);
			this.BalancingScenarioButton.TabIndex = 0;
			this.BalancingScenarioButton.Text = "Balacing";
			this.BalancingScenarioButton.UseVisualStyleBackColor = true;
			this.BalancingScenarioButton.Click += new System.EventHandler(this.BalancingScenarioButton_Click);
			// 
			// SubtractingScenarioButton
			// 
			this.SubtractingScenarioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SubtractingScenarioButton.AutoSize = true;
			this.SubtractingScenarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubtractingScenarioButton.Location = new System.Drawing.Point(3, 36);
			this.SubtractingScenarioButton.Name = "SubtractingScenarioButton";
			this.SubtractingScenarioButton.Size = new System.Drawing.Size(90, 27);
			this.SubtractingScenarioButton.TabIndex = 1;
			this.SubtractingScenarioButton.Text = "Subtracting";
			this.SubtractingScenarioButton.UseVisualStyleBackColor = true;
			this.SubtractingScenarioButton.Click += new System.EventHandler(this.SubtractingScenarioButton_Click);
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.AutoSize = true;
			this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPanel.Controls.Add(this.BalancingScenarioButton);
			this.ButtonPanel.Controls.Add(this.SubtractingScenarioButton);
			this.ButtonPanel.Controls.Add(this.MyCancelButton);
			this.ButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.ButtonPanel.Location = new System.Drawing.Point(12, 12);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(96, 99);
			this.ButtonPanel.TabIndex = 2;
			// 
			// MyCancelButton
			// 
			this.MyCancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.MyCancelButton.AutoSize = true;
			this.MyCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.MyCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyCancelButton.Location = new System.Drawing.Point(3, 69);
			this.MyCancelButton.Name = "MyCancelButton";
			this.MyCancelButton.Size = new System.Drawing.Size(61, 27);
			this.MyCancelButton.TabIndex = 2;
			this.MyCancelButton.Text = "Cancel";
			this.MyCancelButton.UseVisualStyleBackColor = true;
			this.MyCancelButton.Click += new System.EventHandler(this.MyCancelButton_Click);
			// 
			// ScenarioPrompt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.MyCancelButton;
			this.ClientSize = new System.Drawing.Size(124, 131);
			this.Controls.Add(this.ButtonPanel);
			this.Name = "ScenarioPrompt";
			this.Text = "ScenarioPrompt";
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BalancingScenarioButton;
		private System.Windows.Forms.Button SubtractingScenarioButton;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		private System.Windows.Forms.Button MyCancelButton;
	}
}