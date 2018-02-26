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
// Generated by IDLImporter from file nsIMozBrowserFrame.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6f043e42-02c9-4e8f-8f8d-1b83c6102827")]
	public interface nsIMozBrowserFrame : nsIDOMMozBrowserFrame
	{
		
		/// <summary>
        /// <iframe> and <frame> elements may have the mozbrowser attribute.
        ///
        /// The mozbrowser attribute has no effect unless the <iframe> or <frame>
        /// element is contained in a document privileged to create browser frames.
        ///
        /// An <iframe> or <frame> element in a privileged document with the mozbrowser
        /// attribute emits a variety of events when various things happen inside the
        /// frame.
        ///
        /// This will be documented eventually, but for more information at the moment,
        /// see dom/browser-element/BrowserElement{Child,Parent}.js.
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetMozbrowserAttribute();
		
		/// <summary>
        /// <iframe> and <frame> elements may have the mozbrowser attribute.
        ///
        /// The mozbrowser attribute has no effect unless the <iframe> or <frame>
        /// element is contained in a document privileged to create browser frames.
        ///
        /// An <iframe> or <frame> element in a privileged document with the mozbrowser
        /// attribute emits a variety of events when various things happen inside the
        /// frame.
        ///
        /// This will be documented eventually, but for more information at the moment,
        /// see dom/browser-element/BrowserElement{Child,Parent}.js.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetMozbrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aMozbrowser);
		
		/// <summary>
        /// Gets whether this frame really is a browser or app frame.
        ///
        /// In order to really be a browser frame, this frame's
        /// nsIDOMMozBrowserFrame::mozbrowser attribute must be true, and the frame
        /// may have to pass various security checks.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReallyIsBrowserAttribute();
		
		/// <summary>
        /// Gets whether this frame really is an app frame.
        ///
        /// In order to really be an app frame, this frame must really be a browser
        /// frame (this requirement will go away eventually), and the frame's mozapp
        /// attribute must point to the manifest of a valid app.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReallyIsAppAttribute();
		
		/// <summary>
        /// Gets this frame's app manifest URL, if the frame really is an app frame.
        /// Otherwise, returns the empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppManifestURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAppManifestURL);
		
		/// <summary>
        /// Normally, a frame tries to create its frame loader when its src is
        /// modified, or its contentWindow is accessed.
        ///
        /// disallowCreateFrameLoader prevents the frame element from creating its
        /// frame loader (in the same way that not being inside a document prevents the
        /// creation of a frame loader).  allowCreateFrameLoader lifts this restriction.
        ///
        /// These methods are not re-entrant -- it is an error to call
        /// disallowCreateFrameLoader twice without first calling allowFrameLoader.
        ///
        /// It's also an error to call either method if we already have a frame loader.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisallowCreateFrameLoader();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AllowCreateFrameLoader();
		
		/// <summary>
        /// Create a remote (i.e., out-of-process) frame loader attached to the given
        /// tab parent.
        ///
        /// It is an error to call this method if we already have a frame loader.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateRemoteFrameLoader([MarshalAs(UnmanagedType.Interface)] nsITabParent aTabParent);
	}
}