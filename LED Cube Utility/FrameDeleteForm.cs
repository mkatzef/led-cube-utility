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
	public partial class FrameDeleteForm : Form {
		public int Index { get { return (int)upDownFrameIndex.Value; } }

		public FrameDeleteForm(int maxIndex) {
			InitializeComponent();
			upDownFrameIndex.Maximum = maxIndex;
		}

		private void button1_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
			Close();
		}
	}
}
