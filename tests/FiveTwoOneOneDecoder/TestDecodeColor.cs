namespace FiveTwoOneOneDecoder
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> Decode Color method.
    /// </summary>
    public class TestDecodeColor
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
        /// Tests decoding a "Green" card encoding.
        /// </summary>
        [Test]
        public void DecodeColorYellow()
        {
            Assert.AreEqual(this.decoder.DecodeColor(0x00), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x01), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x02), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x03), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x04), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x05), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x06), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x07), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x08), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x09), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x0A), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x0B), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x0C), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x0D), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x0E), "Yellow");
            Assert.AreEqual(this.decoder.DecodeColor(0x0F), "Yellow");
        }

        /// <summary>
        /// Tests decoding a Green card encoding.
        /// </summary>
        [Test]
        public void DecodeColorGreen()
        {
            Assert.AreEqual(this.decoder.DecodeColor(0x10), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x11), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x12), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x13), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x14), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x15), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x16), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x17), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x18), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x19), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x1A), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x1B), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x1C), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x1D), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x1E), "Green");
            Assert.AreEqual(this.decoder.DecodeColor(0x1F), "Green");
        }

        /// <summary>
        /// Tests decoding a Blue card encoding.
        /// </summary>
        [Test]
        public void DecodeColorBlue()
        {
            Assert.AreEqual(this.decoder.DecodeColor(0x20), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x21), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x22), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x23), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x24), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x25), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x26), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x27), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x28), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x29), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x2A), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x2B), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x2C), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x2D), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x2E), "Blue");
            Assert.AreEqual(this.decoder.DecodeColor(0x2F), "Blue");
        }

        /// <summary>
        /// Tests decoding an Orange card encoding.
        /// </summary>
        [Test]
        public void DecodeOrange()
        {
            Assert.AreEqual(this.decoder.DecodeColor(0x30), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x31), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x32), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x33), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x34), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x35), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x36), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x37), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x38), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x39), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x3A), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x3B), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x3C), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x3D), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x3E), "Orange");
            Assert.AreEqual(this.decoder.DecodeColor(0x3F), "Orange");
        }

        /// <summary>
        /// Tests decoding a Black card encoding.
        /// </summary>
        [Test]
        public void DecodeColorBlack()
        {
            Assert.AreEqual(this.decoder.DecodeColor(0x40), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x41), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x42), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x43), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x44), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x45), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x46), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x47), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x48), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x49), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x4A), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x4B), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x4C), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x4D), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x4E), "Black");
            Assert.AreEqual(this.decoder.DecodeColor(0x4F), "Black");
        }

        /// <summary>
        /// Tests decoding an invalid color card encoding.
        /// </summary>
        [Test]
        public void DecodeColorInvalid()
        {
            Assert.AreEqual(this.decoder.DecodeColor(0x50), "Invalid Color (0x50)");
            Assert.AreEqual(this.decoder.DecodeColor(0x61), "Invalid Color (0x61)");
            Assert.AreEqual(this.decoder.DecodeColor(0x72), "Invalid Color (0x72)");
            Assert.AreEqual(this.decoder.DecodeColor(0x83), "Invalid Color (0x83)");
            Assert.AreEqual(this.decoder.DecodeColor(0x94), "Invalid Color (0x94)");
            Assert.AreEqual(this.decoder.DecodeColor(0xA5), "Invalid Color (0xA5)");
            Assert.AreEqual(this.decoder.DecodeColor(0xB6), "Invalid Color (0xB6)");
            Assert.AreEqual(this.decoder.DecodeColor(0xC7), "Invalid Color (0xC7)");
            Assert.AreEqual(this.decoder.DecodeColor(0xD8), "Invalid Color (0xD8)");
            Assert.AreEqual(this.decoder.DecodeColor(0xE9), "Invalid Color (0xE9)");
            Assert.AreEqual(this.decoder.DecodeColor(0xFA), "Invalid Color (0xFA)");
            Assert.AreEqual(this.decoder.DecodeColor(0x5B), "Invalid Color (0x5B)");
            Assert.AreEqual(this.decoder.DecodeColor(0x6C), "Invalid Color (0x6C)");
            Assert.AreEqual(this.decoder.DecodeColor(0x7D), "Invalid Color (0x7D)");
            Assert.AreEqual(this.decoder.DecodeColor(0x8E), "Invalid Color (0x8E)");
            Assert.AreEqual(this.decoder.DecodeColor(0x9F), "Invalid Color (0x9F)");
        }
    }
}