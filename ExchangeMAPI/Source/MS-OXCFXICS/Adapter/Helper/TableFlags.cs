//-----------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCFXICS
{
    using System;

    /// <summary>
    /// Table flags.
    /// </summary>
    [Flags]
    public enum TableFlags : byte
    {
        /// <summary>
        /// None flag is set.
        /// </summary>
        None = 0x00,

        /// <summary>
        /// Fills the hierarchy table with search folder containers from all levels. If this flag is not set, the hierarchy table contains only the search folder container's immediate child search folder containers.
        /// </summary>
        Depth = 0x04,

        /// <summary>
        /// The ROP response can return immediately, possibly before the ROP execution is complete, and in this case, the ReturnValue as well as the RowCount fields in the return buffer might not be accurate. Only ReturnValues reporting failure can be considered valid in this case.
        /// </summary>
        DeferredErrors = 0x08,

        /// <summary>
        /// Disables all notifications on this Table object.
        /// </summary>
        NoNotifications = 0x10,

        /// <summary>
        /// Enables the client to get a list of the soft-deleted folders.
        /// </summary>
        SoftDeletes = 0x20,

        /// <summary>
        /// Requests that the columns that contain string data be returned in Unicode format. If UseUnicode is not present, then the string data will be encoded in the code page of the logon.
        /// </summary>
        UseUnicode = 0x40,

        /// <summary>
        /// Suppresses notifications generated by this client's actions on this Table object.
        /// </summary>
        SuppressesNotifications = 0x80,
    }
}