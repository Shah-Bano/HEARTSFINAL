using System;
using System.Drawing;

namespace HEARTSFINAL
{
    public class Card
    {
        // Enum for card suits
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        // Properties
        public Suit CardSuit { get; private set; }
        public int Value { get; private set; }

        // Constants
        private const Suit DEFAULT_SUIT = Suit.Hearts;
        private const int DEFAULT_VALUE = 1;

        // Default constructor
        public Card()
        {
            CardSuit = DEFAULT_SUIT;
            Value = DEFAULT_VALUE;
        }

        // Parametrized constructor
        public Card(Suit suit, int value)
        {
            CardSuit = suit;
            Value = value;
        }

        // Override ToString() method for string representation of the card
        public override string ToString()
        {
            string valueString;
            switch (Value)
            {
                case 11:
                    valueString = "Jack";
                    break;
                case 12:
                    valueString = "Queen";
                    break;
                case 13:
                    valueString = "King";
                    break;
                case 14:
                    valueString = "Ace";
                    break;
                default:
                    valueString = Value.ToString();
                    break;
            }

            return $"{valueString} of {CardSuit}";
        }
    }

    public class PlayingCard
    {
        public Card.Suit Suit { get; }
        public int Value { get; }
        public Image Image { get; }

        public PlayingCard(Card.Suit suit, int value, Image image)
        {
            Suit = suit;
            Value = value;
            Image = image;
        }
    }
}
