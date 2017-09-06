﻿using System;
namespace Hello
{
    /// <summary>
    /// A simple example of Blackjack card game
    /// </summary>
    class BlackJack
    {
        public static void PlayBlackjack()
        {
            int myNumber = 17;
            int theirNumber;
            System.Console.WriteLine("*** BlackJack! ***");
            System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
            //reading and converting 
            theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
            //comparing that given umber is valid
            if (theirNumber < 1 || theirNumber > 21)
            {
                Console.WriteLine("The given number is out of limits, try again.");
            }
            else
            {
                //comparing
                if (theirNumber >= myNumber && theirNumber <= 21)
                {
                    System.Console.WriteLine("You win.");
                }
                else
                {
                    System.Console.WriteLine("You lose.");
                }
            }
        }
    }
}