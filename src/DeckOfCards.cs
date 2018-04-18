using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class DeckOfCards
    {
        private Card[] deck;
        private int currentCard;
        public const string imagePath = @"Cards/";
        Image img;

        public DeckOfCards()
        {
            string[] faces = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
            int[] cardValue = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            string[] suits = { "club", "heart", "spade", "diamond" };
            int counter = 1;

            deck = new Card[52];

            for(int suit = 0; suit < 4; suit++)
            {
                for(int face = 0; face < 13; face++)
                {
                    deck[face + (suit * 13)] = new Card(suits[suit], faces[face], cardValue[face], img = Image.FromFile(imagePath + counter.ToString() + ".jpg"));
                    counter++;
                }
            }
        }

        /**
          * shuffles the deck
        */
        public void shuffle()
        {
            currentCard = 0;

            //Random rand = new Random();

            for (int i = 0; i < deck.Length; i++)
            {
                //int randomInt = rand.Next(52);
                int randomInt = IntFromRNG(0, 52);
                Card temp = deck[i];
                deck[i] = deck[randomInt];
                deck[randomInt] = temp;
            }
        }

        /**
          * generate a cryptographically secure random number
         */
        public int IntFromRNG(int min, int max)
        {
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            byte[] byteArray = new byte[4];
            rand.GetBytes(byteArray);

            UInt32 scale = BitConverter.ToUInt32(byteArray, 0);

            return (int)(min + (max - min) * (scale / (uint.MaxValue + 1.0)));
        }

        /**
          * returns the next card in deck 
        */
        public Card dealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }

        public int Size()
        {
            return deck.Length;
        }


    }

}
