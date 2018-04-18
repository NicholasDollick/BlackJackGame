using System.Drawing;


namespace BlackJackGame
{
    class Card
    {
        private string type, suit;
        private int value;
        private Image cardImage;


        public Card(string suit, string type, int value, Image cardImage)
        {
            this.suit = suit;
            this.type = type;
            this.value = value;
            this.cardImage = cardImage;
        }

        public int getCardValue()
        {
            return value;
        }

        public string toString()
        {
            return (type + " of " + suit);
        }

        public Image getCardImage()
        {
            return cardImage;
        }
        
        public void UpdateCardImage(string imagePath, string fileName)
        {
            this.cardImage = Image.FromFile(imagePath + fileName + ".jpg");
        }
    }
}
