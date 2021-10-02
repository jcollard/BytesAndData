namespace BytesAndData
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> DecodeValue method.
    /// </summary>
    public class TestDecodeValue
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
        /// Tests decoding a Rooster card encoding.
        /// </summary>
        [Test]
        public void DecodeValueRooster()
        {
            Assert.AreEqual(this.decoder.DecodeValue(0x01), "Rooster");
            Assert.AreEqual(this.decoder.DecodeValue(0x11), "Rooster");
            Assert.AreEqual(this.decoder.DecodeValue(0x21), "Rooster");
            Assert.AreEqual(this.decoder.DecodeValue(0x31), "Rooster");
            Assert.AreEqual(this.decoder.DecodeValue(0x41), "Rooster");
        }

        /// <summary>
        /// Tests decoding a Two card encoding.
        /// </summary>
        [Test]
        public void DecodeValueTwo()
        {
            Assert.AreEqual(this.decoder.DecodeValue(0x02), "Two");
            Assert.AreEqual(this.decoder.DecodeValue(0x12), "Two");
            Assert.AreEqual(this.decoder.DecodeValue(0x22), "Two");
            Assert.AreEqual(this.decoder.DecodeValue(0x32), "Two");
            Assert.AreEqual(this.decoder.DecodeValue(0x42), "Two");
        }

        /// <summary>
        /// Tests decoding a Three card encoding.
        /// </summary>
        [Test]
        public void DecodeValueThree()
        {
            Assert.AreEqual(this.decoder.DecodeValue(0x03), "Three");
            Assert.AreEqual(this.decoder.DecodeValue(0x13), "Three");
            Assert.AreEqual(this.decoder.DecodeValue(0x23), "Three");
            Assert.AreEqual(this.decoder.DecodeValue(0x33), "Three");
            Assert.AreEqual(this.decoder.DecodeValue(0x43), "Three");
        }

        /// <summary>
        /// Tests decoding an Four card encoding.
        /// </summary>
        [Test]
        public void DecodeValueFour()
        {
            Assert.AreEqual(this.decoder.DecodeValue(0x04), "Four");
            Assert.AreEqual(this.decoder.DecodeValue(0x14), "Four");
            Assert.AreEqual(this.decoder.DecodeValue(0x24), "Four");
            Assert.AreEqual(this.decoder.DecodeValue(0x34), "Four");
            Assert.AreEqual(this.decoder.DecodeValue(0x44), "Four");
        }

        /// <summary>
        /// Tests decoding a Five card encoding.
        /// </summary>
        [Test]
        public void DecodeValueFive()
        {
            Assert.AreEqual(this.decoder.DecodeValue(0x05), "Five");
            Assert.AreEqual(this.decoder.DecodeValue(0x15), "Five");
            Assert.AreEqual(this.decoder.DecodeValue(0x25), "Five");
            Assert.AreEqual(this.decoder.DecodeValue(0x35), "Five");
            Assert.AreEqual(this.decoder.DecodeValue(0x45), "Five");
        }

        /// <summary>
        /// Tests decoding an Six card encoding.
        /// </summary>
        [Test]
        public void DecodeValueSix()
        {
            Assert.AreEqual(this.decoder.DecodeValue(0x06), "Six");
            Assert.AreEqual(this.decoder.DecodeValue(0x16), "Six");
            Assert.AreEqual(this.decoder.DecodeValue(0x26), "Six");
            Assert.AreEqual(this.decoder.DecodeValue(0x36), "Six");
            Assert.AreEqual(this.decoder.DecodeValue(0x46), "Six");
        }

        /// <summary>
        /// Tests decoding an Invalid Value encoding.
        /// </summary>
        [Test]
        public void DecodeValueInvalid()
        {
            Assert.AreEqual(this.decoder.DecodeValue(0x30), "Invalid Value (0x30)");
            Assert.AreEqual(this.decoder.DecodeValue(0x07), "Invalid Value (0x07)");
            Assert.AreEqual(this.decoder.DecodeValue(0x18), "Invalid Value (0x18)");
            Assert.AreEqual(this.decoder.DecodeValue(0x29), "Invalid Value (0x29)");
            Assert.AreEqual(this.decoder.DecodeValue(0x4A), "Invalid Value (0x4A)");
            Assert.AreEqual(this.decoder.DecodeValue(0x5B), "Invalid Value (0x5B)");
            Assert.AreEqual(this.decoder.DecodeValue(0x6C), "Invalid Value (0x6C)");
            Assert.AreEqual(this.decoder.DecodeValue(0x7D), "Invalid Value (0x7D)");
            Assert.AreEqual(this.decoder.DecodeValue(0x8E), "Invalid Value (0x8E)");
            Assert.AreEqual(this.decoder.DecodeValue(0x9F), "Invalid Value (0x9F)");
        }
    }
}