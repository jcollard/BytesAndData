namespace BytesAndData
{
    using NUnit.Framework;

    /// <summary>
    /// Tests <see cref="IFiveTwoOneOneDecoder"/> DecodeTwoPlayer method.
    /// </summary>
    public class TestDecodeTwoPlayer
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
        public void DecodeTwoPlayerBillyBobby()
        {
            byte[] player = {
                 0x00, 0x00, 0x00, 0x01, 0x23, 0x33, 0x41, 0x23,
                 0x01, 0x01, 0x01, 0x05, 0x00, 0x00, 0x00, 0x00,
                 0x00, 0x00, 0x00, 0x11, 0x21, 0x34, 0x44, 0x36,
                 0x01, 0x01, 0x01, 0x25, 0x00, 0x00, 0x00, 0x00
            };

            string expected =
            "Bimmy's Hand: Yellow Rooster, Blue Three, Orange Three, Black Rooster, Blue Three\n" +
            "Bimmy's Board: Face Up Yellow Rooster, Face Up Yellow Five, No Card, No Card\n" +
            "Jimmy's Hand: Green Rooster, Blue Rooster, Orange Four, Black Four, Orange Six\n" +
            "Jimmy's Board: Face Up Yellow Rooster, Face Up Blue Five, No Card, No Card";

            Assert.AreEqual(this.decoder.DecodeTwoPlayer("Bimmy's", "Jimmy's", player), expected);
        }
    }
}