using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Led3dImage
{
	/// <summary>
	/// A 3D image/single frame acting as a collection of multiple 2D image layers.
	/// Allows access to individual layers.
	/// </summary>
    public class Led3dFrame
    {
		private List<Led3dFrameLayer> Led3dFrameLayers;
		public UInt32 Width
		{
			get;
			private set;
		}
		public UInt32 Length
		{
			get;
			private set;
		}
		public UInt32 Height
		{
			get;
			private set;
		}

		/// <summary>
		/// The constructor to create a blank 3D image with the given dimensions.
		/// </summary>
		/// <param name="width">One horizontal dimension of the image.</param>
		/// <param name="length">The other horizontal dimension of the image.</param>
		/// <param name="height">The vertical dimension of the image.</param>
		public Led3dFrame(int width, int length, int height) {
			if (width < 0) {
				throw (new ArgumentException("Negative width given."));
			}
			if (length < 0) {
				throw (new ArgumentException("Negative length given."));
			}
			if (height < 0) {
				throw (new ArgumentException("Negative height given."));
			}

			Width = (UInt32) width;
			Length = (UInt32) length;
			Height = (UInt32) height;

			Led3dFrameLayers = new List<Led3dFrameLayer>(height);
			for (int i = 0; i < height; i++) {
				Led3dFrameLayers.Add(new Led3dFrameLayer(width, length));
			}
		}

		public Led3dFrame(JObject jsonFrame) {
			Width = (uint)jsonFrame.SelectToken("Width");
			Length = (uint)jsonFrame.SelectToken("Length");
			Height = (uint)jsonFrame.SelectToken("Height");

			Led3dFrameLayers = new List<Led3dFrameLayer>((int)Height);
			for (int heightIndex = 0; heightIndex < Height; heightIndex++) {
				JObject layerObject = (JObject)jsonFrame.SelectToken("Layer" + heightIndex);
				layerObject.Add(new JProperty("Width", Width));
				layerObject.Add(new JProperty("Length", Length));
				Led3dFrameLayers.Add(new Led3dFrameLayer(layerObject));
			}
		}

		/// <summary>
		/// Returns a reference to the Led3dFrameLayer object at the given height.
		/// </summary>
		/// <param name="heightIndex">The height of the frame to which a reference must be returned.</param>
		/// <returns>A reference to the Led3dFrameLayer object at the given height.</returns>
		public Led3dFrameLayer GetLed3dFrameLayer(int heightIndex) {
			if (heightIndex >= 0 && heightIndex < Height) {
				return Led3dFrameLayers[heightIndex];
			} else {
				throw (new IndexOutOfRangeException("Tried to set pixel at height \"" + heightIndex + "\" of image with height \"" + Height + "\""));
			}
		}

		/// <summary>
		/// Adds the information contained within the Led3dFrame to a JObject.
		/// </summary>
		/// <returns>The populated JObject.</returns>
		public JObject ToJson() {
			JObject frame = new JObject();
			frame.Add(new JProperty("Width", Width));
			frame.Add(new JProperty("Length", Length));
			frame.Add(new JProperty("Height", Height));

			for (int heightIndex = 0; heightIndex < Height; heightIndex++) {
				JObject layerObject = Led3dFrameLayers[heightIndex].ToJson();
				layerObject.Remove("Width");
				layerObject.Remove("Length");
				frame.Add(new JProperty("Layer" + heightIndex, layerObject));
			}

			return frame;
		}
    }
}
