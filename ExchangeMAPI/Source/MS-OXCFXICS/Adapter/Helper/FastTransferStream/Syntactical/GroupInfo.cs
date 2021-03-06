namespace Microsoft.Protocols.TestSuites.MS_OXCFXICS
{
    /// <summary>
    /// The groupInfo element provides a definition for the property group mapping. 
    /// Property group mappings, after they are defined by using the groupInfo element,
    /// can be referenced with the PidTagIncrSyncGroupId meta-property further 
    /// in the stream by its group ID.
    /// groupInfo            = IncrSyncGroupInfo propList
    /// </summary>
    public class GroupInfo : SyntacticalBase
    {
        /// <summary>
        /// A propList.
        /// </summary>
        private PropList propList;

        /// <summary>
        /// Initializes a new instance of the GroupInfo class.
        /// </summary>
        /// <param name="stream">A FastTransferStream.</param>
        public GroupInfo(FastTransferStream stream)
            : base(stream)
        {
        }

        /// <summary>
        /// Gets or sets the propList.
        /// </summary>
        public PropList PropList
        {
            get { return this.propList; }
            set { this.propList = value; }
        }

        /// <summary>
        /// Verify that a stream's current position contains a serialized groupInfo.
        /// </summary>
        /// <param name="stream">A FastTransferStream.</param>
        /// <returns>If the stream's current position contains 
        /// a serialized groupInfo, return true, else false.</returns>
        public static bool Verify(FastTransferStream stream)
        {
            return stream.VerifyMarker(Markers.PidTagIncrSyncGroupInfo);
        }

        /// <summary>
        /// Deserialize fields from a FastTransferStream.
        /// </summary>
        /// <param name="stream">A FastTransferStream.</param>
        public override void Deserialize(FastTransferStream stream)
        {
            if (stream.ReadMarker(Markers.PidTagIncrSyncGroupInfo))
            {
                this.propList = new PropList(stream);
                return;
            }

            AdapterHelper.Site.Assert.Fail("The stream cannot be deserialized successfully.");
        }
    }
}