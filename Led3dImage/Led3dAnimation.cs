﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace Led3dImage
{
	/// <summary>
	/// A collection of 3D images and corresponding durations.
	/// </summary>
    public class Led3dAnimation
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
		/// Initializes a new Led3dAnimation object with the given dimensions.
		/// Starts with a single, blank frame with duration of 1 second.
		/// </summary>
		/// <param name="width"></param>
		/// <param name="length"></param>
		/// <param name="height"></param>
        public Led3dAnimation(int width, int length, int height)
        {
			if (width < 0) {
				throw (new ArgumentException("Negative width given."));
			}
			if (length < 0) {
				throw (new ArgumentException("Negative length given."));
			}
			if (height < 0) {
				throw (new ArgumentException("Negative height given."));
			}

			Width = (UInt32)width;
			Length = (UInt32)length;
			Height = (UInt32)height;

			AnimationUnits = new List<AnimationUnit>();
			AnimationUnit blankUnit = new AnimationUnit();
			blankUnit.frame = new Led3dFrame(width, length, height);
			blankUnit.durationMillis = 1000;
			AnimationUnits.Add(blankUnit);
		}
		
		/// <summary>
		/// A structure to group image information and the length of time for
		/// which it must be displayed.
		/// </summary>
		struct AnimationUnit {
			public Led3dFrame frame;
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
		/// Adds a frame at the given index.
		/// </summary>
		/// <param name="index">The index (in [0, animation length]) of the frame to be added.</param>
		public void AddFrame(int index) {
			if (index >= 0 && index <= AnimationUnits.Count()) {
				AnimationUnit blankUnit = new AnimationUnit();
				blankUnit.frame = new Led3dFrame((int) Width, (int) Length, (int) Height);
				blankUnit.durationMillis = 1000;
				AnimationUnits.Insert(index, blankUnit);
			}
		}

		/// <summary>
		/// Sets the amount of time for which the specified frame should be displayed in a looped animation.
		/// </summary>
		/// <param name="index">The index (in [0, animation length - 1]) of the frame to be modified.</param>
		/// <param name="durationMillis">The amount of time (in milliseconds) to display the specified frame.</param>
		public void SetFrameDuration(int index, int durationMillis) {
			if (index >= 0 && index < AnimationUnits.Count()) {
				AnimationUnit tempAU = AnimationUnits[index];
				tempAU.durationMillis = (uint)durationMillis;
				AnimationUnits[index] = tempAU;
			}
		}

		/// <summary>
		/// Returns the amount of time for which the specified frame would be displayed in a looped animation.
		/// </summary>
		/// <param name="index">The index (in [0, animation length - 1]) of the queried frame.</param>
		/// <returns>The amount of time (in milliseconds) for which the specified frame would be displayed.</param>
		public uint GetFrameDuration(int index) {
			if (index >= 0 && index < AnimationUnits.Count()) {
				return AnimationUnits[index].durationMillis;
			} else {
				return 0;
			}
		}

		/// <summary>
		/// Returns the reference to the frame object at the given index, for direct manipulation.
		/// </summary>
		/// <param name="index">The index (in [0, animation length - 1]) of the frame to return.</param>
		/// <returns>The frame of the animation object at the given index. Relies on C#'s pass by
		/// reference for non-primitive classes.</returns>
		public Led3dFrame GetFrame(int index) {
			if (index >= 0 && index < AnimationUnits.Count()) {
				return AnimationUnits[index].frame;
			} else {
				throw (new IndexOutOfRangeException("Asked for frame at index \"" + index + "\" of a " + AnimationUnits.Count() + " frame long animation."));
			}
		}

		/// <summary>
		/// Adds the information contained within the Led3dAnimation to a JObject.
		/// </summary>
		/// <returns>The populated JObject.</returns>
		public JObject ToJson() {
			JObject animation = new JObject();
			animation.Add(new JProperty("Width", Width));
			animation.Add(new JProperty("Length", Length));
			animation.Add(new JProperty("Height", Height));
			animation.Add(new JProperty("FrameCount", AnimationUnits.Count));

			int frameIndex = 0;
			foreach (AnimationUnit au in AnimationUnits) {
				JObject auFrameObject = au.frame.ToJson();
				auFrameObject.Remove("Width");
				auFrameObject.Remove("Length");
				auFrameObject.Remove("Height");
				auFrameObject.Add(new JProperty("Duration", au.durationMillis));

				animation.Add(new JProperty("Frame" + frameIndex, auFrameObject));
				frameIndex++;
			}

			return animation;
		}
		
		public Led3dAnimation(JObject jsonAnimation) {
			Width = (uint)jsonAnimation.SelectToken("Width");
			Length = (uint)jsonAnimation.SelectToken("Length");
			Height = (uint)jsonAnimation.SelectToken("Height");
			int frameCount = (int)jsonAnimation.SelectToken("FrameCount");
			AnimationUnits = new List<AnimationUnit>();

			for (int frameIndex = 0; frameIndex < frameCount; frameIndex++) {
				JObject auFrameObject = (JObject)jsonAnimation.SelectToken("Frame" + frameIndex);
				AnimationUnit au = new AnimationUnit();

				au.durationMillis = (uint)auFrameObject.SelectToken("Duration");
				auFrameObject.Remove("Duration");
				auFrameObject.Add(new JProperty("Width", Width));
				auFrameObject.Add(new JProperty("Length", Length));
				auFrameObject.Add(new JProperty("Height", Height));
				au.frame = new Led3dFrame(auFrameObject);
				AnimationUnits.Add(au);
			}
		}

		private void AddUInt32(ArrayList a, uint entry) {
			for (int i = 3; i >= 0; i--) {
				byte portion = (byte)((entry >> (8 * i)) & 0xFF);
				a.Add(portion);
			}
		}

		/// <summary>
		/// Returns a packaged version of the animation, suitable for transfer to a 3D LED display.
		/// </summary>
		/// <returns>A bytes object representing the animation.</returns>
		public byte[] ToBytes() {
			uint stride = Width / 8;
			if (Width % 8 != 0) {
				stride++;
			}

			int frameCount = GetFrameCount();

			ArrayList animationAsBytes = new ArrayList();

			AddUInt32(animationAsBytes, Width);
			AddUInt32(animationAsBytes, Length);
			AddUInt32(animationAsBytes, Height);
			AddUInt32(animationAsBytes, (uint)frameCount);

			for (int i = 0; i < frameCount; i++) {
				AddUInt32(animationAsBytes, GetFrameDuration(i));
			}

			foreach (AnimationUnit au in AnimationUnits) {
				Led3dFrame frame = au.frame;
				for (int heightIndex = 0; heightIndex < Height; heightIndex++) {
					Led3dFrameLayer layer = frame.GetLed3dFrameLayer(heightIndex);
					for (int rowIndex = 0; rowIndex < Length; rowIndex++) {
						int bytesCounted = 0;
						byte newByte = 0;
						int position = 0;
						ArrayList buffer = new ArrayList();
						for (int colIndex = 0; colIndex < Width; colIndex++) {
							if (layer.GetPixel(colIndex, rowIndex)) {
								newByte |= (byte)(1 << position);
							}
							position++;

							if (position >= 8) {
								buffer.Insert(0, newByte);
								newByte = 0;
								position = 0;
								bytesCounted++;
							}
						}

						if (bytesCounted < stride) {
							buffer.Insert(0, newByte);
						}

						animationAsBytes.AddRange(buffer);
					}
				}
			}

			return (byte[])animationAsBytes.ToArray(typeof(byte));
		}
	}
}
