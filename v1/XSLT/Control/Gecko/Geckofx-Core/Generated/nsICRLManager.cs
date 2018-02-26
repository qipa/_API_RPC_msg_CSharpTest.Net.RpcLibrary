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
// Generated by IDLImporter from file nsICRLManager.idl
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
    ///-*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("486755db-627a-4678-a21b-f6a63bb9c56a")]
	public interface nsICRLManager
	{
		
		/// <summary>
        /// importCrl
        ///
        /// Import a CRL into the certificate database.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ImportCrl([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] data, uint length, [MarshalAs(UnmanagedType.Interface)] nsIURI uri, uint type, [MarshalAs(UnmanagedType.U1)] bool doSilentDownload, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string crlKey);
		
		/// <summary>
        /// update crl from url
        /// update an existing crl from the last fetched url. Needed for the update
        /// button in crl manager
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool UpdateCRLFromURL([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string url, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string key);
		
		/// <summary>
        /// getCrls
        ///
        /// Get a list of Crl entries in the DB.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetCrls();
		
		/// <summary>
        /// deleteCrl
        ///
        /// Delete the crl.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteCrl(uint crlIndex);
		
		/// <summary>
        ///This would reschedule the autoupdate of crls with auto update enable.
        /// Most likely to be called when update prefs are changed, or when a crl
        /// is deleted, etc. However, this might not be the most relevant place for
        /// this api, but unless we have a separate crl handler object....
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RescheduleCRLAutoUpdate();
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ComputeNextAutoUpdateTime([MarshalAs(UnmanagedType.Interface)] nsICRLInfo info, uint autoUpdateType, double noOfDays);
	}
	
	/// <summary>nsICRLManagerConsts </summary>
	public class nsICRLManagerConsts
	{
		
		// 
		public const ulong TYPE_AUTOUPDATE_TIME_BASED = 1;
		
		// 
		public const ulong TYPE_AUTOUPDATE_FREQ_BASED = 2;
	}
}
