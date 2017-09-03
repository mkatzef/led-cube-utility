namespace LED_Cube_Utility {
	partial class MainForm {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditNewFrame = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditFrame = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuEditFillLayer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEditClearLayer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsComPort = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsBaudRate = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsProgramDevice = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(430, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mnuFileNew
			// 
			this.mnuFileNew.Name = "mnuFileNew";
			this.mnuFileNew.Size = new System.Drawing.Size(210, 30);
			this.mnuFileNew.Text = "New";
			this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.Name = "mnuFileOpen";
			this.mnuFileOpen.Size = new System.Drawing.Size(210, 30);
			this.mnuFileOpen.Text = "Open...";
			this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
			// 
			// mnuFileSave
			// 
			this.mnuFileSave.Name = "mnuFileSave";
			this.mnuFileSave.Size = new System.Drawing.Size(210, 30);
			this.mnuFileSave.Text = "Save";
			this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
			// 
			// mnuFileSaveAs
			// 
			this.mnuFileSaveAs.Name = "mnuFileSaveAs";
			this.mnuFileSaveAs.Size = new System.Drawing.Size(210, 30);
			this.mnuFileSaveAs.Text = "Save As...";
			this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditNewFrame,
            this.mnuEditFrame,
            this.toolStripMenuItem1,
            this.mnuEditFillLayer,
            this.mnuEditClearLayer});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// mnuEditNewFrame
			// 
			this.mnuEditNewFrame.Name = "mnuEditNewFrame";
			this.mnuEditNewFrame.Size = new System.Drawing.Size(210, 30);
			this.mnuEditNewFrame.Text = "New Frame";
			this.mnuEditNewFrame.Click += new System.EventHandler(this.mnuEditNewFrame_Click);
			// 
			// mnuEditFrame
			// 
			this.mnuEditFrame.Name = "mnuEditFrame";
			this.mnuEditFrame.Size = new System.Drawing.Size(210, 30);
			this.mnuEditFrame.Text = "Frame";
			this.mnuEditFrame.Click += new System.EventHandler(this.mnuEditFrame_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
			// 
			// mnuEditFillLayer
			// 
			this.mnuEditFillLayer.Name = "mnuEditFillLayer";
			this.mnuEditFillLayer.Size = new System.Drawing.Size(210, 30);
			this.mnuEditFillLayer.Text = "Fill Layer";
			this.mnuEditFillLayer.Click += new System.EventHandler(this.mnuEditFillLayer_Click);
			// 
			// mnuEditClearLayer
			// 
			this.mnuEditClearLayer.Name = "mnuEditClearLayer";
			this.mnuEditClearLayer.Size = new System.Drawing.Size(210, 30);
			this.mnuEditClearLayer.Text = "Clear Layer";
			this.mnuEditClearLayer.Click += new System.EventHandler(this.mnuEditClearLayer_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsComPort,
            this.mnuToolsBaudRate,
            this.mnuToolsProgramDevice});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// mnuToolsComPort
			// 
			this.mnuToolsComPort.Name = "mnuToolsComPort";
			this.mnuToolsComPort.Size = new System.Drawing.Size(222, 30);
			this.mnuToolsComPort.Text = "COM Port...";
			this.mnuToolsComPort.Click += new System.EventHandler(this.mnuToolsComPort_Click);
			// 
			// mnuToolsBaudRate
			// 
			this.mnuToolsBaudRate.Name = "mnuToolsBaudRate";
			this.mnuToolsBaudRate.Size = new System.Drawing.Size(222, 30);
			this.mnuToolsBaudRate.Text = "Baud Rate...";
			this.mnuToolsBaudRate.Click += new System.EventHandler(this.mnuToolsBaudRate_Click);
			// 
			// mnuToolsProgramDevice
			// 
			this.mnuToolsProgramDevice.Name = "mnuToolsProgramDevice";
			this.mnuToolsProgramDevice.Size = new System.Drawing.Size(222, 30);
			this.mnuToolsProgramDevice.Text = "Program Device";
			this.mnuToolsProgramDevice.Click += new System.EventHandler(this.mnuToolsProgramDevice_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 358);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.Text = "LED Cube Utility";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
		private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
		private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
		private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuEditNewFrame;
		private System.Windows.Forms.ToolStripMenuItem mnuEditFrame;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuEditFillLayer;
		private System.Windows.Forms.ToolStripMenuItem mnuEditClearLayer;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsComPort;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsBaudRate;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsProgramDevice;
	}
}

