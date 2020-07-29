namespace VisualBeltShenanigans.visual.prompt
{
	partial class BalancingScenarioPrompt
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
			this.BeltsInPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.BeltsInLabel = new System.Windows.Forms.Label();
			this.BeltsInButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.AddBeltInButton = new System.Windows.Forms.Button();
			this.RemoveBeltInButton = new System.Windows.Forms.Button();
			this.BeltsInList = new System.Windows.Forms.ListBox();
			this.BeltsOutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.BeltsOutLabel = new System.Windows.Forms.Label();
			this.BeltsOutNumeric = new System.Windows.Forms.NumericUpDown();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MyOkButton = new System.Windows.Forms.Button();
			this.MyCancelButton = new System.Windows.Forms.Button();
			this.MyBeltScenarioBaseControl = new VisualBeltShenanigans.visual.control.BeltScenarioBaseControl();
			this.MainPanel.SuspendLayout();
			this.BeltsInPanel.SuspendLayout();
			this.BeltsInButtonPanel.SuspendLayout();
			this.BeltsOutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BeltsOutNumeric)).BeginInit();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.AutoSize = true;
			this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainPanel.Controls.Add(this.MyBeltScenarioBaseControl);
			this.MainPanel.Controls.Add(this.BeltsInPanel);
			this.MainPanel.Controls.Add(this.BeltsOutPanel);
			this.MainPanel.Controls.Add(this.ButtonPanel);
			this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.MainPanel.Location = new System.Drawing.Point(12, 12);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(736, 527);
			this.MainPanel.TabIndex = 1;
			// 
			// BeltsInPanel
			// 
			this.BeltsInPanel.AutoSize = true;
			this.BeltsInPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BeltsInPanel.Controls.Add(this.BeltsInLabel);
			this.BeltsInPanel.Controls.Add(this.BeltsInButtonPanel);
			this.BeltsInPanel.Controls.Add(this.BeltsInList);
			this.BeltsInPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.BeltsInPanel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BeltsInPanel.Location = new System.Drawing.Point(4, 249);
			this.BeltsInPanel.Margin = new System.Windows.Forms.Padding(4);
			this.BeltsInPanel.Name = "BeltsInPanel";
			this.BeltsInPanel.Size = new System.Drawing.Size(169, 200);
			this.BeltsInPanel.TabIndex = 1;
			// 
			// BeltsInLabel
			// 
			this.BeltsInLabel.AutoSize = true;
			this.BeltsInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BeltsInLabel.Location = new System.Drawing.Point(4, 0);
			this.BeltsInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.BeltsInLabel.Name = "BeltsInLabel";
			this.BeltsInLabel.Size = new System.Drawing.Size(54, 17);
			this.BeltsInLabel.TabIndex = 0;
			this.BeltsInLabel.Text = "Belts In";
			// 
			// BeltsInButtonPanel
			// 
			this.BeltsInButtonPanel.AutoSize = true;
			this.BeltsInButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BeltsInButtonPanel.Controls.Add(this.AddBeltInButton);
			this.BeltsInButtonPanel.Controls.Add(this.RemoveBeltInButton);
			this.BeltsInButtonPanel.Location = new System.Drawing.Point(4, 21);
			this.BeltsInButtonPanel.Margin = new System.Windows.Forms.Padding(4);
			this.BeltsInButtonPanel.Name = "BeltsInButtonPanel";
			this.BeltsInButtonPanel.Size = new System.Drawing.Size(129, 35);
			this.BeltsInButtonPanel.TabIndex = 1;
			// 
			// AddBeltInButton
			// 
			this.AddBeltInButton.AutoSize = true;
			this.AddBeltInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AddBeltInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddBeltInButton.Location = new System.Drawing.Point(4, 4);
			this.AddBeltInButton.Margin = new System.Windows.Forms.Padding(4);
			this.AddBeltInButton.Name = "AddBeltInButton";
			this.AddBeltInButton.Size = new System.Drawing.Size(43, 27);
			this.AddBeltInButton.TabIndex = 0;
			this.AddBeltInButton.Text = "Add";
			this.AddBeltInButton.UseVisualStyleBackColor = true;
			this.AddBeltInButton.Click += new System.EventHandler(this.AddBeltInButton_Click);
			// 
			// RemoveBeltInButton
			// 
			this.RemoveBeltInButton.AutoSize = true;
			this.RemoveBeltInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.RemoveBeltInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RemoveBeltInButton.Location = new System.Drawing.Point(55, 4);
			this.RemoveBeltInButton.Margin = new System.Windows.Forms.Padding(4);
			this.RemoveBeltInButton.Name = "RemoveBeltInButton";
			this.RemoveBeltInButton.Size = new System.Drawing.Size(70, 27);
			this.RemoveBeltInButton.TabIndex = 1;
			this.RemoveBeltInButton.Text = "Remove";
			this.RemoveBeltInButton.UseVisualStyleBackColor = true;
			this.RemoveBeltInButton.Click += new System.EventHandler(this.RemoveBeltInButton_Click);
			// 
			// BeltsInList
			// 
			this.BeltsInList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BeltsInList.FormattingEnabled = true;
			this.BeltsInList.ItemHeight = 16;
			this.BeltsInList.Location = new System.Drawing.Point(4, 64);
			this.BeltsInList.Margin = new System.Windows.Forms.Padding(4);
			this.BeltsInList.Name = "BeltsInList";
			this.BeltsInList.Size = new System.Drawing.Size(161, 132);
			this.BeltsInList.TabIndex = 2;
			// 
			// BeltsOutPanel
			// 
			this.BeltsOutPanel.AutoSize = true;
			this.BeltsOutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BeltsOutPanel.Controls.Add(this.BeltsOutLabel);
			this.BeltsOutPanel.Controls.Add(this.BeltsOutNumeric);
			this.BeltsOutPanel.Location = new System.Drawing.Point(3, 456);
			this.BeltsOutPanel.Name = "BeltsOutPanel";
			this.BeltsOutPanel.Size = new System.Drawing.Size(182, 29);
			this.BeltsOutPanel.TabIndex = 1;
			// 
			// BeltsOutLabel
			// 
			this.BeltsOutLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BeltsOutLabel.AutoSize = true;
			this.BeltsOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BeltsOutLabel.Location = new System.Drawing.Point(3, 6);
			this.BeltsOutLabel.Name = "BeltsOutLabel";
			this.BeltsOutLabel.Size = new System.Drawing.Size(66, 17);
			this.BeltsOutLabel.TabIndex = 0;
			this.BeltsOutLabel.Text = "Belts Out";
			// 
			// BeltsOutNumeric
			// 
			this.BeltsOutNumeric.AutoSize = true;
			this.BeltsOutNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BeltsOutNumeric.Location = new System.Drawing.Point(75, 3);
			this.BeltsOutNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.BeltsOutNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.BeltsOutNumeric.Name = "BeltsOutNumeric";
			this.BeltsOutNumeric.Size = new System.Drawing.Size(104, 23);
			this.BeltsOutNumeric.TabIndex = 1;
			this.BeltsOutNumeric.Value = new decimal(new int[] {
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
			this.ButtonPanel.Location = new System.Drawing.Point(3, 491);
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
			// BalancingScenarioPrompt
			// 
			this.AcceptButton = this.MyOkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.MyCancelButton;
			this.ClientSize = new System.Drawing.Size(764, 551);
			this.Controls.Add(this.MainPanel);
			this.Name = "BalancingScenarioPrompt";
			this.Text = "BalancingScenarioPrompt";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.BeltsInPanel.ResumeLayout(false);
			this.BeltsInPanel.PerformLayout();
			this.BeltsInButtonPanel.ResumeLayout(false);
			this.BeltsInButtonPanel.PerformLayout();
			this.BeltsOutPanel.ResumeLayout(false);
			this.BeltsOutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BeltsOutNumeric)).EndInit();
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private control.BeltScenarioBaseControl MyBeltScenarioBaseControl;
		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private System.Windows.Forms.FlowLayoutPanel BeltsOutPanel;
		private System.Windows.Forms.Label BeltsOutLabel;
		private System.Windows.Forms.NumericUpDown BeltsOutNumeric;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		private System.Windows.Forms.Button MyOkButton;
		private System.Windows.Forms.Button MyCancelButton;
		private System.Windows.Forms.FlowLayoutPanel BeltsInPanel;
		private System.Windows.Forms.Label BeltsInLabel;
		private System.Windows.Forms.FlowLayoutPanel BeltsInButtonPanel;
		private System.Windows.Forms.Button AddBeltInButton;
		private System.Windows.Forms.Button RemoveBeltInButton;
		private System.Windows.Forms.ListBox BeltsInList;
	}
}