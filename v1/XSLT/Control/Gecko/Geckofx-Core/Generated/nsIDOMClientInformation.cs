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
// Generated by IDLImporter from file nsIDOMClientInformation.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f8bbf8c3-c47b-465a-a221-22824449f689")]
	public interface nsIDOMClientInformation
	{
		
		/// <summary>
        /// Web Applications 1.0 Browser State: registerContentHandler
        /// Allows web services to register themselves as handlers for certain content
        /// types.
        /// http://whatwg.org/specs/web-apps/current-work/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterContentHandler([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase mimeType, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase title);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterProtocolHandler([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase protocol, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase title);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MozIsLocallyAvailable([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri, [MarshalAs(UnmanagedType.U1)] bool whenOffline);
	}
}
