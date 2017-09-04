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
		private int AnimationFrameIndex = -1;
		private Led3dFrame AnimationFrame = null;
		private int AnimationLayerIndex = -1;
		private Led3dFrameLayer AnimationLayer = null;
		private List<Button> PixelButtons;

		public MainForm() {
			InitializeComponent();
		}

		public void ErrorPopUp(string message) {
			var errorForm = new ErrorForm();
			errorForm.SetMessage(message);
			errorForm.Show();
		}

		// (!) Change to refreshAnimationLayer, move setup code to new function (called by File>New), store buttons in global list
		public void ChangeAnimationLayer(int layerIndex) {
			labelLayerInfo.Text = "Layer " + (layerIndex + 1) + "/" + Animation.Height;
			AnimationLayer = AnimationFrame.GetLed3dFrameLayer(layerIndex);
			// set up the tick boxes

			int panelWidth = panelLayerGrid.Width;
			int panelHeight = panelLayerGrid.Height;

			int borderWidthHorizontal = 10;
			int borderWidthVertical = 10;
			int paddingHorizontal = 5;
			int paddingVertical = 5;

			int startingX = borderWidthHorizontal;
			int startingY = borderWidthVertical;

			int unitsHorizontal = (int)AnimationLayer.Width;
			int unitsVertical = (int)AnimationLayer.Length;

			int unitWidth = (panelWidth - 2 * borderWidthHorizontal - (unitsHorizontal - 1) * paddingHorizontal) / unitsHorizontal;
			int unitHeight = (panelHeight - 2 * borderWidthVertical - (unitsVertical - 1) * paddingVertical) / unitsVertical;

			Color buttonSetColor = Color.Black;
			Color buttonNotSetColor = Color.White;

			int y = startingY;
			for (int verticalIndex = 0; verticalIndex < unitsVertical; verticalIndex++) {
				int x = startingX;
				for (int horizontalIndex = 0; horizontalIndex < unitsHorizontal; horizontalIndex++) {
					Button b = new Button();
					b.Name = "Pixel_" + horizontalIndex + "_" + verticalIndex;
					b.Click += new EventHandler(PixelClickHandler);
					b.Text = "";
					b.Width = unitWidth;
					b.Height = unitHeight;
					b.Location = new Point(x, y);

					Color buttonColor;
					if (AnimationLayer.GetPixel(horizontalIndex, verticalIndex)) {
						buttonColor = buttonSetColor;
					} else {
						buttonColor = buttonNotSetColor;
					}
					b.BackColor = buttonColor;

					panelLayerGrid.Controls.Add(b);

					x += unitWidth + paddingHorizontal;
				}
				y += unitHeight + paddingVertical;
			}

		}

		public void ChangeAnimationFrame(int frameIndex) {
			labelFrameInfo.Text = "Frame " + (frameIndex + 1) + "/" + Animation.GetFrameCount();
			AnimationFrameIndex = frameIndex;
			AnimationLayerIndex = 0;
			AnimationFrame = Animation.GetFrame(AnimationFrameIndex);
			ChangeAnimationLayer(AnimationLayerIndex);
		}

		public void PixelClickHandler(Object sender, EventArgs e) {
			ErrorPopUp(((Button)sender).Name + " was clicked");
		}

		private void mnuFileNew_Click(object sender, EventArgs e) {
			var dimensionForm = new NewAnimationForm();
			dimensionForm.ShowDialog();

			if (dimensionForm.DialogResult == DialogResult.OK) {
				Animation = new Led3dAnimation(dimensionForm.Width, dimensionForm.Length, dimensionForm.Height);
				AnimationFrameIndex = 0;
				AnimationFrame = Animation.GetFrame(AnimationFrameIndex);
				AnimationLayerIndex = 0;

				ChangeAnimationFrame(AnimationFrameIndex);
				ChangeAnimationLayer(AnimationLayerIndex);
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

		private void mnuEditDeleteFrame_Click(object sender, EventArgs e) {

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

		

		private void buttonLayerUp_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			int resultingLayer = AnimationLayerIndex + 1;
			if (resultingLayer < Animation.Height) {
				AnimationLayerIndex++;
				ChangeAnimationLayer(AnimationLayerIndex);
			}
		}

		private void buttonLayerDown_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			int resultingLayer = AnimationLayerIndex - 1;
			if (resultingLayer >= 0) {
				AnimationLayerIndex--;
				ChangeAnimationLayer(AnimationLayerIndex);
			}
		}

		private void buttonFillLayer_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			ErrorPopUp("Not implemented.");
		}

		private void buttonClearLayer_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			ErrorPopUp("Not implemented.");
		}

		private void buttonFrameTime_Click(object sender, EventArgs e) {

		}

		private void buttonFrameLeft_Click(object sender, EventArgs e) {

		}

		private void buttonFrameRight_Click(object sender, EventArgs e) {

		}
	}
}
