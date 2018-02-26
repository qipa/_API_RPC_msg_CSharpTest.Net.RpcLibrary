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
// Generated by IDLImporter from file nsPISocketTransportService.idl
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
    /// This is a private interface used by the internals of the networking library.
    /// It will never be frozen.  Do not use it in external code.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("83123036-81c0-47cb-8d9c-bd85d29a1b3f")]
	public interface nsPISocketTransportService : nsISocketTransportService
	{
		
		/// <summary>
        /// Creates a transport for a specified host and port.
        ///
        /// @param aSocketTypes
        /// array of socket type strings.  null if using default socket type.
        /// @param aTypeCount
        /// specifies length of aSocketTypes.
        /// @param aHost
        /// specifies the target hostname or IP address literal of the peer
        /// for this socket.
        /// @param aPort
        /// specifies the target port of the peer for this socket.
        /// @param aProxyInfo
        /// specifies the transport-layer proxy type to use.  null if no
        /// proxy.  used for communicating information about proxies like
        /// SOCKS (which are transparent to upper protocols).
        ///
        /// @see nsIProxiedProtocolHandler
        /// @see nsIProtocolProxyService::GetProxyInfo
        ///
        /// NOTE: this function can be called from any thread
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISocketTransport CreateTransport([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] string[] aSocketTypes, uint aTypeCount, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost, int aPort, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxyInfo);
		
		/// <summary>
        /// Adds a new socket to the list of controlled sockets.
        ///
        /// This will fail with the error code NS_ERROR_NOT_AVAILABLE if the maximum
        /// number of sockets is already reached.
        /// In this case, the notifyWhenCanAttachSocket method should be used.
        ///
        /// @param aFd
        /// Open file descriptor of the socket to control.
        /// @param aHandler
        /// Socket handler that will receive notifications when the socket is
        /// ready or detached.
        ///
        /// NOTE: this function may only be called from an event dispatch on the
        /// socket thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AttachSocket(System.IntPtr aFd, System.IntPtr aHandler);
		
		/// <summary>
        /// if the number of sockets reaches the limit, then consumers can be
        /// notified when the number of sockets becomes less than the limit.  the
        /// notification is asynchronous, delivered via the given nsIRunnable
        /// instance on the socket transport thread.
        ///
        /// @param aEvent
        /// Event that will receive the notification when a new socket can
        /// be attached
        ///
        /// NOTE: this function may only be called from an event dispatch on the
        /// socket thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void NotifyWhenCanAttachSocket([MarshalAs(UnmanagedType.Interface)] nsIRunnable aEvent);
		
		/// <summary>
        /// init/shutdown routines.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
		
		/// <summary>
        /// controls whether or not the socket transport service should poke
        /// the autodialer on connection failure.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAutodialEnabledAttribute();
		
		/// <summary>
        /// controls whether or not the socket transport service should poke
        /// the autodialer on connection failure.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAutodialEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aAutodialEnabled);
		
		/// <summary>
        /// controls the TCP sender window clamp
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSendBufferSizeAttribute();
	}
}