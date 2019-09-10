using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Create a new console application (using the .NET Framework and not .NET Core).  Name your project and solution RandomGuess.  Generate a random number between 1 and 100, using the Random
 (Links to an external site.)
 class.  Prompt the user to guess the random number until they successfully guess it.
 */

            Random rand = new Random();
            int number = rand.Next(1, 101);

            //input
           // Console.WriteLine("Number is " + number);
            Console.WriteLine("Guess a number betweem 1 and 100 >>");
            string guessAsString = Console.ReadLine();
            int asint;

            int guess = Convert.ToInt32(guessAsString);
            bool isSuccess = int.TryParse(guessAsString, out asint);

          




            //loop
            
            if (guess == number)
            {
                Console.WriteLine("Congrats you guessed right");

            }
            else
            {
                Console.WriteLine("Sorry, thats wrong");
             while (guess != number)
                {
                    Console.WriteLine("Guess a number betweem 1 and 100 >>");
                    guessAsString = Console.ReadLine();

                    guess = Convert.ToInt32(guessAsString);
                    isSuccess = int.TryParse(guessAsString, out asint);
                }
                Console.WriteLine("Finally, you guessed right!");
            }

            Console.ReadKey();
        }
    }
}
