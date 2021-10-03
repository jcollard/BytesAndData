namespace FiveTwoOneOneDecoder
{
    using System;

    /// <summary>
    /// This interface defines the methods necessary to create a FiveTwoOneOneDecoder.
    /// </summary>
    public interface IFiveTwoOneOneDecoder
    {
        /// <summary>
        /// Given a 5211 card encoded as a byte, this method decodes the top 4
        /// bits as a color.
        /// </summary>
        ///
        /// <para>
        /// Colors are enumerated: Yellow, Green, Blue, Orange,
        /// Black.
        /// </para>
        /// <para>
        /// If a Color code is out of bounds, returns "Invalid Color"
        /// followed by the cardData byte as a hexadecimal string wrapped in
        /// parenthesis.
        /// </para>
        ///
        /// <example>
        /// Examples:
        /// <code>
        /// Assert.AreEqual(this.decoder.DecodeColor(0x00), "Yellow");
        /// Assert.AreEqual(this.decoder.DecodeColor(0x13), "Green");
        /// Assert.AreEqual(this.decoder.DecodeColor(0x27), "Blue");
        /// Assert.AreEqual(this.decoder.DecodeColor(0x35), "Orange");
        /// Assert.AreEqual(this.decoder.DecodeColor(0x46), "Black");
        /// Assert.AreEqual(this.decoder.DecodeColor(0xB6), "Invalid Color
        /// (0xB6)");
        /// </code>
        /// </example>
        ///
        /// <param name="cardData">A 5211 card encoded as a byte.</param>
        /// <returns>A string representation of the cards color.</returns>
        public string DecodeColor(byte cardData);

        /// <summary>
        /// Given a 5211 card encoded as a byte, this method decodes the bottom 4 bits as a value.
        /// </summary>
        /// <para>
        /// Values are enumerated: Rooster, Two, Three, Four, Five, Six.
        /// </para>
        /// <para>
        /// If the Value code is out of bounds, returns "Invalid Value" followed by the cardData byte
        /// as a hexadecimal string wrapped in paranthesis.
        /// </para>
        ///
        /// <example>
        /// Examples:
        /// <code>
        /// Assert.AreEqual(this.decoder.DecodeValue(0x21), "Rooster");
        /// Assert.AreEqual(this.decoder.DecodeValue(0x22), "Two");
        /// Assert.AreEqual(this.decoder.DecodeValue(0x43), "Three");
        /// Assert.AreEqual(this.decoder.DecodeValue(0x14), "Four");
        /// Assert.AreEqual(this.decoder.DecodeValue(0x15), "Five");
        /// Assert.AreEqual(this.decoder.DecodeValue(0x36), "Six");
        /// Assert.AreEqual(this.decoder.DecodeValue(0x4A), "Invalid Value (0x4A)");
        /// </code>
        /// </example>
        ///
        /// <param name="cardData">A 5211 card encoded as a byte.</param>
        /// <returns>A string representation of the cards value.</returns>
        public string DecodeValue(byte cardData);

        /// <summary>
        /// Given a byte containing an encoded 5211 card, this method returns a string containing the
        /// cards color and value.
        /// </summary>
        ///
        /// <example>
        /// Examples:
        /// <code>
        /// Assert.AreEqual(this.decoder.DecodeCard(0x03), "Yellow Three");
        /// Assert.AreEqual(this.decoder.DecodeCard(0x15), "Green Five");
        /// Assert.AreEqual(this.decoder.DecodeCard(0x21), "Blue Rooster");
        /// Assert.AreEqual(this.decoder.DecodeCard(0x34), "Orange Four");
        /// Assert.AreEqual(this.decoder.DecodeCard(0x42), "Black Two");
        /// </code>
        /// </example>
        ///
        /// <param name="cardData">A 5211 card encoded as a byte.</param>
        /// <returns>A string representation of the card.</returns>
        public string DecodeCard(byte cardData);

        /// <summary>
        /// Given a byte array containing 8 bytes encoding a 5211 player's hand, this method returns a string containing the
        /// cards in the players hand.
        /// </summary>
        ///
        /// <example>
        /// Examples:
        /// <code>
        /// byte[] hand = { 0x00, 0x00, 0x00, 0x01, 0x25, 0x34, 0x31, 0x43 };
        /// string expected = "Yellow Rooster, Blue Five, Orange Four, Orange Rooster, Black Three";
        /// Assert.AreEqual(this.decoder.DecodeHand(hand), expected);
        /// </code>
        /// <code>
        /// byte[] hand = { 0x00, 0x00, 0x00, 0x22, 0x33, 0x04, 0x12, 0x06 };
        /// string expected = "Blue Two, Orange Three, Yellow Four, Green Two, Yellow Six";
        /// Assert.AreEqual(this.decoder.DecodeHand(hand), expected);
        /// </code>
        /// </example>
        ///
        /// <param name="data">An 8 byte array encoding a 5211 player hand.</param>
        /// <returns>A string representation of the player hand.</returns>
        public string DecodeHand(byte[] data);

        /// <summary>
        /// Given a 5211 card state encoded as a byte, returns "Face Up", "Face Down", or "Invalid Card State (0x??)".
        /// </summary>
        ///
        /// <example>
        /// Examples:
        /// <code>
        /// Assert.AreEqual(this.decoder.DecodeCardState(0x01), "Face Up");
        /// Assert.AreEqual(this.decoder.DecodeCardState(0x00), "Face Down");
        /// Assert.AreEqual(this.decoder.DecodeCardState(0xAA), "Invalid Card State (0xAA)");
        /// </code>
        /// </example>
        /// <param name="cardState">A 5211 card state encoded byte.</param>
        /// <returns>A string representation of the card state.</returns>
        public string DecodeCardState(byte cardState); // Placement?

        /// <summary>
        /// Given a 5211 card state encoded byte and a byte encoding a 5211 card, this method returns a string representation of the card state and card.
        /// </summary>
        ///
        /// <example>
        /// Examples:
        /// <code>
        /// Assert.AreEqual(this.decoder.DecodeCardPair(0x00, 0x34), "Face Down Orange Four");
        /// Assert.AreEqual(this.decoder.DecodeCardPair(0x01, 0x22), "Face Up Blue Two");
        /// Assert.AreEqual(this.decoder.DecodeCardPair(0x00, 0x00), "No Card");
        /// </code>
        /// </example>
        ///
        /// <param name="cardState">A byte encoded 5211 Card State.</param>
        /// <param name="cardData">A byte encoded 5211 Card.</param>
        /// <returns>A string representation of the decoded card pair.</returns>
        public string DecodeCardPair(byte cardState, byte cardData); // Card Space? Board Space?

        /// <summary>
        /// Given a byte array of 8 bytes encoding a 5211 Player Board, returns a string representation of the board.
        /// </summary>
        /// <example>
        /// Examples:
        /// <code>
        /// byte[] board = { 0x00, 0x01, 0x00, 0x25, 0x00, 0x00, 0x00, 0x00 };
        /// string expected = "Face Down Yellow Rooster, Face Down Blue Five, No Card, No Card";
        /// Assert.AreEqual(this.decoder.DecodeBoard(board), expected);
        /// </code>
        /// <code>
        /// byte[] board = { 0x01, 0x01, 0x01, 0x25, 0x00, 0x33, 0x00, 0x00 };
        /// string expected = "Face Up Yellow Rooster, Face Up Blue Five, Face Down Orange Three, No Card";
        /// Assert.AreEqual(this.decoder.DecodeBoard(board), expected);
        /// </code>
        /// <code>
        /// byte[] board = { 0x01, 0x01, 0x01, 0x25, 0x01, 0x33, 0x01, 0x41 };
        /// string expected = "Face Up Yellow Rooster, Face Up Blue Five, Face Up Orange Three, Face Up Black Rooster";
        /// Assert.AreEqual(this.decoder.DecodeBoard(board), expected);
        /// </code>
        /// </example>
        ///
        /// <param name="data">An array of 16 bytes containing a 5211 Board.</param>
        /// <returns>A string representation of the decoded board.</returns>
        public string DecodeBoard(byte[] data);

        /// <summary>
        /// Given a string label for a player and a byte array of 16 bytes, return a two line string
        /// containing a string representation of the player's board and hand. The first line The first line
        /// contiains the player's hand and the second line contains the player's board.
        /// </summary>
        ///
        /// <example>
        /// Examples:
        /// <code>
        /// byte[] player = {
        ///      0x00, 0x00, 0x00, 0x01, 0x22, 0x33, 0x41, 0x23,
        ///      0x00, 0x01, 0x00, 0x25, 0x00, 0x00, 0x00, 0x00
        ///  };
        ///
        /// string expected =
        /// "Billy's Hand: Yellow Rooster, Blue Two, Orange Three, Black Rooster, Blue Three\n" +
        /// "Billy's Board: Face Down Yellow Rooster, Face Down Blue Five, No Card, No Card";
        ///
        /// Assert.AreEqual(this.decoder.DecodePlayer("Billy's", player), expected);
        /// </code>
        ///
        /// <code>
        /// byte[] player = {
        ///      0x00, 0x00, 0x00, 0x01, 0x22, 0x12, 0x41, 0x23,
        ///      0x01, 0x01, 0x01, 0x25, 0x00, 0x33, 0x00, 0x00
        ///  };
        ///
        /// string expected =
        /// "Sally's Hand: Yellow Rooster, Blue Two, Green Two, Black Rooster, Blue Three\n" +
        /// "Sally's Board: Face Up Yellow Rooster, Face Up Blue Five, Face Down Orange Three, No Card";
        ///
        /// Assert.AreEqual(this.decoder.DecodePlayer("Sally's", player), expected);
        /// </code>
        ///
        /// <code>
        /// byte[] player = {
        ///      0x00, 0x00, 0x00, 0x01, 0x22, 0x12, 0x22, 0x23,
        ///      0x01, 0x01, 0x01, 0x25, 0x01, 0x33, 0x01, 0x41
        ///  };
        ///
        /// string expected =
        /// "Betty's Hand: Yellow Rooster, Blue Two, Green Two, Blue Two, Blue Three\n" +
        /// "Betty's Board: Face Up Yellow Rooster, Face Up Blue Five, Face Up Orange Three, Face Up Black Rooster";
        ///
        /// Assert.AreEqual(this.decoder.DecodePlayer("Betty's", player), expected);
        /// </code>
        /// </example>
        ///
        /// <param name="label">A label to use as the players name.</param>
        /// <param name="data">A 16 byte array containing a 5211 encoded player board.</param>
        /// <returns>A string representation of the player's board.</returns>
        public string DecodePlayer(string label, byte[] data);

        /// <summary>
        /// Given two string labels and an array of 32 bytes encoding 2 5211 player boards, returns a
        /// string representation of the game state. The first two lines contain the first players board state
        /// and the second two lines contain the second players board state.
        /// </summary>
        ///
        /// <example>
        /// Example:
        /// <code>
        /// byte[] player = {
        ///      0x00, 0x00, 0x00, 0x01, 0x23, 0x33, 0x41, 0x23,
        ///      0x01, 0x01, 0x01, 0x05, 0x00, 0x00, 0x00, 0x00,
        ///      0x00, 0x00, 0x00, 0x11, 0x21, 0x34, 0x44, 0x36,
        ///      0x01, 0x01, 0x01, 0x25, 0x00, 0x00, 0x00, 0x00
        /// };
        ///
        /// string expected =
        /// "Bimmy's Hand: Yellow Rooster, Blue Three, Orange Three, Black Rooster, Blue Three\n" +
        /// "Bimmy's Board: Face Up Yellow Rooster, Face Up Yellow Five, No Card, No Card\n" +
        /// "Jimmy's Hand: Green Rooster, Blue Rooster, Orange Four, Black Four, Orange Six\n" +
        /// "Jimmy's Board: Face Up Yellow Rooster, Face Up Blue Five, No Card, No Card";
        ///
        /// Assert.AreEqual(this.decoder.DecodeTwoPlayer("Bimmy's", "Jimmy's", player), expected);
        /// </code>
        /// </example>
        ///
        /// <param name="player1Label">The first player's label.</param>
        /// <param name="player2Label">The second player's label.</param>
        /// <param name="data">A 32 byte array containing 2 5211 encoded player boards.</param>
        /// <returns>A string representation of the player's board.</returns>
        public string DecodeTwoPlayer(string player1Label, string player2Label, byte[] data);
    }
}
