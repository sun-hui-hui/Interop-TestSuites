namespace Microsoft.Protocols.TestSuites.Common
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// RopDeleteAttachment request buffer structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RopDeleteAttachmentRequest : ISerializable
    {
        /// <summary>
        /// This value specifies the type of remote operation. For this operation, this field is set to 0x24.
        /// </summary>
        public byte RopId;

        /// <summary>
        /// This value specifies the logon associated with this operation.
        /// </summary>
        public byte LogonId;

        /// <summary>
        /// This index specifies the location in the Server Object Handle Table where the handle for the input Server Object is stored. 
        /// </summary>
        public byte InputHandleIndex;

        /// <summary>
        /// This value identifies the attachment to be deleted. 
        /// The value of this field is equivalent to the PidTagAttachNumber property ([MS-OXPROPS] section 2.672).
        /// </summary>
        public uint AttachmentID;

        /// <summary>
        /// Serialize the ROP request buffer.
        /// </summary>
        /// <returns>The ROP request buffer serialized.</returns>
        public byte[] Serialize()
        {
            byte[] serializedBuffer = new byte[Marshal.SizeOf(this)];
            IntPtr requestBuffer = new IntPtr();
            requestBuffer = Marshal.AllocHGlobal(Marshal.SizeOf(this));
            try
            {
                Marshal.StructureToPtr(this, requestBuffer, true);
                Marshal.Copy(requestBuffer, serializedBuffer, 0, Marshal.SizeOf(this));
                return serializedBuffer;
            }
            finally
            {
                Marshal.FreeHGlobal(requestBuffer);
            }
        }

        /// <summary>
        /// Return the size of RopDeleteAttachment request buffer structure.
        /// </summary>
        /// <returns>The size of RopDeleteAttachment request buffer structure.</returns>
        public int Size()
        {
            return Marshal.SizeOf(this);
        }
    }

    /// <summary>
    /// RopDeleteAttachment response buffer structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RopDeleteAttachmentResponse : IDeserializable
    {
        /// <summary>
        /// This value specifies the type of remote operation. For this operation, this field is set to 0x24.
        /// </summary>
        public byte RopId;

        /// <summary>
        /// This index MUST be set to the InputHandleIndex specified in the request.
        /// </summary>
        public byte InputHandleIndex;

        /// <summary>
        /// This value specifies the status of the remote operation.
        /// </summary>
        public uint ReturnValue;

        /// <summary>
        /// Deserialize the ROP response buffer.
        /// </summary>
        /// <param name="ropBytes">ROPs bytes in response.</param>
        /// <param name="startIndex">The start index of this ROP.</param>
        /// <returns>The size of response buffer structure.</returns>
        public int Deserialize(byte[] ropBytes, int startIndex)
        {
            IntPtr responseBuffer = new IntPtr();
            responseBuffer = Marshal.AllocHGlobal(Marshal.SizeOf(this));
            try
            {
                Marshal.Copy(ropBytes, startIndex, responseBuffer, Marshal.SizeOf(this));
                this = (RopDeleteAttachmentResponse)Marshal.PtrToStructure(responseBuffer, typeof(RopDeleteAttachmentResponse));
                return Marshal.SizeOf(this);
            }
            finally
            {
                Marshal.FreeHGlobal(responseBuffer);
            }
        }
    }
}