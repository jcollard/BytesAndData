namespace BytesAndData
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> DecodePlayer method.
    /// </summary>
    public class TestDecodePlayer
    {
        private IFiveTwoOneOneDecoder decoder;

        /// <summary>
        /// Initializes the IFiveTwoOneOneDecoder by using <see
        /// cref="Config.GetDecoder"/>.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.decoder = new Config().GetDecoder();
        }

        /// <summary>
        /// Tests decoding a byte encoded player board.
        /// </summary>
        [Test]
        public void DecodePlayerBilly()
        {
            byte[] player = {
                 0x00, 0x00, 0x00, 0x01, 0x22, 0x33, 0x41, 0x23,
                 0x00, 0x01, 0x00, 0x25, 0x00, 0x00, 0x00, 0x00
             };
            Assert.AreEqual(this.decoder.DecodePlayer("Billy's", player), "Billy's Hand: Yellow Rooster, Blue Two, Orange Three, Black Rooster, Blue Three\nBilly's Board: Face Down Yellow Rooster, Face Down Blue Five, No Card, No Card");
        }

        /// <summary>
        /// Tests decoding a byte encoded player board.
        /// </summary>
        [Test]
        public void DecodePlayerSally()
        {
            byte[] player = {
                 0x00, 0x00, 0x00, 0x01, 0x22, 0x12, 0x41, 0x23,
                 0x01, 0x01, 0x01, 0x25, 0x00, 0x33, 0x00, 0x00
             };
            Assert.AreEqual(this.decoder.DecodePlayer("Sally's", player), "Sally's Hand: Yellow Rooster, Blue Two, Green Two, Black Rooster, Blue Three\nSally's Board: Face Up Yellow Rooster, Face Up Blue Five, Face Down Orange Three, No Card");
        }

        /// <summary>
        /// Tests decoding a byte encoded player board.
        /// </summary>
        [Test]
        public void DecodePlayerBetty()
        {
            byte[] player = {
                 0x00, 0x00, 0x00, 0x01, 0x22, 0x12, 0x22, 0x23,
                 0x01, 0x01, 0x01, 0x25, 0x01, 0x33, 0x01, 0x41
             };
            Assert.AreEqual(this.decoder.DecodePlayer("Betty's", player), "Betty's Hand: Yellow Rooster, Blue Two, Green Two, Blue Two, Blue Three\nBetty's Board: Face Up Yellow Rooster, Face Up Blue Five, Face Up Orange Three, Face Up Black Rooster");
        }
    }
}