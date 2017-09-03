namespace LED_Cube_Utility {
	partial class NewAnimationForm {
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
			this.labelWidth = new System.Windows.Forms.Label();
			this.labelLength = new System.Windows.Forms.Label();
			this.labelHeight = new System.Windows.Forms.Label();
			this.numberEntryWidth = new System.Windows.Forms.NumericUpDown();
			this.numberEntryLength = new System.Windows.Forms.NumericUpDown();
			this.numberEntryHeight = new System.Windows.Forms.NumericUpDown();
			this.labelExplanation = new System.Windows.Forms.Label();
			this.buttonCreate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numberEntryWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberEntryLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberEntryHeight)).BeginInit();
			this.SuspendLayout();
			// 
			// labelWidth
			// 
			this.labelWidth.AutoSize = true;
			this.labelWidth.Location = new System.Drawing.Point(12, 26);
			this.labelWidth.Name = "labelWidth";
			this.labelWidth.Size = new System.Drawing.Size(54, 20);
			this.labelWidth.TabIndex = 0;
			this.labelWidth.Text = "Width:";
			// 
			// labelLength
			// 
			this.labelLength.AutoSize = true;
			this.labelLength.Location = new System.Drawing.Point(12, 58);
			this.labelLength.Name = "labelLength";
			this.labelLength.Size = new System.Drawing.Size(63, 20);
			this.labelLength.TabIndex = 1;
			this.labelLength.Text = "Length:";
			// 
			// labelHeight
			// 
			this.labelHeight.AutoSize = true;
			this.labelHeight.Location = new System.Drawing.Point(12, 90);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new System.Drawing.Size(60, 20);
			this.labelHeight.TabIndex = 2;
			this.labelHeight.Text = "Height:";
			// 
			// numberEntryWidth
			// 
			this.numberEntryWidth.Location = new System.Drawing.Point(230, 26);
			this.numberEntryWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberEntryWidth.Name = "numberEntryWidth";
			this.numberEntryWidth.Size = new System.Drawing.Size(120, 26);
			this.numberEntryWidth.TabIndex = 4;
			this.numberEntryWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numberEntryLength
			// 
			this.numberEntryLength.Location = new System.Drawing.Point(230, 58);
			this.numberEntryLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberEntryLength.Name = "numberEntryLength";
			this.numberEntryLength.Size = new System.Drawing.Size(120, 26);
			this.numberEntryLength.TabIndex = 5;
			this.numberEntryLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numberEntryHeight
			// 
			this.numberEntryHeight.Location = new System.Drawing.Point(230, 90);
			this.numberEntryHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberEntryHeight.Name = "numberEntryHeight";
			this.numberEntryHeight.Size = new System.Drawing.Size(120, 26);
			this.numberEntryHeight.TabIndex = 6;
			this.numberEntryHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelExplanation
			// 
			this.labelExplanation.AutoSize = true;
			this.labelExplanation.Location = new System.Drawing.Point(32, 3);
			this.labelExplanation.Name = "labelExplanation";
			this.labelExplanation.Size = new System.Drawing.Size(287, 20);
			this.labelExplanation.TabIndex = 7;
			this.labelExplanation.Text = "Please select the animation dimensions";
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(138, 125);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 32);
			this.buttonCreate.TabIndex = 8;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// NewAnimationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 169);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.labelExplanation);
			this.Controls.Add(this.numberEntryHeight);
			this.Controls.Add(this.numberEntryLength);
			this.Controls.Add(this.numberEntryWidth);
			this.Controls.Add(this.labelHeight);
			this.Controls.Add(this.labelLength);
			this.Controls.Add(this.labelWidth);
			this.Name = "NewAnimationForm";
			this.Text = "NewAnimationForm";
			((System.ComponentModel.ISupportInitialize)(this.numberEntryWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberEntryLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberEntryHeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelWidth;
		private System.Windows.Forms.Label labelLength;
		private System.Windows.Forms.Label labelHeight;
		private System.Windows.Forms.NumericUpDown numberEntryWidth;
		private System.Windows.Forms.NumericUpDown numberEntryLength;
		private System.Windows.Forms.NumericUpDown numberEntryHeight;
		private System.Windows.Forms.Label labelExplanation;
		private System.Windows.Forms.Button buttonCreate;
	}
}