using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BlackJackGame
{
    public partial class Game : Form
    {
        private List<PictureBox> playerCardImages = new List<PictureBox>(), dealerCardImages = new List<PictureBox>();
        private List<Card> dealerHand = new List<Card>(), playerHand = new List<Card>();
        private DeckOfCards deck = new DeckOfCards();
        private Image temp;
        public const string imagePath = @"Cards/";
        private int playerSum, dealerSum;
        private int initialState = 0, count = 0;
        string name = LoginContainer.GetPlayerName();

        public Game()
        {
            InitializeComponent();
            label5.Text = name;
            trainerOff.Checked = true;
            trainerLabel.Text = "";
            idealMoveLabel.Visible = false;
        }

        private void Play()
        {
            deck = new DeckOfCards();

            hitButton.Enabled = true;
            standButton.Enabled = true;
            startButton.Enabled = false;

            playerHand.Clear();
            dealerHand.Clear();
            ClearHand(playerCardImages);
            ClearHand(dealerCardImages);
            playerCardImages.Clear();
            dealerCardImages.Clear();
            CreateControls(playerHand, "player");
            DisplayPlayerHand();
            initialState = 2;
            count = 0;

            label3.Text = "";

            deck.shuffle();
            deck.shuffle();

            dealerHand.Add(deck.dealCard());
            playerHand.Add(deck.dealCard());
            dealerHand.Add(deck.dealCard());
            playerHand.Add(deck.dealCard());

            label2.Text = dealerHand.ElementAt(1).getCardValue().ToString();

            playerSum = CheckSum(playerHand);
            label1.Text = playerSum.ToString();
            if (playerSum == 21)
            {
                label3.Text = ("You Win");
                hitButton.Enabled = false;
                standButton.Enabled = false;
                startButton.Enabled = true;
            }


            if (trainerOn.Checked)
            {
                idealMoveLabel.Visible = true;
                trainerLabel.Text = Trainer.getMove(playerHand, dealerHand[1]);
            }
            else
            {
                idealMoveLabel.Visible = false;
                trainerLabel.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play();
            splashImage.Visible = false;

            CreateControls(playerHand, "player");
            CreateControls(dealerHand, "dealer");
            temp = dealerCardImages[0].Image;
            dealerCardImages[0].Image = Image.FromFile(imagePath + "back.jpg");
            DisplayDealerHand();
            DisplayPlayerHand();

        }


        private void CreateControls(List<Card> hand, string handID)
        {
            foreach (Card card in hand)
            {
                PictureBox newPictureBox = new PictureBox();
                newPictureBox.Width = 75;
                newPictureBox.Height = 100;
                if (handID.Equals("player"))
                    playerCardImages.Add(SizeImage(newPictureBox, card.getCardImage()));
                if (handID.Equals("dealer"))
                    dealerCardImages.Add(SizeImage(newPictureBox, card.getCardImage()));
            }
        }


        private PictureBox SizeImage(PictureBox pb, Image img)
        {
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.CenterImage;

            return pb;
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            playerHand.Add(deck.dealCard());
            CreateControls(playerHand, "player");
            UpdatePlayerHand(initialState);
            initialState += (3 + count++);

            playerSum = CheckSum(playerHand);
            label1.Text = playerSum.ToString();
            if (trainerOn.Checked && !trainerLabel.Text.Equals("")) //makes sure the trainer cant be turned on midturn
            {
                trainerLabel.Text = Trainer.getMove(playerHand, dealerHand[1]);
            }

            if (playerSum > 21)
            {
                label3.Text = ("You Lose");
                hitButton.Enabled = false;
                standButton.Enabled = false;
                startButton.Enabled = true;
                trainerLabel.Text = "";
            }

            if (playerSum == 21)
            {
                label3.Text = ("You Win");
                hitButton.Enabled = false;
                standButton.Enabled = false;
                startButton.Enabled = true;
                trainerLabel.Text = "";
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            int initialCardCount = 2, counter = 0;
            dealerCardImages[0].Image = temp;
            DisplayDealerHand();
            playerSum = CheckSum(playerHand);
            dealerSum = CheckSum(dealerHand);
            label2.Text = dealerSum.ToString();
            while (dealerSum < 17)
            {

                dealerHand.Add(deck.dealCard());
                CreateControls(dealerHand, "dealer");
                UpdateDealerHand(initialCardCount);
                initialCardCount += (3 + counter);
                dealerSum = CheckSum(dealerHand);
                label2.Text = dealerSum.ToString();

                DisplayDealerHand();
            }

            EndOfTurn(dealerSum, playerSum);
        }


        private void EndOfTurn(int dealer, int player)
        {
            hitButton.Enabled = false;
            standButton.Enabled = false;

            if (dealer > 21)
            {
                label3.Text = ("You Win");
                startButton.Enabled = true;
            }
            else if (dealer > player)
            {
                label3.Text = ("You Lose");
                startButton.Enabled = true;
            }
            else if (player > dealer)
            {
                label3.Text = ("You Win");
                startButton.Enabled = true;
            }
            else if (player == dealer)
            {
                label3.Text = ("Push");
                startButton.Enabled = true;
            }
        }

        private void UpdatePlayerHand(int initial)
        {
            ClearHand(playerCardImages);

            for (int i = playerHand.Count - 1; i >= 0; i--)
            {
                playerCardImages.ElementAt(i + initial).Left = (i * 18) + 100;
                playerCardImages.ElementAt(i + initial).Top = 350;
                this.Controls.Add(playerCardImages[i + initial]);
            }
        }



        private void ClearHand(List<PictureBox> hand)
        {
            foreach (PictureBox img in hand)
                this.Controls.Remove(img);
        }

        private void UpdateDealerHand(int initial)
        {
            ClearHand(dealerCardImages);

            for (int i = dealerHand.Count - 1; i >= 0; i--)
            {
                dealerCardImages.ElementAt(i + initial).Left = (i * 18) + 100;
                dealerCardImages.ElementAt(i + initial).Top = 50;
                this.Controls.Add(dealerCardImages[i + initial]);
            }
        }

        private int CheckSum(List<Card> hand)
        {
            int sum = 0;

            foreach (Card card in hand)
            {
                sum += card.getCardValue();
            }

            foreach (Card card in hand)
            {
                if (card.getCardValue() == 11 && sum > 21)
                    sum -= 10;
            }

            return sum;
        }

        private void DisplayPlayerHand()
        {
            for (int i = playerHand.Count - 1; i >= 0; i--)
            {
                playerCardImages.ElementAt(i).Left = (i * 18) + 100;
                playerCardImages.ElementAt(i).Top = 350;
                this.Controls.Add(playerCardImages[i]);
            }
        }

        private void DisplayDealerHand()
        {
            for (int i = dealerHand.Count - 1; i >= 0; i--)
            {
                dealerCardImages.ElementAt(i).Left = (i * 18) + 100;
                dealerCardImages.ElementAt(i).Top = 50;
                this.Controls.Add(dealerCardImages[i]);
            }
        }

    }
}