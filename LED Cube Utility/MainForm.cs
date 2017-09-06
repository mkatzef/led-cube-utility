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
using System.IO;
using Newtonsoft.Json.Linq;
using System.IO.Ports;
using System.Threading;

namespace LED_Cube_Utility {
	public partial class MainForm : Form {
		Color BUTTON_SET_COLOR = Color.Black;
		Color BUTTON_NOT_SET_COLOR = Color.White;
		public static int DEFAULT_BAUD_RATE = 9600;

		private string AnimationFilePath = null;
		private Led3dAnimation Animation = null;
		private int AnimationFrameIndex = -1;
		private Led3dFrame AnimationFrame = null;
		private int AnimationLayerIndex = -1;
		private Led3dFrameLayer AnimationLayer = null;
		private Dictionary<Tuple<int, int>, Button> PixelButtons;

		SerialPort sp = null;
		int CurrentBaudRate = DEFAULT_BAUD_RATE;

		public static byte START_BYTE = 0xAA;
		public static byte END_BYTE = 0x55;


		public MainForm() {
			InitializeComponent();
			PixelButtons = new Dictionary<Tuple<int, int>, Button>();
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
				buttonColor = BUTTON_SET_COLOR;
			} else {
				buttonColor = BUTTON_NOT_SET_COLOR;
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
			NewAnimationForm dimensionForm = new NewAnimationForm();
			dimensionForm.ShowDialog();

			if (dimensionForm.DialogResult == DialogResult.OK) {
				Animation = new Led3dAnimation(dimensionForm.Width, dimensionForm.Length, dimensionForm.Height);
				AnimationFrameIndex = 0;
				AnimationFrame = Animation.GetFrame(AnimationFrameIndex);
				AnimationLayerIndex = 0;

				AnimationFilePath = null;

				CreateButtons();
				RepositionButtons();

				ChangeAnimationFrame(AnimationFrameIndex);
				ChangeAnimationLayer(AnimationLayerIndex);
			}			
		}

		private void mnuFileOpen_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
			ofd.FilterIndex = 1;
			ofd.RestoreDirectory = true;

			if (ofd.ShowDialog() == DialogResult.OK) {
				AnimationFilePath = ofd.FileName;
				OpenAnimation();
			}
		}

		private void OpenAnimation() {
			using (FileStream inStream = new FileStream(AnimationFilePath, FileMode.Open)) {
				using (StreamReader inStreamReader = new StreamReader(inStream)) {
					string fileContents = inStreamReader.ReadToEnd();
					JObject animationObject = null;
					try {
						animationObject = JObject.Parse(fileContents);
					} catch (Exception e) {
						MessageBox.Show("The given file contains malformed JSON.");
					}

					if (animationObject != null) {
						try {
							Animation = new Led3dAnimation(animationObject);
							AnimationFrameIndex = 0;
							AnimationLayerIndex = 0;

							CreateButtons();
							RepositionButtons();

							ChangeAnimationFrame(AnimationFrameIndex);
							ChangeAnimationLayer(AnimationLayerIndex);
						} catch (Exception e) {
							MessageBox.Show("The contained JSON does not represent an animation.");
						}
					}
				}
			}
		}

		private void mnuFileSave_Click(object sender, EventArgs e) {
			if (Animation == null) {
				MessageBox.Show("No animation active.");
				return;
			}

			if (AnimationFilePath == null) { // A chance to set a save location
				SelectSaveLocation();
			}

			if (AnimationFilePath != null) {
				SaveAnimation();
			}
		}

		private void mnuFileSaveAs_Click(object sender, EventArgs e) {
			if (Animation == null) {
				MessageBox.Show("No animation active.");
				return;
			}

			SelectSaveLocation();

			if (AnimationFilePath != null) {
				SaveAnimation();
			}
		}

		private void SelectSaveLocation() {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
			sfd.FilterIndex = 1;
			sfd.RestoreDirectory = true;

			if (sfd.ShowDialog() == DialogResult.OK) {
				AnimationFilePath = sfd.FileName;
			}
		}

		private void SaveAnimation() {
			using (Stream outStream = new FileStream(AnimationFilePath, FileMode.Create)) {
				using (StreamWriter sw = new StreamWriter(outStream)) {
					sw.Write(Animation.ToJson().ToString());
				}
			}
		}

