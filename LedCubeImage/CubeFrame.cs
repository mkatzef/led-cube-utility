using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LedCubeImage
{
    public class CubeFrame
    {
		private List<CubeFrameLayer> CubeFrameLayers;
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

		public CubeFrame(UInt32 width, UInt32 length, UInt32 height) {
			Width = width;
			Length = length;
			Height = height;
			for (int i = 0; i < height; i++) {
				CubeFrameLayers.Add(new CubeFrameLayer(width, length));
			}
		}


    }
}
