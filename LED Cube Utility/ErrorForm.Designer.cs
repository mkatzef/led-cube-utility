namespace LED_Cube_Utility {
	partial class ErrorForm {
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
			this.errorOkButton = new System.Windows.Forms.Button();
			this.errorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// errorOkButton
			// 
			this.errorOkButton.Location = new System.Drawing.Point(129, 69);
			this.errorOkButton.Name = "errorOkButton";
			this.errorOkButton.Size = new System.Drawing.Size(141, 29);
			this.errorOkButton.TabIndex = 1;
			this.errorOkButton.Text = "OK";
			this.errorOkButton.UseVisualStyleBackColor = true;
			this.errorOkButton.Click += new System.EventHandler(this.errorOkButton_Click);
			// 
			// errorLabel
			// 
			this.errorLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.errorLabel.Location = new System.Drawing.Point(0, 0);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(408, 57);
			this.errorLabel.TabIndex = 2;
			this.errorLabel.Text = "label1";
			this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 110);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.errorOkButton);
			this.Name = "ErrorForm";
			this.Text = "Error";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button errorOkButton;
		private System.Windows.Forms.Label errorLabel;
	}
}