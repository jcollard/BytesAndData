namespace FiveTwoOneOneDecoder
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> DecodeHand method.
    /// </summary>
    public class TestDecodeHand
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
        /// Tests decoding a byte encoded hand.
        /// </summary>
        [Test]
        public void DecodeHand0()
        {
            byte[] hand = { 0x00, 0x00, 0x00, 0x01, 0x25, 0x34, 0x31, 0x43 };
            Assert.AreEqual(this.decoder.DecodeHand(hand), "Yellow Rooster, Blue Five, Orange Four, Orange Rooster, Black Three");
        }

        /// <summary>
        /// Tests decoding a byte encoded hand.
        /// </summary>
        [Test]
        public void DecodeHand1()
        {
            byte[] hand = { 0x00, 0x00, 0x00, 0x22, 0x33, 0x04, 0x12, 0x06 };
            Assert.AreEqual(this.decoder.DecodeHand(hand), "Blue Two, Orange Three, Yellow Four, Green Two, Yellow Six");
        }
    }
}