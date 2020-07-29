namespace VisualBeltShenanigans.visual.form
{
	partial class GraphForm
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
			this.MyElement = new System.Windows.Forms.Integration.ElementHost();
			this.SuspendLayout();
			// 
			// MyElement
			// 
			this.MyElement.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MyElement.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MyElement.Location = new System.Drawing.Point(0, 0);
			this.MyElement.Name = "MyElement";
			this.MyElement.Size = new System.Drawing.Size(1265, 723);
			this.MyElement.TabIndex = 2;
			this.MyElement.Text = "elementHost1";
			this.MyElement.Child = null;
			// 
			// GraphForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1265, 723);
			this.Controls.Add(this.MyElement);
			this.Name = "GraphForm";
			this.Text = "GraphForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Integration.ElementHost MyElement;
	}
}