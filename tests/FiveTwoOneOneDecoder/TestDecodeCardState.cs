namespace BytesAndData
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> DecodeCardState method.
    /// </summary>
    public class TestDecodeCardState
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
        /// Tests decoding a Face Up Card State byte.
        /// </summary>
        [Test]
        public void DecodeFaceUp()
        {
            Assert.AreEqual(this.decoder.DecodeCardState(0x01), "Face Up");
        }

        /// <summary>
        /// Tests decoding a FaceDown Card State byte.
        /// </summary>
        [Test]
        public void DecodeFaceDown()
        {
            Assert.AreEqual(this.decoder.DecodeCardState(0x00), "Face Down");
        }

        /// <summary>
        /// Tests decoding an Invalid Card State byte.
        /// </summary>
        [Test]
        public void DecodeInvalidCardState()
        {
            Assert.AreEqual(this.decoder.DecodeCardState(0x21), "Invalid Card State (0x21)");
            Assert.AreEqual(this.decoder.DecodeCardState(0xAA), "Invalid Card State (0xAA)");
        }
    }
}