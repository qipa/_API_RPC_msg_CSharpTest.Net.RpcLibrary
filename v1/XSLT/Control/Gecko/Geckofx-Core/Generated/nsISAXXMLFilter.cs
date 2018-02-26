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
// Generated by IDLImporter from file nsISAXXMLFilter.idl
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
    /// Interface for an XML filter.
    ///
    /// An XML filter is like an XML reader, except that it obtains its
    /// events from another XML reader rather than a primary source like an
    /// XML document or database.  Filters can modify a stream of events as
    /// they pass on to the final application.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("77a22cf0-6cdf-11da-be43-001422106990")]
	public interface nsISAXXMLFilter : nsISAXXMLReader
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// If that number is greater than or equal to 2^32, this parameter
        /// will be PR_UINT32_MAX (2^32 - 1).
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, uint aOffset, uint aCount);
		
		/// <summary>
        /// The base URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI GetBaseURIAttribute();
		
		/// <summary>
        /// The base URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// If the application does not register a content handler, all
        /// content events reported by the SAX parser will be silently
        /// ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISAXContentHandler GetContentHandlerAttribute();
		
		/// <summary>
        /// If the application does not register a content handler, all
        /// content events reported by the SAX parser will be silently
        /// ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContentHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXContentHandler aContentHandler);
		
		/// <summary>
        /// If the application does not register a DTD handler, all DTD
        /// events reported by the SAX parser will be silently ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISAXDTDHandler GetDtdHandlerAttribute();
		
		/// <summary>
        /// If the application does not register a DTD handler, all DTD
        /// events reported by the SAX parser will be silently ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDtdHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXDTDHandler aDtdHandler);
		
		/// <summary>
        /// If the application does not register an error handler, all
        /// error events reported by the SAX parser will be silently ignored;
        /// however, normal processing may not continue.  It is highly
        /// recommended that all SAX applications implement an error handler
        /// to avoid unexpected bugs.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISAXErrorHandler GetErrorHandlerAttribute();
		
		/// <summary>
        /// If the application does not register an error handler, all
        /// error events reported by the SAX parser will be silently ignored;
        /// however, normal processing may not continue.  It is highly
        /// recommended that all SAX applications implement an error handler
        /// to avoid unexpected bugs.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetErrorHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXErrorHandler aErrorHandler);
		
		/// <summary>
        /// If the application does not register a lexical handler, all
        /// lexical events (e.g. startDTD) reported by the SAX parser will be
        /// silently ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISAXLexicalHandler GetLexicalHandlerAttribute();
		
		/// <summary>
        /// If the application does not register a lexical handler, all
        /// lexical events (e.g. startDTD) reported by the SAX parser will be
        /// silently ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLexicalHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXLexicalHandler aLexicalHandler);
		
		/// <summary>
        /// Set the value of a feature flag. NOT CURRENTLY IMPLEMENTED.
        ///
        /// The feature name is any fully-qualified URI.  It is possible
        /// for an XMLReader to expose a feature value but to be unable to
        /// change the current value.  Some feature values may be immutable
        /// or mutable only in specific contexts, such as before, during, or
        /// after a parse.
        ///
        /// All XMLReaders are required to support setting
        /// http://xml.org/sax/features/namespaces to true and
        /// http://xml.org/sax/features/namespace-prefixes to false.
        ///
        /// @param name String flag for a parser feature.
        /// @param value Turn the feature on/off.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFeature([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.U1)] bool value);
		
		/// <summary>
        /// Look up the value of a feature flag. NOT CURRENTLY IMPLEMENTED.
        ///
        /// The feature name is any fully-qualified URI.  It is
        /// possible for an XMLReader to recognize a feature name but
        /// temporarily be unable to return its value.
        /// Some feature values may be available only in specific
        /// contexts, such as before, during, or after a parse.
        ///
        /// All XMLReaders are required to recognize the
        /// http://xml.org/sax/features/namespaces and the
        /// http://xml.org/sax/features/namespace-prefixes feature names.
        ///
        /// @param name String flag for a parser feature.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetFeature([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        /// Set the value of a property. NOT CURRENTLY IMPLEMENTED.
        ///
        /// The property name is any fully-qualified URI.  It is possible
        /// for an XMLReader to recognize a property name but to be unable to
        /// change the current value.  Some property values may be immutable
        /// or mutable only in specific contexts, such as before, during, or
        /// after a parse.
        ///
        /// XMLReaders are not required to recognize setting any specific
        /// property names, though a core set is defined by SAX2.
        ///
        /// This method is also the standard mechanism for setting
        /// extended handlers.
        ///
        /// @param name String flag for a parser feature
        /// @param value Turn the feature on/off.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsISupports value);
		
		/// <summary>
        /// Look up the value of a property. NOT CURRENTLY IMPLEMENTED.
        ///
        /// The property name is any fully-qualified URI.  It is
        /// possible for an XMLReader to recognize a property name but
        /// temporarily be unable to return its value.
        /// Some property values may be available only in specific
        /// contexts, such as before, during, or after a parse.
        ///
        /// XMLReaders are not required to recognize any specific
        /// property names, though an initial core set is documented for
        /// SAX2.
        ///
        /// Implementors are free (and encouraged) to invent their own properties,
        /// using names built on their own URIs.
        ///
        /// @param name The property name, which is a fully-qualified URI.
        /// @return The current value of the property.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        ///
        /// @param str The UTF16 string to be parsed
        /// @param contentType The content type of the string (see parseFromStream)
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ParseFromString([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase str, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        ///
        /// @param stream The byte stream whose contents are parsed
        /// @param charset The character set that was used to encode the byte
        /// stream. NULL if not specified.
        /// @param contentType The content type of the string - either text/xml,
        /// application/xml, or application/xhtml+xml.
        /// Must not be NULL.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        /// Begin an asynchronous parse. This method initializes the parser,
        /// and must be called before any nsIStreamListener methods. It is
        /// then the caller's duty to call nsIStreamListener methods to drive
        /// the parser. Once this method is called, the caller must not call
        /// one of the other parse methods.
        ///
        /// @param observer The nsIRequestObserver to notify upon start or stop.
        /// Can be NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver observer);
		
		/// <summary>
        /// The parent reader.
        ///
        /// Allows the application to query the parent reader (which may be
        /// another filter).  It is generally a bad idea to perform any
        /// operations on the parent reader directly: they should all pass
        /// through this filter.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXXMLReader GetParentAttribute();
		
		/// <summary>
        /// The parent reader.
        ///
        /// Allows the application to query the parent reader (which may be
        /// another filter).  It is generally a bad idea to perform any
        /// operations on the parent reader directly: they should all pass
        /// through this filter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXXMLReader aParent);
	}
}
