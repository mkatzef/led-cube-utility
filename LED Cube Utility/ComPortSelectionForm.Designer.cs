namespace LED_Cube_Utility {
	partial class ComPortSelectionForm {
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
			this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(431, 21);
			this.label1.TabIndex = 7;
			this.label1.Text = "Select the COM port of the connected device.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBoxComPorts
			// 
			this.comboBoxComPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxComPorts.FormattingEnabled = true;
			this.comboBoxComPorts.Location = new System.Drawing.Point(68, 41);
			this.comboBoxComPorts.Name = "comboBoxComPorts";
			this.comboBoxComPorts.Size = new System.Drawing.Size(179, 28);
			this.comboBoxComPorts.TabIndex = 8;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(267, 34);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 41);
			this.buttonOK.TabIndex = 9;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// ComPortSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 94);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.comboBoxComPorts);
			this.Controls.Add(this.label1);
			this.Name = "ComPortSelectionForm";
			this.Text = "ComPortSelectionForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxComPorts;
		private System.Windows.Forms.Button buttonOK;
	}
}