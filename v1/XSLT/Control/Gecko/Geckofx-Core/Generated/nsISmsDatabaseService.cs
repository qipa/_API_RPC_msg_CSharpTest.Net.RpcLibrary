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
// Generated by IDLImporter from file nsISmsDatabaseService.idl
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
	[Guid("30e8cdfb-155d-44c7-8fb3-6bcd9c1c3f99")]
	public interface nsISmsDatabaseService
	{
		
		/// <summary>
        /// Takes some information required to save the message and returns its id.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int SaveReceivedMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSender, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBody, ulong aDate);
		
		/// <summary>
        /// Takes some information required to save the message and returns its id.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int SaveSentMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReceiver, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBody, ulong aDate);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMessage(int messageId, int requestId, ulong processId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteMessage(int messageId, int requestId, ulong processId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateMessageList([MarshalAs(UnmanagedType.Interface)] nsIDOMMozSmsFilter filter, [MarshalAs(UnmanagedType.U1)] bool reverse, int requestId, ulong processId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNextMessageInList(int listId, int requestId, ulong processId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearMessageList(int listId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkMessageRead(int messageId, [MarshalAs(UnmanagedType.U1)] bool value, int requestId, ulong processId);
	}
}
