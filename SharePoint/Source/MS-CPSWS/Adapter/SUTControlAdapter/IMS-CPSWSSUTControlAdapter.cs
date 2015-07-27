﻿//-----------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------
namespace Microsoft.Protocols.TestSuites.MS_CPSWS
{
    using Microsoft.Protocols.TestTools;

    /// <summary>
    /// The SUTControlAdapter's implementation.
    /// </summary>
    public interface IMS_CPSWSSUTControlAdapter : IAdapter
    {
        /// <summary>
        /// A method used to get claim types.
        /// </summary>
        /// <param name="inputClaimProviderNames">A group of provider names that are separated by commas ','.</param>
        /// <returns>A string contained one or more claim types, which are separated by commas ','.</returns> 
        [MethodHelp(@"Enter the string for the specified inputClaimProviderNames parameter. If the string contains one or more claim provider names, each entry is separated by a comma.
            And the result is a string that contains one or more than one claim types.]")]
        string GetClaimTypesInSPProvider(string inputClaimProviderNames);

        /// <summary>
        /// A method used to get claim value types.
        /// </summary>
        /// <param name="inputClaimProviderNames">A group of provider names that are separated by commas ','.</param>
        /// <returns>A string contained one or more claim value types, which are separated by commas ','.</returns> 
        [MethodHelp(@"Enter the string for specified inputClaimProviderNames parameter. If the string contains one or more claim provider names, each entry is separated by a comma.
            And the result is a string that string contains one or more claim value types.]")]
        string GetClaimValueTypesInSPProvider(string inputClaimProviderNames);

        /// <summary>
        /// A method used to get entity types.
        /// </summary>
        /// <param name="inputClaimProviderNames">A group of provider names that are separated by commas ','.</param>
        /// <returns>The return is empty or a string that contains one or more entity types, which are separated by commas ','.</returns> 
        [MethodHelp(@"Enter the string for specified inputClaimProviderNames parameter. If the string contains one or more claim provider names, each entry is separated by a comma.
            And the result is empty or a string that string contains one or more entity types.")]
        string GetEntityTypesInSPProvider(string inputClaimProviderNames);
    }
}
