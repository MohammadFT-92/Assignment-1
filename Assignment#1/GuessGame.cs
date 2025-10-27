using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class GuessGame
    {
        public static void GuesGame()
        {
            Random rnd = new Random();
            int secretnum = rnd.Next(1,1000);
            int attempts = 10;
            bool guessed = false;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Welcom To The Guess Game");
            Console.WriteLine("I have Chosen a Number between 1 To 1000");
            Console.WriteLine("You Are Going to try To find my Number");
            Console.WriteLine("You have 10 attempts");
            

            for (int i = 0; i <= attempts; i++)
            {
                Console.WriteLine("Attemtps " + i + " : Guess The Number :");
                int guess;

                //next line is to make sure the user enter a integer
                if(!int.TryParse(Console.ReadLine(), out guess ))
                {
                    Console.WriteLine("Invalid Input, Enter valid integer");
                    i--; //this to not count the invalid attempts
                    continue;
                }
                if (guess == secretnum)
                {
                    Console.WriteLine("Congrats");
                    Console.WriteLine("You have Won");
                    guessed = true;
                    break;
                }
                else if ( guess > secretnum)
                {
                    Console.WriteLine("Your number is Higher");

                }
                else
                {
                    Console.WriteLine("Your number is Lower");
                }

                //next code is hint in the 7th attempts 
                if (i == 7)
                {
                    int rangeSize = 10;
                    int lower = secretnum - rnd.Next(0,10);
                    int upper = secretnum + rnd.Next(0,10);
                    Console.WriteLine($"Hint !!!!   My number is between {lower} and {upper}");
                }
            }

            if (!guessed)
            {
                Console.WriteLine($"Out of attempts. My number is {secretnum}");
            }

        }
    }
}
