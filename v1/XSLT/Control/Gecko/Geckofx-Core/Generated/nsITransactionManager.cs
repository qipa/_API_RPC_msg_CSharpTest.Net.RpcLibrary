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
// Generated by IDLImporter from file nsITransactionManager.idl
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
    /// The nsITransactionManager interface.
    /// <P>
    /// This interface is implemented by an object that wants to
    /// manage/track transactions.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("58e330c2-7b48-11d2-98b9-00805f297d89")]
	public interface nsITransactionManager
	{
		
		/// <summary>
        /// Calls a transaction's doTransaction() method, then pushes it on the
        /// undo stack.
        /// <P>
        /// This method calls the transaction's AddRef() method.
        /// The transaction's Release() method will be called when the undo or redo
        /// stack is pruned or when the transaction manager is destroyed.
        /// @param aTransaction the transaction to do.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoTransaction([MarshalAs(UnmanagedType.Interface)] nsITransaction aTransaction);
		
		/// <summary>
        /// Pops the topmost transaction on the undo stack, calls its
        /// undoTransaction() method, then pushes it on the redo stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UndoTransaction();
		
		/// <summary>
        /// Pops the topmost transaction on the redo stack, calls its
        /// redoTransaction() method, then pushes it on the undo stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RedoTransaction();
		
		/// <summary>
        /// Clears the undo and redo stacks.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
		
		/// <summary>
        /// Turns on the transaction manager's batch mode, forcing all transactions
        /// executed by the transaction manager's doTransaction() method to be
        /// aggregated together until EndBatch() is called.  This mode allows an
        /// application to execute and group together several independent transactions
        /// so they can be undone with a single call to undoTransaction().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginBatch();
		
		/// <summary>
        /// Turns off the transaction manager's batch mode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndBatch();
		
		/// <summary>
        /// The number of items on the undo stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumberOfUndoItemsAttribute();
		
		/// <summary>
        /// The number of items on the redo stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumberOfRedoItemsAttribute();
		
		/// <summary>
        /// Sets the maximum number of transaction items the transaction manager will
        /// maintain at any time. This is commonly referred to as the number of levels
        /// of undo.
        /// @param aMaxCount A value of -1 means no limit. A value of zero means the
        /// transaction manager will execute each transaction, then immediately release
        /// all references it has to the transaction without pushing it on the undo
        /// stack. A value greater than zero indicates the max number of transactions
        /// that can exist at any time on both the undo and redo stacks. This method
        /// will prune the necessary number of transactions on the undo and redo
        /// stacks if the value specified is less than the number of items that exist
        /// on both the undo and redo stacks.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMaxTransactionCountAttribute();
		
		/// <summary>
        /// Sets the maximum number of transaction items the transaction manager will
        /// maintain at any time. This is commonly referred to as the number of levels
        /// of undo.
        /// @param aMaxCount A value of -1 means no limit. A value of zero means the
        /// transaction manager will execute each transaction, then immediately release
        /// all references it has to the transaction without pushing it on the undo
        /// stack. A value greater than zero indicates the max number of transactions
        /// that can exist at any time on both the undo and redo stacks. This method
        /// will prune the necessary number of transactions on the undo and redo
        /// stacks if the value specified is less than the number of items that exist
        /// on both the undo and redo stacks.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMaxTransactionCountAttribute(int aMaxTransactionCount);
		
		/// <summary>
        /// Returns an AddRef'd pointer to the transaction at the top of the
        /// undo stack. Callers should be aware that this method could return
        /// return a null in some implementations if there is a batch at the top
        /// of the undo stack.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransaction PeekUndoStack();
		
		/// <summary>
        /// Returns an AddRef'd pointer to the transaction at the top of the
        /// redo stack. Callers should be aware that this method could return
        /// return a null in some implementations if there is a batch at the top
        /// of the redo stack.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransaction PeekRedoStack();
		
		/// <summary>
        /// Returns the list of transactions on the undo stack. Note that the
        /// transaction at the top of the undo stack will actually be at the
        /// index 'n-1' in the list, where 'n' is the number of items in the list.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransactionList GetUndoList();
		
		/// <summary>
        /// Returns the list of transactions on the redo stack. Note that the
        /// transaction at the top of the redo stack will actually be at the
        /// index 'n-1' in the list, where 'n' is the number of items in the list.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITransactionList GetRedoList();
		
		/// <summary>
        /// Adds a listener to the transaction manager's notification list. Listeners
        /// are notified whenever a transaction is done, undone, or redone.
        /// <P>
        /// The listener's AddRef() method is called.
        /// @param aListener the lister to add.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddListener([MarshalAs(UnmanagedType.Interface)] nsITransactionListener aListener);
		
		/// <summary>
        /// Removes a listener from the transaction manager's notification list.
        /// <P>
        /// The listener's Release() method is called.
        /// @param aListener the lister to remove.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsITransactionListener aListener);
	}
}
