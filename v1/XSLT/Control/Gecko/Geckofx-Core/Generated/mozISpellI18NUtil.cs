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
// Generated by IDLImporter from file mozISpellI18NUtil.idl
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
    /// This interface contains various I18N related code used in various places by the spell checker.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B075D5DC-1DF1-441A-BEBF-680D8CAAA19C")]
	public interface mozISpellI18NUtil
	{
		
		/// <summary>
        /// The language being used to check spelling
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetLanguageAttribute();
		
		/// <summary>
        /// Given a word return a list of possible root forms of that word
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRootForm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, uint type, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] ref System.IntPtr[] words, ref uint count);
		
		/// <summary>
        /// Given a word return a list of possible root forms of that word
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FromRootForm([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] System.IntPtr[] iwords, uint icount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=4)] ref System.IntPtr[] owords, ref uint ocount);
		
		/// <summary>
        /// Given a unicode string and an offset, find the beginning and end of the
        /// next word. begin and end are -1 if there are no words remaining in the
        /// string. This should really be folded into the Line/WordBreaker.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FindNextWord([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string word, uint length, uint offset, ref int begin, ref int end);
	}
	
	/// <summary>mozISpellI18NUtilConsts </summary>
	public class mozISpellI18NUtilConsts
	{
		
		// <summary>
        // This interface contains various I18N related code used in various places by the spell checker.
        // </summary>
		public const long kCheck = 0;
		
		// 
		public const long kSuggest = 1;
	}
}
