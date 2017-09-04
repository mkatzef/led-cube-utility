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
			this.mnuEditDeleteFrame = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsComPort = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsBaudRate = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsProgramDevice = new System.Windows.Forms.ToolStripMenuItem();
			this.panelLayerOptions = new System.Windows.Forms.Panel();
			this.labelFrameInfo = new System.Windows.Forms.Label();
			this.buttonClearLayer = new System.Windows.Forms.Button();
			this.buttonFillLayer = new System.Windows.Forms.Button();
			this.buttonLayerDown = new System.Windows.Forms.Button();
			this.buttonLayerUp = new System.Windows.Forms.Button();
			this.labelLayerInfo = new System.Windows.Forms.Label();
			this.buttonFrameRight = new System.Windows.Forms.Button();
			this.buttonFrameLeft = new System.Windows.Forms.Button();
			this.buttonFrameTime = new System.Windows.Forms.Button();
			this.panelLayerGrid = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panelLayerOptions.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(724, 33);
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
			this.mnuFileNew.Size = new System.Drawing.Size(170, 30);
			this.mnuFileNew.Text = "New";
			this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.Name = "mnuFileOpen";
			this.mnuFileOpen.Size = new System.Drawing.Size(170, 30);
			this.mnuFileOpen.Text = "Open...";
			this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
			// 
			// mnuFileSave
			// 
			this.mnuFileSave.Name = "mnuFileSave";
			this.mnuFileSave.Size = new System.Drawing.Size(170, 30);
			this.mnuFileSave.Text = "Save";
			this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
			// 
			// mnuFileSaveAs
			// 
			this.mnuFileSaveAs.Name = "mnuFileSaveAs";
			this.mnuFileSaveAs.Size = new System.Drawing.Size(170, 30);
			this.mnuFileSaveAs.Text = "Save As...";
			this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditNewFrame,
            this.mnuEditDeleteFrame});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// mnuEditNewFrame
			// 
			this.mnuEditNewFrame.Name = "mnuEditNewFrame";
			this.mnuEditNewFrame.Size = new System.Drawing.Size(200, 30);
			this.mnuEditNewFrame.Text = "New Frame...";
			this.mnuEditNewFrame.Click += new System.EventHandler(this.mnuEditNewFrame_Click);
			// 
			// mnuEditDeleteFrame
			// 
			this.mnuEditDeleteFrame.Name = "mnuEditDeleteFrame";
			this.mnuEditDeleteFrame.Size = new System.Drawing.Size(200, 30);
			this.mnuEditDeleteFrame.Text = "Delete Frame";
			this.mnuEditDeleteFrame.Click += new System.EventHandler(this.mnuEditDeleteFrame_Click);
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
			// panelLayerOptions
			// 
			this.panelLayerOptions.Controls.Add(this.labelFrameInfo);
			this.panelLayerOptions.Controls.Add(this.buttonClearLayer);
			this.panelLayerOptions.Controls.Add(this.buttonFillLayer);
			this.panelLayerOptions.Controls.Add(this.buttonLayerDown);
			this.panelLayerOptions.Controls.Add(this.buttonLayerUp);
			this.panelLayerOptions.Controls.Add(this.labelLayerInfo);
			this.panelLayerOptions.Controls.Add(this.buttonFrameRight);
			this.panelLayerOptions.Controls.Add(this.buttonFrameLeft);
			this.panelLayerOptions.Controls.Add(this.buttonFrameTime);
			this.panelLayerOptions.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLayerOptions.Location = new System.Drawing.Point(0, 33);
			this.panelLayerOptions.Name = "panelLayerOptions";
			this.panelLayerOptions.Size = new System.Drawing.Size(112, 586);
			this.panelLayerOptions.TabIndex = 1;
			// 
			// labelFrameInfo
			// 
			this.labelFrameInfo.AutoSize = true;
			this.labelFrameInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelFrameInfo.Location = new System.Drawing.Point(0, 413);
			this.labelFrameInfo.Name = "labelFrameInfo";
			this.labelFrameInfo.Size = new System.Drawing.Size(55, 20);
			this.labelFrameInfo.TabIndex = 16;
			this.labelFrameInfo.Text = "Frame";
			// 
			// buttonClearLayer
			// 
			this.buttonClearLayer.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonClearLayer.Location = new System.Drawing.Point(0, 173);
			this.buttonClearLayer.Name = "buttonClearLayer";
			this.buttonClearLayer.Size = new System.Drawing.Size(112, 51);
			this.buttonClearLayer.TabIndex = 15;
			this.buttonClearLayer.Text = "Clear Layer";
			this.buttonClearLayer.UseVisualStyleBackColor = true;
			// 
			// buttonFillLayer
			// 
			this.buttonFillLayer.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonFillLayer.Location = new System.Drawing.Point(0, 122);
			this.buttonFillLayer.Name = "buttonFillLayer";
			this.buttonFillLayer.Size = new System.Drawing.Size(112, 51);
			this.buttonFillLayer.TabIndex = 14;
			this.buttonFillLayer.Text = "Fill Layer";
			this.buttonFillLayer.UseVisualStyleBackColor = true;
			// 
			// buttonLayerDown
			// 
			this.buttonLayerDown.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonLayerDown.Location = new System.Drawing.Point(0, 71);
			this.buttonLayerDown.Name = "buttonLayerDown";
			this.buttonLayerDown.Size = new System.Drawing.Size(112, 51);
			this.buttonLayerDown.TabIndex = 13;
			this.buttonLayerDown.Text = "Layer Down";
			this.buttonLayerDown.UseVisualStyleBackColor = true;
			this.buttonLayerDown.Click += new System.EventHandler(this.buttonLayerDown_Click);
			// 
			// buttonLayerUp
			// 
			this.buttonLayerUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonLayerUp.Location = new System.Drawing.Point(0, 20);
			this.buttonLayerUp.Name = "buttonLayerUp";
			this.buttonLayerUp.Size = new System.Drawing.Size(112, 51);
			this.buttonLayerUp.TabIndex = 12;
			this.buttonLayerUp.Text = "Layer Up";
			this.buttonLayerUp.UseVisualStyleBackColor = true;
			this.buttonLayerUp.Click += new System.EventHandler(this.buttonLayerUp_Click);
			// 
			// labelLayerInfo
			// 
			this.labelLayerInfo.AutoSize = true;
			this.labelLayerInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelLayerInfo.Location = new System.Drawing.Point(0, 0);
			this.labelLayerInfo.Name = "labelLayerInfo";
			this.labelLayerInfo.Size = new System.Drawing.Size(48, 20);
			this.labelLayerInfo.TabIndex = 11;
			this.labelLayerInfo.Text = "Layer";
			// 
			// buttonFrameRight
			// 
			this.buttonFrameRight.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonFrameRight.Location = new System.Drawing.Point(0, 433);
			this.buttonFrameRight.Name = "buttonFrameRight";
			this.buttonFrameRight.Size = new System.Drawing.Size(112, 51);
			this.buttonFrameRight.TabIndex = 10;
			this.buttonFrameRight.Text = "Frame Right";
			this.buttonFrameRight.UseVisualStyleBackColor = true;
			this.buttonFrameRight.Click += new System.EventHandler(this.buttonFrameRight_Click);
			// 
			// buttonFrameLeft
			// 
			this.buttonFrameLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonFrameLeft.Location = new System.Drawing.Point(0, 484);
			this.buttonFrameLeft.Name = "buttonFrameLeft";
			this.buttonFrameLeft.Size = new System.Drawing.Size(112, 51);
			this.buttonFrameLeft.TabIndex = 9;
			this.buttonFrameLeft.Text = "Frame Left";
			this.buttonFrameLeft.UseVisualStyleBackColor = true;
			// 
			// buttonFrameTime
			// 
			this.buttonFrameTime.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonFrameTime.Location = new System.Drawing.Point(0, 535);
			this.buttonFrameTime.Name = "buttonFrameTime";
			this.buttonFrameTime.Size = new System.Drawing.Size(112, 51);
			this.buttonFrameTime.TabIndex = 8;
			this.buttonFrameTime.Text = "Frame Time";
			this.buttonFrameTime.UseVisualStyleBackColor = true;
			// 
			// panelLayerGrid
			// 
			this.panelLayerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLayerGrid.Location = new System.Drawing.Point(112, 33);
			this.panelLayerGrid.Name = "panelLayerGrid";
			this.panelLayerGrid.Size = new System.Drawing.Size(612, 586);
			this.panelLayerGrid.TabIndex = 3;
			this.panelLayerGrid.Resize += new System.EventHandler(this.panelLayerGrid_Resize);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 619);
			this.Controls.Add(this.panelLayerGrid);
			this.Controls.Add(this.panelLayerOptions);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "LED Cube Utility";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelLayerOptions.ResumeLayout(false);
			this.panelLayerOptions.PerformLayout();
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
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsComPort;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsBaudRate;
		private System.Windows.Forms.ToolStripMenuItem mnuToolsProgramDevice;
		private System.Windows.Forms.Panel panelLayerOptions;
		private System.Windows.Forms.ToolStripMenuItem mnuEditDeleteFrame;
		private System.Windows.Forms.Panel panelLayerGrid;
		private System.Windows.Forms.Label labelFrameInfo;
		private System.Windows.Forms.Button buttonClearLayer;
		private System.Windows.Forms.Button buttonFillLayer;
		private System.Windows.Forms.Button buttonLayerDown;
		private System.Windows.Forms.Button buttonLayerUp;
		private System.Windows.Forms.Label labelLayerInfo;
		private System.Windows.Forms.Button buttonFrameRight;
		private System.Windows.Forms.Button buttonFrameLeft;
		private System.Windows.Forms.Button buttonFrameTime;
	}
}

