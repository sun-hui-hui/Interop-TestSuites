//-----------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCFOLD
{
    using System;
    using Microsoft.Protocols.TestSuites.Common;

    /// <summary>
    /// The ExistRestriction structure.
    /// </summary>
    public class ExistRestriction : Restriction
    {
        /// <summary>
        /// Initializes a new instance of the ExistRestriction class.
        /// </summary>
        public ExistRestriction()
        {
            this.RestrictType = RestrictType.ExistRestriction;
        }

        /// <summary>
        /// Gets or sets the value indicates the type of restriction (2) and MUST be set to 0x08.
        /// </summary>
        public PropertyTag PropTag
        {
            get;
            set;
        }

        /// <summary>
        /// Deserialize the AndRestriction data.
        /// </summary>
        /// <param name="restrictionData">The restriction data.</param>
        public override void Deserialize(byte[] restrictionData)
        {
            int index = 0;
            this.RestrictType = (RestrictType)restrictionData[index];

            if (this.RestrictType != RestrictType.ExistRestriction)
            {
                throw new ArgumentException("The restrict type is not ExistRestriction type.");
            }

            index++;

            index += this.PropTag.Deserialize(restrictionData, index);
        }

        /// <summary>
        /// Serialize the Restriction data.
        /// </summary>
        /// <returns>Format the type of Restriction data to byte array.</returns>
        public override byte[] Serialize()
        {
            int index = 0;
            byte[] restrictionData = new byte[this.Size()];

            restrictionData[index++] = (byte)this.RestrictType;
            Array.Copy(this.PropTag.Serialize(), 0, restrictionData, index, this.PropTag.Serialize().Length);

            return restrictionData;
        }

        /// <summary>
        /// Get the size of the restriction data.
        /// </summary>
        /// <returns>Returns the size of restriction data.</returns>
        public override int Size()
        {
            int size = 0;
            size += sizeof(byte) + sizeof(uint);

            return size;
        }
    }
}