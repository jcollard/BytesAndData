namespace FiveTwoOneOneDecoder
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> DecodeCard method.
    /// </summary>
    public class TestDecodeCard
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
        /// Tests decoding Yellow Cards.
        /// </summary>
        [Test]
        public void DecodeCardYellowCards()
        {
            Assert.AreEqual(this.decoder.DecodeCard(0x01), "Yellow Rooster");
            Assert.AreEqual(this.decoder.DecodeCard(0x02), "Yellow Two");
            Assert.AreEqual(this.decoder.DecodeCard(0x03), "Yellow Three");
            Assert.AreEqual(this.decoder.DecodeCard(0x04), "Yellow Four");
            Assert.AreEqual(this.decoder.DecodeCard(0x05), "Yellow Five");
            Assert.AreEqual(this.decoder.DecodeCard(0x06), "Yellow Six");
        }

        /// <summary>
        /// Tests decoding Green Cards.
        /// </summary>
        [Test]
        public void DecodeCardGreenCards()
        {
            Assert.AreEqual(this.decoder.DecodeCard(0x11), "Green Rooster");
            Assert.AreEqual(this.decoder.DecodeCard(0x12), "Green Two");
            Assert.AreEqual(this.decoder.DecodeCard(0x13), "Green Three");
            Assert.AreEqual(this.decoder.DecodeCard(0x14), "Green Four");
            Assert.AreEqual(this.decoder.DecodeCard(0x15), "Green Five");
            Assert.AreEqual(this.decoder.DecodeCard(0x16), "Green Six");
        }

        /// <summary>
        /// Tests decoding Green Cards.
        /// </summary>
        [Test]
        public void DecodeCardBlueCards()
        {
            Assert.AreEqual(this.decoder.DecodeCard(0x21), "Blue Rooster");
            Assert.AreEqual(this.decoder.DecodeCard(0x22), "Blue Two");
            Assert.AreEqual(this.decoder.DecodeCard(0x23), "Blue Three");
            Assert.AreEqual(this.decoder.DecodeCard(0x24), "Blue Four");
            Assert.AreEqual(this.decoder.DecodeCard(0x25), "Blue Five");
            Assert.AreEqual(this.decoder.DecodeCard(0x26), "Blue Six");
        }

        /// <summary>
        /// Tests decoding Orange Cards.
        /// </summary>
        [Test]
        public void DecodeCardOrangeCards()
        {
            Assert.AreEqual(this.decoder.DecodeCard(0x31), "Orange Rooster");
            Assert.AreEqual(this.decoder.DecodeCard(0x32), "Orange Two");
            Assert.AreEqual(this.decoder.DecodeCard(0x33), "Orange Three");
            Assert.AreEqual(this.decoder.DecodeCard(0x34), "Orange Four");
            Assert.AreEqual(this.decoder.DecodeCard(0x35), "Orange Five");
            Assert.AreEqual(this.decoder.DecodeCard(0x36), "Orange Six");
        }

        /// <summary>
        /// Tests decoding Black Cards.
        /// </summary>
        [Test]
        public void DecodeCardBlackCards()
        {
            Assert.AreEqual(this.decoder.DecodeCard(0x41), "Black Rooster");
            Assert.AreEqual(this.decoder.DecodeCard(0x42), "Black Two");
            Assert.AreEqual(this.decoder.DecodeCard(0x43), "Black Three");
            Assert.AreEqual(this.decoder.DecodeCard(0x44), "Black Four");
            Assert.AreEqual(this.decoder.DecodeCard(0x45), "Black Five");
            Assert.AreEqual(this.decoder.DecodeCard(0x46), "Black Six");
        }
    }
}