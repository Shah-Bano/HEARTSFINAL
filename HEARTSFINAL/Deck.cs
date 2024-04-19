using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author : Adam
namespace HEARTSFINAL
{
    internal class Deck
    {
        // Array that is the deck of card objects
        private Card[] deck;

        // Constant for deck size
        private const int DECK_SIZE = 52;

        public int DeckSize { get; internal set; }

        // Parametrized constructor
        public Deck()
        {
            // Initialize deck and shuffle
            deck = new Card[DECK_SIZE];
            GenerateDeck();
            Shuffle();
        }

        // Generates a deck of cards
        private void GenerateDeck()
        {
            int index = 0;
            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                for (int value = 2; value <= 14; value++) // 2 to Ace
                {
                    deck[index++] = new Card(suit, value);
                }
            }
        }

        // Shuffles the deck by randomizing the order of the elements in the deck array
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < DECK_SIZE; i++)
            {
                int randomIndex = random.Next(i, DECK_SIZE);
                Card temp = deck[i];
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
        }

        // Deals a card from the deck
        public Card DealCard()
        {
            // Check if there are cards remaining in the deck
            if (deck.Length == 0)
            {
                throw new InvalidOperationException("Deck is empty.");
            }

            // Get the top card from the deck
            Card dealtCard = deck[deck.Length - 1];

            // Remove the card from the deck
            Array.Resize(ref deck, deck.Length - 1);

            return dealtCard;
        }
    }
}

