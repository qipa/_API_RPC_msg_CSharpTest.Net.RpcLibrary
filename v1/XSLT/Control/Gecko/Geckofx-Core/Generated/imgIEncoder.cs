// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file imgIEncoder.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// imgIEncoder interface
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4baa2d6e-fee7-42df-ae3f-5fbebc0c267c")]
	public interface imgIEncoder : nsIAsyncInputStream
	{
		
		/// <summary>
        /// Close the stream.  This method causes subsequent calls to Read and
        /// ReadSegments to return 0 bytes read to indicate end-of-file.  Any
        /// subsequent calls to Available should throw NS_BASE_STREAM_CLOSED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close();
		
		/// <summary>
        /// Determine number of bytes available in the stream.  A non-blocking
        /// stream that does not yet have any data to read should return 0 bytes
        /// from this method (i.e., it must not throw the NS_BASE_STREAM_WOULD_BLOCK
        /// exception).
        ///
        /// In addition to the number of bytes available in the stream, this method
        /// also informs the caller of the current status of the stream.  A stream
        /// that is closed will throw an exception when this method is called.  That
        /// enables the caller to know the condition of the stream before attempting
        /// to read from it.  If a stream is at end-of-file, but not closed, then
        /// this method returns 0 bytes available.  (Note: some nsIInputStream
        /// implementations automatically close when eof is reached; some do not).
        ///
        /// @return number of bytes currently available in the stream, or
        /// PR_UINT32_MAX if the size of the stream exceeds PR_UINT32_MAX.
        ///
        /// @throws NS_BASE_STREAM_CLOSED if the stream is closed normally.
        /// @throws <other-error> if the stream is closed due to some error
        /// condition
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint Available();
		
		/// <summary>
        /// Read data from the stream.
        ///
        /// @param aBuf the buffer into which the data is to be read
        /// @param aCount the maximum number of bytes to be read
        ///
        /// @return number of bytes read (may be less than aCount).
        /// @return 0 if reached end-of-file
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if reading from the input stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        ///
        /// NOTE: this method should not throw NS_BASE_STREAM_CLOSED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint Read(System.IntPtr aBuf, uint aCount);
		
		/// <summary>
        /// Low-level read method that provides access to the stream's underlying
        /// buffer.  The writer function may be called multiple times for segmented
        /// buffers.  ReadSegments is expected to keep calling the writer until
        /// either there is nothing left to read or the writer returns an error.
        /// ReadSegments should not call the writer with zero bytes to consume.
        ///
        /// @param aWriter the "consumer" of the data to be read
        /// @param aClosure opaque parameter passed to writer
        /// @param aCount the maximum number of bytes to be read
        ///
        /// @return number of bytes read (may be less than aCount)
        /// @return 0 if reached end-of-file (or if aWriter refused to consume data)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if reading from the input stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws NS_ERROR_NOT_IMPLEMENTED if the stream has no underlying buffer
        /// @throws <other-error> on failure
        ///
        /// NOTE: this function may be unimplemented if a stream has no underlying
        /// buffer (e.g., socket input stream).
        ///
        /// NOTE: this method should not throw NS_BASE_STREAM_CLOSED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint ReadSegments(nsWriteSegmentFun aWriter, System.IntPtr aClosure, uint aCount);
		
		/// <summary>
        /// @return true if stream is non-blocking
        ///
        /// NOTE: reading from a blocking input stream will block the calling thread
        /// until at least one byte of data can be extracted from the stream.
        ///
        /// NOTE: a non-blocking input stream may implement nsIAsyncInputStream to
        /// provide consumers with a way to wait for the stream to have more data
        /// once its read method is unable to return any data without blocking.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsNonBlocking();
		
		/// <summary>
        /// This method closes the stream and sets its internal status.  If the
        /// stream is already closed, then this method is ignored.  Once the stream
        /// is closed, the stream's status cannot be changed.  Any successful status
        /// code passed to this method is treated as NS_BASE_STREAM_CLOSED, which
        /// has an effect equivalent to nsIInputStream::close.
        ///
        /// NOTE: this method exists in part to support pipes, which have both an
        /// input end and an output end.  If the input end of a pipe is closed, then
        /// writes to the output end of the pipe will fail.  The error code returned
        /// when an attempt is made to write to a "broken" pipe corresponds to the
        /// status code passed in when the input end of the pipe was closed, which
        /// greatly simplifies working with pipes in some cases.
        ///
        /// @param aStatus
        /// The error that will be reported if this stream is accessed after
        /// it has been closed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CloseWithStatus(int aStatus);
		
		/// <summary>
        /// Asynchronously wait for the stream to be readable or closed.  The
        /// notification is one-shot, meaning that each asyncWait call will result
        /// in exactly one notification callback.  After the OnInputStreamReady event
        /// is dispatched, the stream releases its reference to the
        /// nsIInputStreamCallback object.  It is safe to call asyncWait again from the
        /// notification handler.
        ///
        /// This method may be called at any time (even if read has not been called).
        /// In other words, this method may be called when the stream already has
        /// data to read.  It may also be called when the stream is closed.  If the
        /// stream is already readable or closed when AsyncWait is called, then the
        /// OnInputStreamReady event will be dispatched immediately.  Otherwise, the
        /// event will be dispatched when the stream becomes readable or closed.
        ///
        /// @param aCallback
        /// This object is notified when the stream becomes ready.  This
        /// parameter may be null to clear an existing callback.
        /// @param aFlags
        /// This parameter specifies optional flags passed in to configure
        /// the behavior of this method.  Pass zero to specify no flags.
        /// @param aRequestedCount
        /// Wait until at least this many bytes can be read.  This is only
        /// a suggestion to the underlying stream; it may be ignored.  The
        /// caller may pass zero to indicate no preference.
        /// @param aEventTarget
        /// Specify NULL to receive notification on ANY thread (possibly even
        /// recursively on the calling thread -- i.e., synchronously), or
        /// specify that the notification be delivered to a specific event
        /// target.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AsyncWait([MarshalAs(UnmanagedType.Interface)] nsIInputStreamCallback aCallback, uint aFlags, uint aRequestedCount, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aEventTarget);
		
		/// <summary>
        ///data - list of bytes in the format specified by inputFormat
        /// width  - width in pixels
        /// height - height in pixels
        /// stride - number of bytes per row in the image
        /// Normally (width*3) or (width*4), depending on your input format,
        /// but some data uses padding at the end of each row, which would
        /// be extra.
        /// inputFormat - one of INPUT_FORMAT_* specifying the format of data
        /// outputOptions - semicolon-delimited list of name=value pairs that can
        /// give options to the output encoder. Options are encoder-
        /// specific. Just give empty string for default behavior.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitFromData([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] data, uint length, uint width, uint height, uint stride, uint inputFormat, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase outputOptions);
		
		/// <summary>
        /// For encoding images which may contain multiple frames, the 1-shot
        /// initFromData() interface is too simplistic. The alternative is to
        /// use startImageEncode(), call addImageFrame() one or more times, and
        /// then finish initialization with endImageEncode().
        ///
        /// The arguments are basically the same as in initFromData().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartImageEncode(uint width, uint height, uint inputFormat, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase outputOptions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddImageFrame([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] data, uint length, uint width, uint height, uint stride, uint frameFormat, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase frameOptions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndImageEncode();
		
		/// <summary>
        /// Sometimes an encoder can contain another encoder and direct access
        /// to its buffer is necessary.   It is only safe to assume that the buffer
        /// returned from getImageBuffer() is of size equal to getImageBufferUsed().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetImageBufferUsed();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetImageBuffer();
	}
	
	/// <summary>imgIEncoderConsts </summary>
	public class imgIEncoderConsts
	{
		
		// <summary>
        // R, G, and B (in that order, regardless of host endianness)
        // </summary>
		public const long INPUT_FORMAT_RGB = 0;
		
		// <summary>
        // POST-MULTIPLIED alpha us used (50% transparent red is 0xff000080)
        // </summary>
		public const long INPUT_FORMAT_RGBA = 1;
		
		// <summary>
        // not 0x80ff0000
        // </summary>
		public const long INPUT_FORMAT_HOSTARGB = 2;
	}
}
