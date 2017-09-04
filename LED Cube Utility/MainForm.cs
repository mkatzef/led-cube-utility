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
		Color buttonSetColor = Color.Black;
		Color buttonNotSetColor = Color.White;

		private string AnimationFilePath = null;
		private Led3dAnimation Animation = null;
		private int AnimationFrameIndex = -1;
		private Led3dFrame AnimationFrame = null;
		private int AnimationLayerIndex = -1;
		private Led3dFrameLayer AnimationLayer = null;
		private Dictionary<Tuple<int, int>, Button> PixelButtons;

		public MainForm() {
			InitializeComponent();
			PixelButtons = new Dictionary<Tuple<int, int>, Button>();
		}

		public void ErrorPopUp(string message) {
			var errorForm = new ErrorForm();
			errorForm.SetMessage(message);
			errorForm.Show();
		}

		public void CreateButtons() {
			foreach (Button b in PixelButtons.Values) {
				panelLayerGrid.Controls.Remove(b);
			}
			PixelButtons.Clear();

			for (int verticalIndex = 0; verticalIndex < Animation.Length; verticalIndex++) {
				for (int horizontalIndex = 0; horizontalIndex < Animation.Width; horizontalIndex++) {
					Button b = new Button();
					b.Name = "Pixel_" + horizontalIndex + "_" + verticalIndex;
					b.Click += new EventHandler(PixelClickHandler);
					b.Text = "";
					PixelButtons[new Tuple<int, int>(horizontalIndex, verticalIndex)] = b;

					panelLayerGrid.Controls.Add(b);
				}
			}
		}

		private void panelLayerGrid_Resize(object sender, EventArgs e) {
			if (Animation != null) {
				RepositionButtons();
			}
		}

		public void RepositionButtons() {
			int panelWidth = panelLayerGrid.Width;
			int panelHeight = panelLayerGrid.Height;

			int borderWidthHorizontal = 10;
			int borderWidthVertical = 10;
			int paddingHorizontal = 5;
			int paddingVertical = 5;

			int startingX = borderWidthHorizontal;
			int startingY = borderWidthVertical;

			int unitsHorizontal = (int)Animation.Width;
			int unitsVertical = (int)Animation.Length;

			int unitWidth = (panelWidth - 2 * borderWidthHorizontal - (unitsHorizontal - 1) * paddingHorizontal) / unitsHorizontal;
			int unitHeight = (panelHeight - 2 * borderWidthVertical - (unitsVertical - 1) * paddingVertical) / unitsVertical;

			int y = startingY;
			for (int verticalIndex = 0; verticalIndex < unitsVertical; verticalIndex++) {
				int x = startingX;
				for (int horizontalIndex = 0; horizontalIndex < unitsHorizontal; horizontalIndex++) {
					Button b = PixelButtons[new Tuple<int, int>(horizontalIndex, verticalIndex)];
					b.Width = unitWidth;
					b.Height = unitHeight;
					b.Location = new Point(x, y);

					x += unitWidth + paddingHorizontal;
				}
				y += unitHeight + paddingVertical;
			}
		}

		public void RecolorButton(int colIndex, int rowIndex) {
			Button b = PixelButtons[new Tuple<int, int>(colIndex, rowIndex)];

			Color buttonColor;
			if (AnimationLayer.GetPixel(colIndex, rowIndex)) {
				buttonColor = buttonSetColor;
			} else {
				buttonColor = buttonNotSetColor;
			}
			b.BackColor = buttonColor;
		}

		public void RecolorButtons() {
			for (int verticalIndex = 0; verticalIndex < Animation.Length; verticalIndex++) {
				for (int horizontalIndex = 0; horizontalIndex < Animation.Width; horizontalIndex++) {
					RecolorButton(horizontalIndex, verticalIndex);
				}
			}
		}
		
		public void ChangeAnimationLayer(int layerIndex) {
			labelLayerInfo.Text = "Layer " + (layerIndex + 1) + "/" + Animation.Height;
			AnimationLayer = AnimationFrame.GetLed3dFrameLayer(layerIndex);

			RecolorButtons();
		}

		public void ChangeAnimationFrame(int frameIndex) {
			labelFrameInfo.Text = "Frame " + (frameIndex + 1) + "/" + Animation.GetFrameCount();
			AnimationFrameIndex = frameIndex;
			AnimationLayerIndex = 0;
			AnimationFrame = Animation.GetFrame(AnimationFrameIndex);
			ChangeAnimationLayer(AnimationLayerIndex);
		}

		public void PixelClickHandler(Object sender, EventArgs e) {
			string name = ((Button)sender).Name;
			string[] tokens = name.Split('_');
			int col = int.Parse(tokens[1]);
			int row = int.Parse(tokens[2]);
			bool prevVal = AnimationLayer.GetPixel(col, row);
			AnimationLayer.SetPixel(col, row, !prevVal);
			RecolorButton(col, row);
		}

		private void mnuFileNew_Click(object sender, EventArgs e) {
			var dimensionForm = new NewAnimationForm();
			dimensionForm.ShowDialog();

			if (dimensionForm.DialogResult == DialogResult.OK) {
				Animation = new Led3dAnimation(dimensionForm.Width, dimensionForm.Length, dimensionForm.Height);
				AnimationFrameIndex = 0;
				AnimationFrame = Animation.GetFrame(AnimationFrameIndex);
				AnimationLayerIndex = 0;

				CreateButtons();
				RepositionButtons();

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

			for (int verticalIndex = 0; verticalIndex < Animation.Length; verticalIndex++) {
				for (int horizontalIndex = 0; horizontalIndex < Animation.Width; horizontalIndex++) {
					AnimationLayer.SetPixel(horizontalIndex, verticalIndex, true);
				}
			}
			RecolorButtons();
		}

		private void buttonClearLayer_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			for (int verticalIndex = 0; verticalIndex < Animation.Length; verticalIndex++) {
				for (int horizontalIndex = 0; horizontalIndex < Animation.Width; horizontalIndex++) {
					AnimationLayer.SetPixel(horizontalIndex, verticalIndex, false);
				}
			}
			RecolorButtons();
		}

		private void buttonFrameRight_Click(object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			int resultingFrame = AnimationFrameIndex + 1;
			if (resultingFrame < Animation.GetFrameCount()) {
				AnimationFrameIndex++;
				ChangeAnimationFrame(AnimationFrameIndex);
			}
		}

		private void buttonFrameLeft_Click (object sender, EventArgs e) {
			if (Animation == null) {
				ErrorPopUp("No animation active.");
				return;
			}

			int resultingFrame = AnimationFrameIndex - 1;
			if (resultingFrame >= 0) {
				AnimationFrameIndex--;
				ChangeAnimationFrame(AnimationFrameIndex);
			}
		}

		private void buttonFrameTime_Click(object sender, EventArgs e) {
			ErrorPopUp("Not implemented.");
		}
	}
}
