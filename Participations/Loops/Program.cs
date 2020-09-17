using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the minimum number?");
            int minresponse = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the maximum number?");
            int maxresponse = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int number = rnd.Next(minresponse, maxresponse + 1);
            int guess = 0;

            do
            {
                Console.WriteLine("What is the random number generated?");
                guess = Convert.ToInt32(Console.ReadLine());

            } while (number != guess);

            Console.WriteLine("You guessed the correct number! :D");
            Console.ReadKey();

        }
    }
}
