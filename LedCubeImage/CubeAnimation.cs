using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace LedCubeImage
{
    public class CubeAnimation
    {
		private List<AnimationUnit> AnimationUnits;
		private UInt32 Width;
		private UInt32 Length;
		private UInt32 Height;

		/// <summary>
		/// Initializes a new CubeAnimation object with the given cube dimensions.
		/// Starts with a single, blank frame with duration of 1 second.
		/// </summary>
		/// <param name="width"></param>
		/// <param name="length"></param>
		/// <param name="height"></param>
        public CubeAnimation(UInt32 width, UInt32 length, UInt32 height)
        {
			Width = width;
			Length = length;
			Height = height;
			AnimationUnits = new List<AnimationUnit>();
			AnimationUnit blankUnit = new AnimationUnit();
			blankUnit.frame = new CubeFrame();
			blankUnit.durationMillis = 1000;
			AnimationUnits.Add(new AnimationUnit());
		}
		
		struct AnimationUnit {
			public CubeFrame frame;
			public UInt32 durationMillis;
		}

		/// <summary>
		/// Generates a serialized form of the cube animation.
		/// </summary>
		/// <returns>The JSON representation of the LED Cube Animation.</returns>
		public String ToJson() {
			throw(new NotImplementedException("ToJson"));
		}

		/// <summary>
		/// Parses a given string for CubeAnimation parameters.
		/// </summary>
		/// <param name="jsonString">A string containing a CubeAnimation object serialized as JSON.</param>
		/// <returns>The CubeAnimation object described by the given string.</returns>
		static CubeAnimation FromJson(String jsonString) {
			throw (new NotImplementedException("FromJson"));
		}
    }
}
