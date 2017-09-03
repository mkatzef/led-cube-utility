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
	public partial class NewAnimationForm : Form {
		public int Width { get { return (int)numberEntryWidth.Value; } }
		public int Length { get { return (int)numberEntryLength.Value; } }
		public int Height { get { return (int)numberEntryHeight.Value; } }

		public NewAnimationForm() {
			InitializeComponent();
		}

		private void buttonCreate_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
			Close();
		}
	}
}
