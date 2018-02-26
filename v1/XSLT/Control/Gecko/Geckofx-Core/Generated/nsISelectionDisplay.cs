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
// Generated by IDLImporter from file nsISelectionDisplay.idl
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
    ///-*- Mode: IDL; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 2 -*-
    ///
    /// This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0DDF9E1C-1DD2-11B2-A183-908A08AA75AE")]
	public interface nsISelectionDisplay
	{
		
		/// <summary>
        ///SetSelectionFlags used to set whether you want to see HRULES/IMAGES with border.
        ///    also used to tell if the presshell is an editor right now. this should change
        ///
        ///    @param aToggle -either DISPLAY_(TEXT,IMAGES,FRAMES,ALL)
        ///                    This will tell the rendering engine to draw the different
        ///                    selection types.
        ///    @return NS_OK if successful.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionFlags(short toggle);
		
		/// <summary>
        ///GetSelectionFlags used to get whether you want to see HRULES/IMAGES with border.
        ///    also used to tell if the presshell is an editor right now. this should change
        ///
        ///    @param short *aReturn - This will be filled with DISPLAY_(TEXT,IMAGE,FRAMES,ALL)
        ///                            bit flags.
        ///    @return NS_OK if successful.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetSelectionFlags();
	}
	
	/// <summary>nsISelectionDisplayConsts </summary>
	public class nsISelectionDisplayConsts
	{
		
		// <summary>
        //-*- Mode: IDL; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 2 -*-
        //
        // This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const int DISPLAY_TEXT = 1;
		
		// <summary>
        //display text selected.
        // </summary>
		public const int DISPLAY_IMAGES = 2;
		
		// <summary>
        //show images selected
        // </summary>
		public const int DISPLAY_FRAMES = 4;
		
		// <summary>
        //display hrules ect.
        // </summary>
		public const int DISPLAY_ALL = 7;
	}
}
