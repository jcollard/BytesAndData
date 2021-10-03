namespace FiveTwoOneOneDecoder
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> DecodeCardPair method.
    /// </summary>
    public class TestDecodeCardPair
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
        /// Tests decoding a valid Card Pair.
        /// </summary>
        [Test]
        public void DecodeCardPairValid()
        {
            Assert.AreEqual(this.decoder.DecodeCardPair(0x00, 0x34), "Face Down Orange Four");
            Assert.AreEqual(this.decoder.DecodeCardPair(0x01, 0x22), "Face Up Blue Two");
            Assert.AreEqual(this.decoder.DecodeCardPair(0x00, 0x00), "No Card");
        }
    }
}