//-----------------------------------------------------------------------
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
    /// A class indicates the Disconnect request type success response body 
    /// </summary>
    public class DisconnectSuccessResponseBody : MailboxResponseBodyBase
    {
        /// <summary>
        /// Gets or private sets an unsigned integer that specifies the return status of the operation.
        /// </summary>
        public uint ErrorCode { get; private set; }

        /// <summary>
        /// Parse the Disconnect request type success response body.
        /// </summary>
        /// <param name="rawData">The raw data which is returned by server.</param>
        /// <returns>An instance of DisconnectSuccessResponseBody class.</returns>
        public static DisconnectSuccessResponseBody Parse(byte[] rawData)
        {
            DisconnectSuccessResponseBody responseBody = new DisconnectSuccessResponseBody();
            int index = 0;
            responseBody.StatusCode = BitConverter.ToUInt32(rawData, index);
            index += 4;
            responseBody.ErrorCode = BitConverter.ToUInt32(rawData, index);
            index += 4;
            responseBody.AuxiliaryBufferSize = BitConverter.ToUInt32(rawData, index);
            index += 4;
            responseBody.AuxiliaryBuffer = new byte[responseBody.AuxiliaryBufferSize];
            Array.Copy(rawData, index, responseBody.AuxiliaryBuffer, 0, responseBody.AuxiliaryBufferSize);

            return responseBody;
        }
    }
}