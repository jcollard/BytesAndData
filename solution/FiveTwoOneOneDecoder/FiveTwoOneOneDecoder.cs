namespace FiveTwoOneOneDecoder
{
    using System;

    /// <summary>
    /// This is an implementation of the IFiveTwoOneOneDecoder interface.
    /// </summary>
    public class FiveTwoOneOneDecoder : IFiveTwoOneOneDecoder
    {
        /// <inheritdoc />
        public string DecodeTwoPlayer(string player1Label, string player2Label, byte[] data)
        {
            string playerOne = this.DecodePlayer(player1Label, Support.GetBytes(data, 0, 16));
            string playerTwo = this.DecodePlayer(player2Label, Support.GetBytes(data, 16, 16));
            return $"{playerOne}\n{playerTwo}";
        }

        /// <inheritdoc />
        public string DecodePlayer(string label, byte[] data)
        {
            string hand = this.DecodeHand(Support.GetBytes(data, 0, 8));
            string board = this.DecodeBoard(Support.GetBytes(data, 8, 8));
            return $"{label} Hand: {hand}\n{label} Board: {board}";
        }

        /// <inheritdoc />
        public string DecodeHand(byte[] data)
        {
            return $"{this.DecodeCard(data[3])}, {this.DecodeCard(data[4])}, {this.DecodeCard(data[5])}, {this.DecodeCard(data[6])}, {this.DecodeCard(data[7])}";
        }

        /// <inheritdoc />
        public string DecodeBoard(byte[] data)
        {
            string first = this.DecodeCardPair(data[0], data[1]);
            string second = this.DecodeCardPair(data[2], data[3]);
            string third = this.DecodeCardPair(data[4], data[5]);
            string fourth = this.DecodeCardPair(data[6], data[7]);
            return $"{first}, {second}, {third}, {fourth}";
        }

        /// <inheritdoc />
        public string DecodeCardPair(byte cardState, byte cardData)
        {
            if (cardData == 0)
            {
                return "No Card";
            }

            return $"{this.DecodeCardState(cardState)} {this.DecodeCard(cardData)}";
        }

        /// <inheritdoc />
        public string DecodeCardState(byte cardState)
        {
            if (cardState == 0)
            {
                return "Face Down";
            }

            if (cardState == 1)
            {
                return "Face Up";
            }

            return $"Invalid Card State ({Support.ToHex(cardState)})";
        }

        /// <inheritdoc />
        public string DecodeCard(byte cardData)
        {
            string value = this.DecodeValue(cardData);
            string color = this.DecodeColor(cardData);
            return $"{color} {value}";
        }

        /// <inheritdoc />
        public string DecodeColor(byte cardData)
        {
            byte color = Support.GetTopNibble(cardData);
            if (color == 0)
            {
                return "Yellow";
            }

            if (color == 1)
            {
                return "Green";
            }

            if (color == 2)
            {
                return "Blue";
            }

            if (color == 3)
            {
                return "Orange";
            }

            if (color == 4)
            {
                return "Black";
            }

            return $"Invalid Color ({Support.ToHex(cardData)})";
        }

        /// <inheritdoc />
        public string DecodeValue(byte cardData)
        {
            byte value = Support.GetBottomNibble(cardData);
            if (value == 1)
            {
                return "Rooster";
            }

            if (value == 2)
            {
                return "Two";
            }

            if (value == 3)
            {
                return "Three";
            }

            if (value == 4)
            {
                return "Four";
            }

            if (value == 5)
            {
                return "Five";
            }

            if (value == 6)
            {
                return "Six";
            }

            return $"Invalid Value ({Support.ToHex(cardData)})";
        }
    }
}
