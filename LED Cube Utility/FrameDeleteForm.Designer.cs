namespace LED_Cube_Utility {
	partial class FrameDeleteForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.upDownFrameIndex = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.upDownFrameIndex)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(195, 61);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 29);
			this.button1.TabIndex = 5;
			this.button1.Text = "Delete";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Delete frame at which index?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// upDownFrameIndex
			// 
			this.upDownFrameIndex.Location = new System.Drawing.Point(27, 62);
			this.upDownFrameIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.upDownFrameIndex.Name = "upDownFrameIndex";
			this.upDownFrameIndex.Size = new System.Drawing.Size(135, 26);
			this.upDownFrameIndex.TabIndex = 3;
			// 
			// FrameDeleteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 105);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.upDownFrameIndex);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrameDeleteForm";
			this.Text = "FrameDeleteForm";
			((System.ComponentModel.ISupportInitialize)(this.upDownFrameIndex)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown upDownFrameIndex;
	}
}