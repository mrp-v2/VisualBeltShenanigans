namespace VisualBeltShenanigans.visual.prompt
{
	partial class ContextPrompt
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
			this.MyOkButton = new System.Windows.Forms.Button();
			this.MyCancelButton = new System.Windows.Forms.Button();
			this.MyContextControl = new VisualBeltShenanigans.visual.control.ContextControl();
			this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MainPanel.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MyOkButton
			// 
			this.MyOkButton.AutoSize = true;
			this.MyOkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyOkButton.Location = new System.Drawing.Point(3, 3);
			this.MyOkButton.Name = "MyOkButton";
			this.MyOkButton.Size = new System.Drawing.Size(36, 27);
			this.MyOkButton.TabIndex = 9;
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
			this.MyCancelButton.TabIndex = 10;
			this.MyCancelButton.Text = "Cancel";
			this.MyCancelButton.UseVisualStyleBackColor = true;
			this.MyCancelButton.Click += new System.EventHandler(this.MyCancelButton_Click);
			// 
			// MyContextControl
			// 
			this.MyContextControl.AutoSize = true;
			this.MyContextControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MyContextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyContextControl.Location = new System.Drawing.Point(4, 4);
			this.MyContextControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MyContextControl.Name = "MyContextControl";
			this.MyContextControl.Size = new System.Drawing.Size(716, 211);
			this.MyContextControl.TabIndex = 11;
			// 
			// MainPanel
			// 
			this.MainPanel.AutoSize = true;
			this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainPanel.Controls.Add(this.MyContextControl);
			this.MainPanel.Controls.Add(this.ButtonPanel);
			this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.MainPanel.Location = new System.Drawing.Point(13, 12);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(724, 258);
			this.MainPanel.TabIndex = 12;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.AutoSize = true;
			this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonPanel.Controls.Add(this.MyOkButton);
			this.ButtonPanel.Controls.Add(this.MyCancelButton);
			this.ButtonPanel.Location = new System.Drawing.Point(3, 222);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(109, 33);
			this.ButtonPanel.TabIndex = 13;
			// 
			// ContextPrompt
			// 
			this.AcceptButton = this.MyOkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.MyCancelButton;
			this.ClientSize = new System.Drawing.Size(749, 281);
			this.Controls.Add(this.MainPanel);
			this.Name = "ContextPrompt";
			this.Text = "ContextPrompt";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button MyOkButton;
		private System.Windows.Forms.Button MyCancelButton;
		private control.ContextControl MyContextControl;
		private System.Windows.Forms.FlowLayoutPanel MainPanel;
		private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
	}
}