namespace FiveTwoOneOneDecoder
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> DecodeBoard method.
    /// </summary>
    public class TestDecodeBoard
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
        /// Tests decoding a byte encoded board.
        /// </summary>
        [Test]
        public void DecodeBoard0()
        {
            byte[] board = { 0x00, 0x01, 0x00, 0x25, 0x00, 0x00, 0x00, 0x00 };
            Assert.AreEqual(this.decoder.DecodeBoard(board), "Face Down Yellow Rooster, Face Down Blue Five, No Card, No Card");
        }

        /// <summary>
        /// Tests decoding a byte encoded board.
        /// </summary>
        [Test]
        public void DecodeBoard1()
        {
            byte[] board = { 0x01, 0x01, 0x01, 0x25, 0x00, 0x33, 0x00, 0x00 };
            Assert.AreEqual(this.decoder.DecodeBoard(board), "Face Up Yellow Rooster, Face Up Blue Five, Face Down Orange Three, No Card");
        }

        /// <summary>
        /// Tests decoding a byte encoded board.
        /// </summary>
        [Test]
        public void DecodeBoard2()
        {
            byte[] board = { 0x01, 0x01, 0x01, 0x25, 0x01, 0x33, 0x01, 0x41 };
            Assert.AreEqual(this.decoder.DecodeBoard(board), "Face Up Yellow Rooster, Face Up Blue Five, Face Up Orange Three, Face Up Black Rooster");
        }
    }
}