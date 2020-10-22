using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an animal. Valid answers are 'dog', 'cat' and 'goat'.");

            string animal = Console.ReadLine();
            string s = Speak(animal.ToLower());
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static string Speak(string answer)
        {

            if (answer == "dog")
            {
                return ("bark");
            }
            else if (answer == "cat")
            {
                return ("meow");
            }
            else if (answer == "goat")
            {
                return ("bahh");
            }
            else
            {
                return("That is not a valid input");
            }
        }
    }
}
