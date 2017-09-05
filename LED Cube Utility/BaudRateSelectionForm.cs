﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Cube_Utility {
	public partial class BaudRateSelectionForm : Form {
		public int baudRate { get { return (int)numericUpDownBaudRate.Value; } }

		public BaudRateSelectionForm(int currentBaudRate) {
			InitializeComponent();
			numericUpDownBaudRate.Value = currentBaudRate;
		}

		private void button1_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
			Close();
		}
	}
}
