using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LED_Cube_Utility {
	public partial class ComPortSelectionForm : Form {
		public string portName { get { return comboBoxComPorts.GetItemText(this.comboBoxComPorts.SelectedItem); } }

		public ComPortSelectionForm() {
			InitializeComponent();
			string[] portNames = SerialPort.GetPortNames();
			foreach (string pn in portNames) {
				comboBoxComPorts.Items.Add(pn);
			}
		}

		private void buttonOK_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
			Close();
		}
	}
}
