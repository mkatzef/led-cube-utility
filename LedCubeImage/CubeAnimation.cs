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
			blankUnit.frame = new CubeFrame(width, length, height);
			blankUnit.durationMillis = 1000;
			AnimationUnits.Add(new AnimationUnit());
		}
		
		/// <summary>
		/// A structure to group image information and the length of time for
		/// which it must be displayed.
		/// </summary>
		struct AnimationUnit {
			public CubeFrame frame;
			public UInt32 durationMillis;
		}

		/// <summary>
		/// Returns the length of the animation object's frame list.
		/// </summary>
		/// <returns>The number of frames in the animation.</returns>
		public int GetFrameCount() {
			return AnimationUnits.Count();
		}

		/// <summary>
		/// Removes the frame at the given index. Cannot be recovered.
		/// </summary>
		/// <param name="index">The index (in [0, animation length - 1]) of the frame to remove.</param>
		public void DelFrame(int index) {
			if (index >= 0 && index < AnimationUnits.Count()) {
				AnimationUnits.RemoveAt(index);
			}
		}

		/// <summary>
		/// Returns the reference to the frame object at the given index, for direct manipulation.
		/// </summary>
		/// <param name="index">The index (in [0, animation length - 1]) of the frame to return.</param>
		/// <returns>The frame of the animation object at the given index. Relies on C#'s pass by
		/// reference for non-primitive classes.</returns>
		public CubeFrame GetFrame(int index) {
			if (index >= 0 && index < AnimationUnits.Count()) {
				return AnimationUnits[index].frame;
			} else {
				throw (new IndexOutOfRangeException("Asked for frame at index \"" + index + "\" of a " + AnimationUnits.Count() + " frame long animation."));
			}
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
