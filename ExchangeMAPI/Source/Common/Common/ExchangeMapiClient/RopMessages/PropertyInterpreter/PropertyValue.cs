namespace Microsoft.Protocols.TestSuites.Common
{
    using System;

    /// <summary>
    /// This define the base class for a property value node
    /// </summary>
    public class PropertyValue : Node
    {
        /// <summary>
        /// Property's value
        /// </summary>
        private byte[] value;

        /// <summary>
        /// bVarLength is used to determine whether value is a unfix length or not
        /// </summary>
        private bool varLength = false;

        /// <summary>
        /// Gets or sets property's value
        /// </summary>
        public byte[] Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether varLength.
        /// </summary>
        public bool VarLength
        {
            get
            {
                return this.varLength;
            }

            set
            {
                this.varLength = value;
            }
        }

        /// <summary>
        /// Serialize the ROP request buffer.
        /// </summary>
        /// <returns>The ROP request buffer serialized.</returns>
        public virtual byte[] Serialize()
        {
            int length = 0;

            length = this.varLength == false ? this.value.Length : this.value.Length + 2;

            byte[] resultBytes = new byte[length];

            if (this.varLength)
            {
                // Fill 2 bytes with length
                resultBytes[0] = (byte)((ushort)this.value.Length & 0x00FF);
                resultBytes[1] = (byte)(((ushort)this.value.Length & 0xFF00) >> 8);
            }

            Array.Copy(this.value, 0, resultBytes, this.varLength == false ? 0 : 2, this.value.Length);

            return resultBytes;
        }

        /// <summary>
        /// Return the size of this structure.
        /// </summary>
        /// <returns>The size of this structure.</returns>
        public virtual int Size()
        {
            return this.varLength == false ? this.value.Length : this.value.Length + 2;
        }

        /// <summary>
        /// Parse bytes in context into a PropertyValueNode
        /// </summary>
        /// <param name="context">The value of Context</param>
        public override void Parse(Context context)
        {
            // Current processing property's Type
            PropertyType type = context.CurProperty.Type;
            int strBytesLen = 0;
            bool isFound = false;

            switch (type)
            {
                // 1 Byte
                case PropertyType.PtypBoolean:
                    if (context.AvailBytes() < sizeof(byte))
                    {
                        throw new ParseException("Not well formed PTypIBoolean");
                    }
                    else
                    {
                        this.value = new byte[sizeof(byte)];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(byte));
                        context.CurIndex += sizeof(byte);
                    }

                    break;
                case PropertyType.PtypInteger16:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new ParseException("Not well formed PTypInteger16");
                    }
                    else
                    {
                        this.value = new byte[sizeof(short)];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(short));
                        context.CurIndex += sizeof(short);
                    }

                    break;
                case PropertyType.PtypInteger32:
                case PropertyType.PtypFloating32:
                case PropertyType.PtypErrorCode:
                    if (context.AvailBytes() < sizeof(int))
                    {
                        throw new ParseException("Not well formed PTypInteger32");
                    }
                    else
                    {
                        // Assign value of int to property's value
                        this.value = new byte[sizeof(int)];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(int));
                        context.CurIndex += sizeof(int);
                    }

                    break;
                case PropertyType.PtypFloating64:
                case PropertyType.PtypCurrency:
                case PropertyType.PtypFloatingTime:
                case PropertyType.PtypInteger64:
                case PropertyType.PtypTime:
                    if (context.AvailBytes() < sizeof(long))
                    {
                        throw new ParseException("Not well formed PTypInteger64");
                    }
                    else
                    {
                        // Assign value of Int64 to property's value
                        this.value = new byte[sizeof(long)];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(long));
                        context.CurIndex += sizeof(long);
                    }

                    break;
                case PropertyType.PtypGuid:
                    if (context.AvailBytes() < sizeof(byte) * 16)
                    {
                        throw new ParseException("Not well formed 16 PtyGuid");
                    }
                    else
                    {
                        // Assign value of Int64 to property's value
                        this.value = new byte[sizeof(byte) * 16];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(byte) * 16);
                        context.CurIndex += sizeof(byte) * 16;
                    }

                    break;
                case PropertyType.PtypBinary:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new ParseException("Not well formed PTypBinary");
                    }
                    else
                    {
                        // First parse the count of the binary bytes
                        short bytesCount = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                        this.value = new byte[sizeof(short) + bytesCount];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(short));
                        context.CurIndex += sizeof(short);

                        // Then parse the binary bytes
                        if (bytesCount == 0)
                        {
                            this.value = null;
                        }
                        else
                        {
                            Array.Copy(context.PropertyBytes, context.CurIndex, this.value, sizeof(short), bytesCount);
                            context.CurIndex += bytesCount;
                        }
                    }

                    break;
                case PropertyType.PtypMultipleInteger16:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new ParseException("Not well formed PTypMultipleInterger");
                    }
                    else
                    {
                        short bytesCount = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                        this.value = new byte[sizeof(short) + bytesCount * sizeof(short)];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(short));
                        context.CurIndex += sizeof(short);
                        if (bytesCount == 0)
                        {
                            this.value = null;
                        }
                        else
                        {
                            Array.Copy(context.PropertyBytes, context.CurIndex, this.value, sizeof(short), bytesCount * sizeof(short));
                            context.CurIndex += bytesCount * sizeof(short);
                        }
                    }

                    break;
                case PropertyType.PtypMultipleInteger32:
                case PropertyType.PtypMultipleFloating32:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new ParseException("Not well formed PTypMultipleInterger");
                    }
                    else
                    {
                        short bytesCount = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                        this.value = new byte[sizeof(short) + bytesCount * sizeof(int)];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(short));
                        context.CurIndex += sizeof(short);
                        if (bytesCount == 0)
                        {
                            this.value = null;
                        }
                        else
                        {
                            Array.Copy(context.PropertyBytes, context.CurIndex, this.value, sizeof(short), bytesCount * sizeof(int));
                            context.CurIndex += bytesCount * sizeof(int);
                        }
                    }

                    break;
                case PropertyType.PtypMultipleFloating64:
                case PropertyType.PtypMultipleCurrency:
                case PropertyType.PtypMultipleFloatingTime:
                case PropertyType.PtypMultipleInteger64:
                case PropertyType.PtypMultipleTime:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new ParseException("Not well formed PTypMultipleInterger");
                    }
                    else
                    {
                        short bytesCount = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                        this.value = new byte[sizeof(short) + bytesCount * sizeof(long)];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(short));
                        context.CurIndex += sizeof(short);
                        if (bytesCount == 0)
                        {
                            this.value = null;
                        }
                        else
                        {
                            Array.Copy(context.PropertyBytes, context.CurIndex, this.value, sizeof(short), bytesCount * sizeof(long));
                            context.CurIndex += bytesCount * sizeof(long);
                        }
                    }

                    break;
                case PropertyType.PtypMultipleGuid:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new ParseException("Not well formed PTypMultipleInterger");
                    }
                    else
                    {
                        short bytesCount = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                        this.value = new byte[sizeof(short) + bytesCount * 16];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(short));
                        context.CurIndex += sizeof(short);
                        if (bytesCount == 0)
                        {
                            this.value = null;
                        }
                        else
                        {
                            Array.Copy(context.PropertyBytes, context.CurIndex, this.value, sizeof(short), bytesCount * 16);
                            context.CurIndex += bytesCount * 16;
                        }
                    }

                    break;
                case PropertyType.PtypString8:
                    // The length in bytes of the unicode string to parse
                    strBytesLen = 0;
                    isFound = false;

                    // Find the string with '\0' end
                    for (int i = context.CurIndex; i < context.PropertyBytes.Length; i++)
                    {
                        strBytesLen++;
                        if (context.PropertyBytes[i] == 0)
                        {
                            isFound = true;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        throw new ParseException("String too long or not found");
                    }
                    else
                    {
                        this.value = new byte[strBytesLen];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, strBytesLen);
                        context.CurIndex += strBytesLen;
                    }

                    break;
                case PropertyType.PtypString:
                    // The length in bytes of the unicode string to parse
                    strBytesLen = 0;
                    isFound = false;

                    // Find the string with '\0''\0' end
                    for (int i = context.CurIndex; i < context.PropertyBytes.Length; i += 2)
                    {
                        strBytesLen += 2;
                        if ((context.PropertyBytes[i] == 0) && (context.PropertyBytes[i + 1] == 0))
                        {
                            isFound = true;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        throw new ParseException("String too long or not found");
                    }
                    else
                    {
                        this.value = new byte[strBytesLen];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, strBytesLen);
                        context.CurIndex += strBytesLen;
                    }

                    break;
                case PropertyType.PtypMultipleString:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new FormatException("Not well formed PtypMultipleString");
                    }
                    else
                    {
                        strBytesLen = 0;
                        isFound = false;
                        short stringCount = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                        context.CurIndex += sizeof(short);
                        if (stringCount == 0)
                        {
                            value = null;
                            break;
                        }

                        for (int i = context.CurIndex; i < context.PropertyBytes.Length; i += 2)
                        {
                            strBytesLen += 2;
                            if ((context.PropertyBytes[i] == 0) && (context.PropertyBytes[i + 1] == 0))
                            {
                                stringCount--;
                            }

                            if (stringCount == 0)
                            {
                                isFound = true;
                                break;
                            }
                        }

                        if (!isFound)
                        {
                            throw new FormatException("String too long or not found");
                        }
                        else
                        {
                            value = new byte[strBytesLen];
                            Array.Copy(context.PropertyBytes, context.CurIndex, value, 0, strBytesLen);
                            context.CurIndex += strBytesLen;
                        }
                    }

                    break;
                case PropertyType.PtypMultipleString8:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new FormatException("Not well formed PtypMultipleString8");
                    }
                    else
                    {
                        strBytesLen = 0;
                        isFound = false;
                        short stringCount = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                        context.CurIndex += sizeof(short);
                        if (stringCount == 0)
                        {
                            value = null;
                            break;
                        }

                        for (int i = context.CurIndex; i < context.PropertyBytes.Length; i++)
                        {
                            strBytesLen++;
                            if (context.PropertyBytes[i] == 0)
                            {
                                stringCount--;
                            }

                            if (stringCount == 0)
                            {
                                isFound = true;
                                break;
                            }
                        }

                        if (!isFound)
                        {
                            throw new FormatException("String too long or not found");
                        }
                        else
                        {
                            value = new byte[strBytesLen];
                            Array.Copy(context.PropertyBytes, context.CurIndex, value, 0, strBytesLen);
                            context.CurIndex += strBytesLen;
                        }
                    }

                    break;
                case PropertyType.PtypRuleAction:
                    // Length of the property
                    int felength = 0;

                    // Length of the action blocks
                    short actionBolcksLength = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                    felength += 2;
                    short actionBlockLength = 0;
                    for (int i = 0; i < actionBolcksLength; i++)
                    {
                        actionBlockLength = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex + felength);
                        felength += 2 + actionBlockLength;
                    }

                    this.value = new byte[felength];
                    Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, felength);
                    context.CurIndex += felength;
                    break;
                case PropertyType.PtypServerId:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new ParseException("Not well formed PtypServerId");
                    }
                    else
                    {
                        this.value = new byte[sizeof(short) + 21 * sizeof(byte)];
                        Array.Copy(context.PropertyBytes, context.CurIndex, this.value, 0, sizeof(short) + 21);

                        context.CurIndex += 21 + sizeof(short);
                    }

                    break;
                case PropertyType.PtypMultipleBinary:
                    if (context.AvailBytes() < sizeof(short))
                    {
                        throw new ParseException("Not well formed PtypMultipleBinary");
                    }
                    else
                    {
                        int bytesCount = BitConverter.ToInt32(context.PropertyBytes, context.CurIndex);
                        context.CurIndex += sizeof(int);
                        for (int ibin = 0; ibin < bytesCount; ibin++)
                        {
                            short binLength = BitConverter.ToInt16(context.PropertyBytes, context.CurIndex);
                            context.CurIndex += sizeof(short);
                            if (binLength > 0)
                            {
                                context.CurIndex += sizeof(byte) * binLength;
                            }
                        }
                    }

                    break;

                default:
                    throw new FormatException("Type " + type.ToString() + " not found or not support.");
            }
        }
    }
}