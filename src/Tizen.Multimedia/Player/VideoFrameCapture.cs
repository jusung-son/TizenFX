﻿/// VideoFrameCapture
///
/// Copyright 2016 by Samsung Electronics, Inc.,
///
/// This software is the confidential and proprietary information
/// of Samsung Electronics, Inc. ("Confidential Information"). You
/// shall not disclose such Confidential Information and shall use
/// it only in accordance with the terms of the license agreement
/// you entered into with Samsung.

using System;

namespace Tizen.Multimedia
{
    /// <summary>
    /// VideoFrameCapture
    /// </summary>
    /// <remarks>
    /// VideoSize class provides properties of a captured video frame
    /// </remarks>
    public class VideoFrameCapture
    {

        /// <summary>
        /// Get/Set ImageBuffer.
        /// </summary>
        /// <value> Image buffer </value>
        public byte[] ImageBuffer 
		{
			set
			{
				_imageBuffer = value;
			}
			get
			{
				return _imageBuffer;
			}
		}

        /// <summary>
        /// Get/Set width.
        /// </summary>
        /// <value> Image width </value>
        public int Width 
		{
			set
			{
				_width = value;
			}
			get
			{
				return _width;
			}
		}

        /// <summary>
        /// Get/Set height.
        /// </summary>
        /// <value> Image Height </value>
        public int Height 
		{
			set
			{
				_height = value;
			}
			get
			{
				return _height;
			}
		}

        /// <summary>
        /// Get/Set Size.
        /// </summary>
        /// <value> Size of the image </value>
        public uint Size 
		{
			set
			{
				_size = value;
			}
			get
			{
				return _size;
			}
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public VideoFrameCapture(byte[] imageBuffer, int width, int height, uint size)
		{
			_imageBuffer = imageBuffer;
			_width = width;
			_height = height;
			_size = size;
		}


		internal byte[] _imageBuffer;
		internal int _width;
		internal int _height;
		internal uint _size;
    }
}
