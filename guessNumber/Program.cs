using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Random rand = new Random();
            while (true)
            {
                number = rand.Next(0, 10);
                Console.Write("Guess the mystery number: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == number)
                {
                    Console.WriteLine("You guessed it! Victory!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("You were wrong!");
                    Console.WriteLine("The mystery number was " + number);
                    break;
                }
            }
        }
    }
}