		private void mnuEditNewFrame_Click(object sender, EventArgs e) {
			if (Animation == null) {
				MessageBox.Show("Please create a new animation first.");
				return;
			}

			FrameInsertForm frameInsertForm = new FrameInsertForm(Animation.GetFrameCount());
			frameInsertForm.ShowDialog();

			if (frameInsertForm.DialogResult == DialogResult.OK) {
				Animation.AddFrame(frameInsertForm.Index);
				AnimationFrameIndex = frameInsertForm.Index;
				AnimationLayerIndex = 0;

				ChangeAnimationFrame(AnimationFrameIndex);
				ChangeAnimationLayer(AnimationLayerIndex);
			}
		}

		private void mnuEditDeleteFrame_Click(object sender, EventArgs e) {
			if (Animation == null) {
				MessageBox.Show("Please create a new animation first.");
				return;
			}

			int frameCount = Animation.GetFrameCount();

			if (frameCount <= 1) {
				MessageBox.Show("An animation must be at least one frame long.");
				return;
			}

			FrameDeleteForm frameDeleteForm = new FrameDeleteForm(Animation.GetFrameCount() - 1);
			frameDeleteForm.ShowDialog();

			if (frameDeleteForm.DialogResult == DialogResult.OK) {
				Animation.DelFrame(frameDeleteForm.Index);

				if (AnimationFrameIndex >= frameDeleteForm.Index) { // Removed focus frame or focus frame shifted in delete
					if (AnimationFrameIndex > 0) {
						AnimationFrameIndex--;
					}
				}

				ChangeAnimationFrame(AnimationFrameIndex);
				ChangeAnimationLayer(AnimationLayerIndex);
			}
		}

		private void buttonLayerUp_Click(object sender, EventArgs e) {
			if (Animation == null) {
				MessageBox.Show("No animation active.");
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
				MessageBox.Show("No animation active.");
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
				MessageBox.Show("No animation active.");
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
				MessageBox.Show("No animation active.");
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
				MessageBox.Show("No animation active.");
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
				MessageBox.Show("No animation active.");
				return;
			}

			int resultingFrame = AnimationFrameIndex - 1;
			if (resultingFrame >= 0) {
				AnimationFrameIndex--;
				ChangeAnimationFrame(AnimationFrameIndex);
			}
		}

		private void buttonFrameTime_Click(object sender, EventArgs e) {
			if (Animation == null) {
				MessageBox.Show("Please create a new animation first.");
				return;
			}

			int currentFrameDuration = (int)Animation.GetFrameDuration(AnimationFrameIndex);
			FrameTimeForm frameTimeForm = new FrameTimeForm(currentFrameDuration);
			frameTimeForm.ShowDialog();

			if (frameTimeForm.DialogResult == DialogResult.OK) {
				Animation.SetFrameDuration(AnimationFrameIndex, frameTimeForm.TimeMillis);
			}
		}


		private void mnuToolsComPort_Click(object sender, EventArgs e) {
			ComPortSelectionForm cpsf = new ComPortSelectionForm();
			cpsf.ShowDialog();

			if (cpsf.DialogResult == DialogResult.OK) {
				string portName = cpsf.portName;
				sp = new SerialPort(portName);
				sp.DataBits = 8;
				sp.StopBits = StopBits.One;
				sp.Parity = Parity.None;
				sp.BaudRate = CurrentBaudRate;
			}
		}

		private void mnuToolsBaudRate_Click(object sender, EventArgs e) {
			if (sp == null) {
				MessageBox.Show("Please select a COM port.");
				return;
			}

			BaudRateSelectionForm brsf = new BaudRateSelectionForm(CurrentBaudRate);
			brsf.ShowDialog();

			if (brsf.DialogResult == DialogResult.OK) {
				CurrentBaudRate = brsf.baudRate;
				sp.BaudRate = CurrentBaudRate;
			}
		}

		private void mnuToolsProgramDevice_Click(object sender, EventArgs e) {
			if (Animation == null) {
				MessageBox.Show("Please create a new animation first.");
				return;
			}

			if (sp == null) {
				MessageBox.Show("Please select a COM port.");
				return;
			}
			
			sp.Open();

			byte[] animationAsBytes = Animation.ToBytes();
			int animationBytesLen = animationAsBytes.Length;
			byte[] packet = new byte[animationBytesLen + 2];
			packet[0] = START_BYTE;
			packet[animationBytesLen + 1] = END_BYTE;
			animationAsBytes.CopyTo(packet, 1);
			
			sp.Write(packet, 0, animationBytesLen + 2);

			sp.Close();

			MessageBox.Show("Animation sent.");
		}
	}
}
