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
// Generated by IDLImporter from file mozIAsyncFavicons.idl
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
    /// Interface for accessing the favicon service asynchronously.
    ///
    /// @status EXPERIMENTAL
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f3530e8d-0016-4f56-91fe-28958a7ec296")]
	public interface mozIAsyncFavicons
	{
		
		/// <summary>
        /// Declares that a given page uses a favicon with the given URI and
        /// attempts to fetch and save the icon data by loading the favicon URI
        /// through an async network request.
        ///
        /// If the icon data already exists, we won't try to reload the icon unless
        /// aForceReload is true.  Similarly, if the icon is in the failed favicon
        /// cache we won't do anything unless aForceReload is true, in which case
        /// we'll try to reload the favicon.
        ///
        /// This function will only save favicons for pages that are already stored in
        /// the database, like visited pages or bookmarks.  For any other URIs, it
        /// will succeed but do nothing.  This function will also ignore the error
        /// page favicon URI (see FAVICON_ERRORPAGE_URL below).
        ///
        /// Icons that fail to load will automatically be added to the failed favicon
        /// cache, and this function will not save favicons for non-bookmarked URIs
        /// when history is disabled.
        ///
        /// @note This function is identical to
        /// nsIFaviconService::setAndLoadFaviconForPage.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon is being set.
        /// @param aFaviconURI
        /// URI of the favicon to associate with the page.
        /// @param aForceReload
        /// If aForceReload is false, we try to reload the favicon only if we
        /// don't have it or it has expired from the cache.  Setting
        /// aForceReload to true causes us to reload the favicon even if we
        /// have a usable copy.
        /// @param aCallback
        /// Once we're done setting and/or fetching the favicon, we invoke this
        /// callback.
        ///
        /// @see nsIFaviconDataCallback in nsIFaviconService.idl.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAndFetchFaviconForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.U1)] bool aForceReload, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);
		
		/// <summary>
        /// Sets the data for a given favicon URI either by replacing existing data in
        /// the database or taking the place of otherwise fetched icon data when
        /// calling setAndFetchFaviconForPage later.
        ///
        /// Favicon data for favicon URIs that are not associated with a page URI via
        /// setAndFetchFaviconForPage will be stored in memory, but may be expired at
        /// any time, so you should make an effort to associate favicon URIs with page
        /// URIs as soon as possible.
        ///
        /// It's better to not use this function for chrome: icon URIs since you can
        /// reference the chrome image yourself. getFaviconLinkForIcon/Page will ignore
        /// any associated data if the favicon URI is "chrome:" and just return the
        /// same chrome URI.
        ///
        /// This function does NOT send out notifications that the data has changed.
        /// Pages using this favicons that are visible in history or bookmarks views
        /// will keep the old icon until they have been refreshed by other means.
        ///
        /// This function tries to optimize the favicon size, if it is bigger
        /// than a defined limit we will try to convert it to a 16x16 png image.
        /// If the conversion fails and favicon is still bigger than our max accepted
        /// size it won't be saved.
        ///
        /// @param aFaviconURI
        /// URI of the favicon whose data is being set.
        /// @param aData
        /// Binary contents of the favicon to save
        /// @param aDataLength
        /// Length of binary data
        /// @param aMimeType
        /// MIME type of the data to store.  This is important so that we know
        /// what to report when the favicon is used.  You should always set this
        /// param unless you are clearing an icon.
        /// @param aExpiration
        /// Time in microseconds since the epoch when this favicon expires.
        /// Until this time, we won't try to load it again.
        /// @throws NS_ERROR_FAILURE
        /// Thrown if the favicon is overbloated and won't be saved to the db.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReplaceFaviconData([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] byte[] aData, uint aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMimeType, long aExpiration);
		
		/// <summary>
        /// Same as replaceFaviconData but the data is provided by a string
        /// containing a data URL.
        ///
        /// @see replaceFaviconData
        ///
        /// @param aFaviconURI
        /// URI of the favicon whose data is being set.
        /// @param aDataURL
        /// string containing a data URL that represents the contents of
        /// the favicon to save
        /// @param aExpiration
        /// Time in microseconds since the epoch when this favicon expires.
        /// Until this time, we won't try to load it again.
        /// @throws NS_ERROR_FAILURE
        /// Thrown if the favicon is overbloated and won't be saved to the db.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReplaceFaviconDataFromDataURL([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDataURL, long aExpiration);
		
		/// <summary>
        /// Retrieves the favicon URI associated to the given page, if any.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon URI we're looking up.
        /// @param aCallback
        /// This callback is always invoked to notify the result of the lookup.
        /// The aURI parameter will be the favicon URI, or null when no favicon
        /// is associated with the page or an error occurred while fetching it.
        ///
        /// @note When the callback is invoked, aDataLen will be always 0, aData will
        /// be an empty array, and aMimeType will be an empty string, regardless
        /// of whether a favicon is associated with the page.
        ///
        /// @see nsIFaviconDataCallback in nsIFaviconService.idl.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFaviconURLForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);
		
		/// <summary>
        /// Retrieves the favicon URI and data associated to the given page, if any.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon URI and data we're looking up.
        /// @param aCallback
        /// This callback is always invoked to notify the result of the lookup.  The aURI
        /// parameter will be the favicon URI, or null when no favicon is
        /// associated with the page or an error occurred while fetching it.  If
        /// aURI is not null, the other parameters may contain the favicon data.
        /// However, if no favicon data is currently associated with the favicon
        /// URI, aDataLen will be 0, aData will be an empty array, and aMimeType
        /// will be an empty string.
        ///
        /// @see nsIFaviconDataCallback in nsIFaviconService.idl.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFaviconDataForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);
	}
}
