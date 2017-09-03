using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Led3dImage;

namespace LED_Cube_Utility {
	public partial class MainForm : Form {
		private string AnimationFilePath = null;
		private Led3dAnimation Animation = null;
		private int CurrentAnimationLayer = 0;

		public MainForm() {
			InitializeComponent();
		}

		public void ErrorPopUp(string message) {
			var errorForm = new ErrorForm();
			errorForm.SetMessage(message);
			errorForm.Show();
		}

		private void mnuFileNew_Click(object sender, EventArgs e) {
			var dimensionForm = new NewAnimationForm();
			dimensionForm.ShowDialog();

			if (dimensionForm.DialogResult == DialogResult.OK) {
				Animation = new Led3dAnimation(dimensionForm.Width, dimensionForm.Length, dimensionForm.Height);
			}			
		}

		private void mnuFileOpen_Click(object sender, EventArgs e) {
			ErrorPopUp("Not implemented.");
		}

		private void mnuFileSave_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			ErrorPopUp("Not implemented.");
		}

		private void mnuFileSaveAs_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			ErrorPopUp("Not implemented.");
		}

		private void mnuEditNewFrame_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("Please create a new animation first.");
				return;
			}

			ErrorPopUp("Not implemented.");
		}

		private void mnuEditFrame_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			ErrorPopUp("Not implemented.");
		}

		private void mnuEditFillLayer_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			ErrorPopUp("Not implemented.");
		}

		private void mnuEditClearLayer_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			ErrorPopUp("Not implemented.");
		}

		private void mnuToolsComPort_Click(object sender, EventArgs e) {
			ErrorPopUp("Not implemented.");
		}

		private void mnuToolsBaudRate_Click(object sender, EventArgs e) {
			ErrorPopUp("Not implemented.");
		}

		private void mnuToolsProgramDevice_Click(object sender, EventArgs e) {
			ErrorPopUp("Not implemented.");
		}
	}
}
