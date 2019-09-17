//Clinton Carter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite word >>?");
            string answer = Console.ReadLine().ToUpper().Trim();
            string anotherString = "Something else";
            string answerAsBIGLETTERS = answer.ToUpper();

            for (int i = 0; i < answerAsBIGLETTERS.Length; i++)
            {
                Console.Write(answerAsBIGLETTERS[i] + " ");

            }

            Console.WriteLine($"Your favotie word has {answer.Length} characters in it");
            

            Console.ReadKey();
        }
    }
}
