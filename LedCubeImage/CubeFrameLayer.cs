using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LedCubeImage {
	public class CubeFrameLayer {
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
		/// Creates a balnk 2D image with the given dimensions.
		/// </summary>
		/// <param name="width">The horizontal dimension of the image.</param>
		/// <param name="length">The vertical dimension of the image.</param>
		public CubeFrameLayer(UInt32 width, UInt32 length) {
			Width = width;
			Length = length;
			PixelArray = new bool[width, length];
		}

		public void SetPixel(int colIndex, int rowIndex, bool value) {
			if (rowIndex >= 0 && rowIndex < Length) {
				if (colIndex >= 0 && colIndex < Width) {
					PixelArray[colIndex, rowIndex] = value;
				}
			}
		}

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
				throw (new IndexOutOfRangeException("Tried to access index (" + colIndex + ", " + rowIndex + ") of index with size (" + Width + ", " + Length + ")"));
			}
		}
	}
}
