using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame
{
    class Person
    {
        private List<PictureBox> cardImages;
        private List<Card> hand;
        private int handSum = 0;


        public Person()
        {
            this.hand = new List<Card>();
            this.cardImages = new List<PictureBox>();

        }

        public void AddToHand(Card card)
        {
            hand.Add(card);
        }

        public int HandValue()
        {
           
            return handSum;
        }

        public void ClearHand()
        {
            foreach (PictureBox img in cardImages) ;
        }

    }
}
