﻿//-----------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCMAPIHTTP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Protocols.TestSuites.Common;

    /// <summary>
    /// A class indicates the Bind request type.
    /// </summary>
    public class BindRequestBody : AddressBookRequestBodyBase
    {
        /// <summary>
        /// Gets or sets a set of bit flags that specify the authentication type for the connection.
        /// </summary>
        public uint Flags { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has state.
        /// </summary>
        public bool HasState { get; set; }

        /// <summary>
        /// Gets or sets a STAT structure that specifies the state of a specific address book container.
        /// </summary>
        public STAT State { get; set; }

        /// <summary>
        /// Serialize the instance to byte array.
        /// </summary>
        /// <returns>An array byte of the bind request body.</returns>
        public override byte[] Serialize()
        {
            List<byte> rawData = new List<byte>();

            rawData.AddRange(BitConverter.GetBytes(this.Flags));
            rawData.AddRange(BitConverter.GetBytes(this.HasState));
            if (this.HasState)
            {
                rawData.AddRange(this.State.Serialize());
            }

            rawData.AddRange(BitConverter.GetBytes(this.AuxiliaryBufferSize));
            rawData.AddRange(this.AuxiliaryBuffer);

            return rawData.ToArray();
        }
    }
}
