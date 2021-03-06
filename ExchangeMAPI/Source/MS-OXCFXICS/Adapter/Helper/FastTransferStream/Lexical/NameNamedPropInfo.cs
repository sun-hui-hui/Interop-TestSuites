namespace Microsoft.Protocols.TestSuites.MS_OXCFXICS
{
    using System;

    /// <summary>
    /// The NameNamedPropInfo class.
    /// </summary>
    public class NameNamedPropInfo : NamedPropInfo
    {
        /// <summary>
        /// The name of the NamedPropInfo.
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the NameNamedPropInfo class.
        /// </summary>
        /// <param name="stream">A FastTransferStream.</param>
        public NameNamedPropInfo(FastTransferStream stream)
            : base(stream)
        {
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Verify that a stream's current position contains a serialized NameNamedPropInfo.
        /// </summary>
        /// <param name="stream">A FastTransferStream</param>
        /// <returns>If the stream's current position contains 
        /// a serialized NameNamedPropInfo, return true, else false</returns>
        public static bool Verify(FastTransferStream stream)
        {
            return stream.Verify(0x01, Guid.Empty.ToByteArray().Length);
        }

        /// <summary>
        /// Deserialize a NameNamedPropInfo instance from a FastTransferStream
        /// </summary>
        /// <param name="stream">A FastTransferStream.</param>
        /// <returns>A NameNamedPropInfo instance.</returns>
        public static new LexicalBase DeserializeFrom(FastTransferStream stream)
        {
            return new NameNamedPropInfo(stream);
        }

        /// <summary>
        /// Deserialize next object from a FastTransferStream.
        /// </summary>
        /// <param name="stream">A FastTransferStream.</param>
        public override void ConsumeNext(FastTransferStream stream)
        {
            base.ConsumeNext(stream);
            this.name = stream.ReadString();
        }
    }
}