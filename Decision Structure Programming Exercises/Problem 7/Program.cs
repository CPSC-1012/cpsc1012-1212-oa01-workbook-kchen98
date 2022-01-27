/*  Purpose:    Simulate picking a card from a deck of 52 cards.
 *  
 *  Input:  integer from 1 to 52
 *  
 *  Output: card value and suit
 *  
 *  Algorithm:  Step 1: Prompt the user to enter an integer from 1 to 52.
 *              Step 2: Use if statement to determine the suit of the card.
 *              Step 3: Use switch statement to determine the value of the card.
 *              Step 4: Displays the card value and suit.
 * */
using System;

namespace Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an integer from 1 to 52.
            Console.Write("Pick a card from 52 cards enter the number (1 - 52): ");
            int userCard = int.Parse(Console.ReadLine());

            // Use if statement to determine the suit of the card.
            string cardSuit;
            if (userCard >= 1 && userCard <= 13)
            {
                cardSuit = "Clubs";
            }
            else if (userCard >= 14 && userCard <= 26)
            {
                cardSuit = "Spades";
            }
            else if (userCard >= 27 && userCard <= 39)
            {
                cardSuit = "Hearts";
            }
            else if (userCard >= 40 && userCard <=52)
            {
                cardSuit = "Diamonds";
            }
            else
            {
                cardSuit = "Invalid Input";
            }

            // Use switch statement to determine the value of the card.
            string cardValue;
            switch (userCard)
            {
                case 1:
                case 14:
                case 27:
                case 40:
                    cardValue = "Ace";
                    break;
                case 2:
                case 15:
                case 28:
                case 41:
                    cardValue = "2";
                    break;
                case 3:
                case 16:
                case 29:
                case 42:
                    cardValue = "3";
                    break;
                case 4:
                case 17:
                case 30:
                case 43:
                    cardValue = "4";
                    break;
                case 5:
                case 18:
                case 31:
                case 44:
                    cardValue = "5";
                    break;
                case 6:
                case 19:
                case 32:
                case 45:
                    cardValue = "6";
                    break;
                case 7:
                case 20:
                case 33:
                case 46:
                    cardValue = "7";
                    break;
                case 8:
                case 21:
                case 34:
                case 47:
                    cardValue = "8";
                    break;
                case 9:
                case 22:
                case 35:
                case 48:
                    cardValue = "9";
                    break;
                case 10:
                case 23:
                case 36:
                case 49:
                    cardValue = "10";
                    break;
                case 11:
                case 24:
                case 37:
                case 50:
                    cardValue = "Jack";
                    break;
                case 12:
                case 25:
                case 38:
                case 51:
                    cardValue = "Queen";
                    break;
                case 13:
                case 26:
                case 39:
                case 52:
                    cardValue = "King";
                    break;
                default:
                    cardValue = "";
                    break;
            }

            // Displays the card value and suit.
            Console.WriteLine($"The card you picked is {cardValue} of {cardSuit}");
        }
    }
}
