namespace LED_Cube_Utility {
	partial class BaudRateSelectionForm {
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
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownBaudRate = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaudRate)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(387, 54);
			this.label1.TabIndex = 8;
			this.label1.Text = "Enter a Baud rate for communication with the connected device.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDownBaudRate
			// 
			this.numericUpDownBaudRate.Location = new System.Drawing.Point(50, 74);
			this.numericUpDownBaudRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numericUpDownBaudRate.Name = "numericUpDownBaudRate";
			this.numericUpDownBaudRate.Size = new System.Drawing.Size(160, 26);
			this.numericUpDownBaudRate.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(241, 70);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 33);
			this.button1.TabIndex = 10;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BaudRateSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 126);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numericUpDownBaudRate);
			this.Controls.Add(this.label1);
			this.Name = "BaudRateSelectionForm";
			this.Text = "BaudRateSelectionForm";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaudRate)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownBaudRate;
		private System.Windows.Forms.Button button1;
	}
}