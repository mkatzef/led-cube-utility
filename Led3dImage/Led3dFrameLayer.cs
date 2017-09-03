using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Led3dImage
{
	/// <summary>
	/// A single layer of a 3D image/frame. Allows individual pixels to be read and written.
	/// </summary>
	public class Led3dFrameLayer {
		private Boolean[,] PixelArray;

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

		/// <summary>
		/// Creates a blank 2D image with the given dimensions.
		/// </summary>
		/// <param name="width">The horizontal dimension of the image.</param>
		/// <param name="length">The vertical dimension of the image.</param>
		public Led3dFrameLayer(int width, int length) {
			if (width < 0) {
				throw (new ArgumentException("Negative width given."));
			}
			if (length < 0) {
				throw (new ArgumentException("Negative length given."));
			}
			
			Width = (UInt32) width;
			Length = (UInt32) length;
			PixelArray = new bool[width, length];
		}

		/// <summary>
		/// Assigns the given value to the pixel at the given index, where 0,0 is top-left.
		/// </summary>
		/// <param name="colIndex">The pixel index in the horizontal direction.</param>
		/// <param name="rowIndex">The pixel index in the vertical direction.</param>
		/// <param name="value">A boolean - true to enable the pixel, false to disable it (default).</param>
		public void SetPixel(int colIndex, int rowIndex, bool value) {
			if (rowIndex >= 0 && rowIndex < Length) {
				if (colIndex >= 0 && colIndex < Width) {
					PixelArray[colIndex, rowIndex] = value;
				} else {
					throw (new IndexOutOfRangeException("Tried to set pixel at index (" + colIndex + ", " + rowIndex + ") of layer with size (" + Width + ", " + Length + ")"));
				}
			}
		}

		/// <summary>
		/// Gets the current value of the pixel at the given index, where 0,0 is top-left.
		/// </summary>
		/// <param name="colIndex">The pixel index in the horizontal direction.</param>
		/// <param name="rowIndex">The pixel index in the vertical direction.</param>
		/// <returns>A boolean - true if the pixel was enabled, false if disabled.</returns>
		public bool GetPixel(int colIndex, int rowIndex) {
			bool validIndex = false;
			bool result = false;
			if (rowIndex >= 0 && rowIndex < Length) {
				if (colIndex >= 0 && colIndex < Width) {
					validIndex = true;
					result = PixelArray[colIndex, rowIndex];
				}
			}

			if (validIndex) {
				return result;
			} else {
				throw (new IndexOutOfRangeException("Tried to get pixel at index (" + colIndex + ", " + rowIndex + ") of layer with size (" + Width + ", " + Length + ")"));
			}
		}

		/// <summary>
		/// Adds the information contained within the Led3dFrameLayer to a JObject.
		/// </summary>
		/// <returns>The populated JObject.</returns>
		public JObject ToJson() {
			JObject jo = new JObject();
			jo.Add(new JProperty("Width", Width));
			jo.Add(new JProperty("Length", Length));

			JArray image = new JArray();
			for (int rowIndex = 0; rowIndex < Length; rowIndex++) {
				JArray row = new JArray();
				for (int colIndex = 0; colIndex < Width; colIndex++) {
					row.Add(PixelArray[colIndex, rowIndex]);
				}
				image.Add(row);
			}

			jo.Add(new JProperty("Image", image));

			return jo;
		}
	}
}
