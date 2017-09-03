using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Cube_Utility {
	public partial class ErrorForm : Form {
		public ErrorForm() {
			InitializeComponent();
		}

		public void SetMessage(string message) {
			errorLabel.Text = message;
		}

		private void errorOkButton_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
