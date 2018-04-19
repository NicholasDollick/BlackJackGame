using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class Trainer
    {
       private static int[,] valueTable = {
		
		{-128, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11},
        {  17, 0, 0, 0, 0, 0, 0, 0, 0,  0,  0},
        {  16, 0, 0, 0, 0, 0, 1, 1, 1,  1,  1},
        {  15, 0, 0, 0, 0, 0, 1, 1, 1,  1,  1},
        {  14, 0, 0, 0, 0, 0, 1, 1, 1,  1,  1},
        {  13, 0, 0, 0, 0, 0, 1, 1, 1,  1,  1},
        {  12, 1, 1, 0, 0, 0, 1, 1, 1,  1,  1},
        {  11, 1, 1, 1, 1, 1, 1, 1, 1,  1,  1},
        {  10, 1, 1, 1, 1, 1, 1, 1, 1,  1,  1},
        {   9, 1, 1, 1, 1, 1, 1, 1, 1,  1,  1},
        {   8, 1, 1, 1, 1, 1, 1, 1, 1,  1,  1},
        {   7, 1, 1, 1, 1, 1, 1, 1, 1,  1,  1},
        {   6, 1, 1, 1, 1, 1, 1, 1, 1,  1,  1},
        {   5, 1, 1, 1, 1, 1, 1, 1, 1,  1,  1}
        };

            public static int getChartValue(int handVal, int dealerCard)
            {
                int move = 0;

                if (handVal > 17)
                {
                    return move;
                }
                for (int i = 0; i < valueTable.GetLength(0); i++)
                {
                    if (valueTable[i,0] == handVal)
                        for (int j = 0; j < valueTable.GetLength(1); j++)
                        {
                            if (valueTable[0,j] == dealerCard)
                            {
                                move = valueTable[i,j];
                            }
                        }
                }

                return move;
            }

            /*
             * This version of the method is used for AI logic during game
             */
            public static string getMove(List<Card> player, Card dealer)
            {

                int move = getChartValue(CheckSum(player), dealer.getCardValue());
                int dealerValue = dealer.getCardValue();

                if (player[0].getCardValue() == (player[1].getCardValue()) && player.Count == 2)
                {
                    int value = player[0].getCardValue();

                    switch (value)
                    {
                        case (11):
                            return "hit";
                            break;

                        case (10):
                            return "stand";
                        break;

                        case (9):
                            if (dealerValue == 7 || dealerValue == 10 || dealerValue == 11)
                            return "stand";
                        else
                            return "hit";
                        break;

                        case (8):
                            return "hit";
                        break;

                        case (7):
                            if (dealerValue >= 8)
                            return "hit";
                        else
                            return "hit";
                        break;

                        case (6):
                            if (dealerValue >= 7)
                            return "hit";
                        else
                            return "hit";
                        break;

                        case (5):
                            return "hit";
                        break;

                        case (4):
                            if (dealerValue == 5 || dealerValue == 6)
                                return "hit";
                            else
                                return "hit";
                        break;

                        case (3):
                            if (dealerValue >= 8)
                            return "hit";
                        else
                            return "hit";
                        break;

                        case (2):
                            if (dealerValue >= 8)
                            return "hit";
                        else
                            return "hit";
                        break;
                    }
                }

                else if (player.Count == 2 && (player[0].getCardValue() == 11 || player[1].getCardValue() == 11))
                {
                    int value = 0;

                    //get value of the card that isn't the ace
                    if (player[0].getCardValue() == 11)
                        value = player[1].getCardValue();
                    else
                        value = player[0].getCardValue();


                    switch (value)
                    {
                        case (10):
                            return "stand";
                        break;

                        case (9):
                            return "stand";
                        break;

                        case (8):
                            return "stand";
                        break;

                        case (7):
                            if (dealerValue == 2 || dealerValue == 7 || dealerValue == 8)
                                return "stand";
						else
							return "hit";
                        break;

                        case (6):
                            return "hit";
                        break;

                        case (5):
                            return "hit";
                        break;

                        case (4):
                            return "hit";
                        break;

                        case (3):
                            return "hit";
                        break;

                        case (2):
                            return "hit";
                        break;
                    }
                }
                else
                {
                    if (move == 1)
                        return "hit";
                    else if (move == 0)
                        return "stand";
                    else if (move < 0)
                        return "null";
                }
            return "null";
            }
    
    private static int CheckSum(List<Card> hand)
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
}
}
