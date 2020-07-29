using GraphX.Common.Enums;

namespace  VisualBeltShenanigans.visual.form
{
	partial class MainForm
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
			this.CreateScenarioButton = new System.Windows.Forms.Button();
			this.ScenarioPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.EditScenarioButton = new System.Windows.Forms.Button();
			this.GenerateGraphButton = new System.Windows.Forms.Button();
			this.LayoutModeSelection = new System.Windows.Forms.ListBox();
			this.MyScenarioDiaplayControl = new VisualBeltShenanigans.visual.control.ScenarioDisplayControl();
			this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.LayoutModeLabel = new System.Windows.Forms.Label();
			this.ScenarioPanel.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.MainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// CreateScenarioButton
			// 
			this.CreateScenarioButton.AutoSize = true;
			this.CreateScenarioButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CreateScenarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateScenarioButton.Location = new System.Drawing.Point(3, 3);
			this.CreateScenarioButton.Name = "CreateScenarioButton";
			this.CreateScenarioButton.Size = new System.Drawing.Size(120, 27);
			this.CreateScenarioButton.TabIndex = 0;
			this.CreateScenarioButton.Text = "Create Scenario";
			this.CreateScenarioButton.UseVisualStyleBackColor = true;
			this.CreateScenarioButton.Click += new System.EventHandler(this.CreateScenarioButton_Click);
			// 
			// ScenarioPanel
			// 
			this.ScenarioPanel.AutoSize = true;
			this.ScenarioPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ScenarioPanel.Controls.Add(this.ButtonPanel);
			this.ScenarioPanel.Controls.Add(this.MyScenarioDiaplayControl);
			this.ScenarioPanel.Location = new System.Drawing.Point(3, 3);
			this.ScenarioPanel.Name = "ScenarioPanel";
			this.ScenarioPanel.Size = new System.Drawing.Size(491, 276);
			this.ScenarioPanel.TabIndex = 3;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.AutoSize = true;
			this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPanel.Controls.Add(this.CreateScenarioButton);
			this.ButtonPanel.Controls.Add(this.EditScenarioButton);
			this.ButtonPanel.Controls.Add(this.GenerateGraphButton);
			this.ButtonPanel.Controls.Add(this.LayoutModeLabel);
			this.ButtonPanel.Controls.Add(this.LayoutModeSelection);
			this.ButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.ButtonPanel.Location = new System.Drawing.Point(3, 3);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(128, 270);
			this.ButtonPanel.TabIndex = 2;
			// 
			// EditScenarioButton
			// 
			this.EditScenarioButton.AutoSize = true;
			this.EditScenarioButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.EditScenarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditScenarioButton.Location = new System.Drawing.Point(3, 36);
			this.EditScenarioButton.Name = "EditScenarioButton";
			this.EditScenarioButton.Size = new System.Drawing.Size(102, 27);
			this.EditScenarioButton.TabIndex = 1;
			this.EditScenarioButton.Text = "Edit Scenario";
			this.EditScenarioButton.UseVisualStyleBackColor = true;
			this.EditScenarioButton.Click += new System.EventHandler(this.EditScenarioButton_Click);
			// 
			// GenerateGraphButton
			// 
			this.GenerateGraphButton.AutoSize = true;
			this.GenerateGraphButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GenerateGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GenerateGraphButton.Location = new System.Drawing.Point(3, 69);
			this.GenerateGraphButton.Name = "GenerateGraphButton";
			this.GenerateGraphButton.Size = new System.Drawing.Size(122, 27);
			this.GenerateGraphButton.TabIndex = 2;
			this.GenerateGraphButton.Text = "Generate Graph";
			this.GenerateGraphButton.UseVisualStyleBackColor = true;
			this.GenerateGraphButton.Click += new System.EventHandler(this.GenerateGraphButton_Click);
			// 
			// LayoutModeSelection
			// 
			this.LayoutModeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LayoutModeSelection.FormattingEnabled = true;
			this.LayoutModeSelection.ItemHeight = 16;
			this.LayoutModeSelection.Items.AddRange(new object[] {
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.BoundedFR,
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.CompoundFDP,
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.EfficientSugiyama,
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.FR,
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.ISOM,
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.KK,
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.LinLog,
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.Sugiyama,
            GraphX.Common.Enums.LayoutAlgorithmTypeEnum.Tree});
			this.LayoutModeSelection.Location = new System.Drawing.Point(3, 119);
			this.LayoutModeSelection.Name = "LayoutModeSelection";
			this.LayoutModeSelection.Size = new System.Drawing.Size(122, 148);
			this.LayoutModeSelection.TabIndex = 3;
			// 
			// MyScenarioDiaplayControl
			// 
			this.MyScenarioDiaplayControl.AutoSize = true;
			this.MyScenarioDiaplayControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyScenarioDiaplayControl.Location = new System.Drawing.Point(137, 3);
			this.MyScenarioDiaplayControl.Name = "MyScenarioDiaplayControl";
			this.MyScenarioDiaplayControl.Size = new System.Drawing.Size(351, 135);
			this.MyScenarioDiaplayControl.TabIndex = 1;
			// 
			// MainPanel
			// 
			this.MainPanel.AutoSize = true;
			this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainPanel.Controls.Add(this.ScenarioPanel);
			this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.MainPanel.Location = new System.Drawing.Point(12, 12);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(497, 282);
			this.MainPanel.TabIndex = 4;
			// 
			// LayoutModeLabel
			// 
			this.LayoutModeLabel.AutoSize = true;
			this.LayoutModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LayoutModeLabel.Location = new System.Drawing.Point(3, 99);
			this.LayoutModeLabel.Name = "LayoutModeLabel";
			this.LayoutModeLabel.Size = new System.Drawing.Size(118, 17);
			this.LayoutModeLabel.TabIndex = 4;
			this.LayoutModeLabel.Text = "Layout Algorithm:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1225, 727);
			this.Controls.Add(this.MainPanel);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ScenarioPanel.ResumeLayout(false);
			this.ScenarioPanel.PerformLayout();
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CreateScenarioButton;
		private control.ScenarioDisplayControl MyScenarioDiaplayControl;
		private System.Windows.Forms.FlowLayoutPanel ScenarioPanel;
		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		private System.Windows.Forms.Button EditScenarioButton;
		private System.Windows.Forms.Button GenerateGraphButton;
		private System.Windows.Forms.ListBox LayoutModeSelection;
		private System.Windows.Forms.Label LayoutModeLabel;
	}
}

