using System;

namespace Coin_Toss
{
    class Program
    {
        const string Developer = "\n -Jo Pham";
        static void Main(string[] args)
        {
            Console.WriteLine("Heads or Tails?");
            string guess = Console.ReadLine();
           
            Random rnd = new Random();
            int number = rnd.Next(0, 2);

            if (number == 0) //0 = Heads
            {
                Console.WriteLine("\n It is Heads");
                if (guess == "Heads")
                {
                    Console.WriteLine("\n You won! :D");
                }
                else if (guess == "Tails")
                {
                    Console.WriteLine("\n You lost. :(");
                }
            }
            else if (number == 1) //1 = Tails
            { 
                Console.WriteLine("\n It is Tails");
                if (guess == "Tails")
                {
                    Console.WriteLine("\n You won! :D");
                }
                else if (guess == "Heads")
                {
                    Console.WriteLine("\n You lost. :(");
                }
                
            }

            Console.WriteLine(Developer);
        }
    }
}
