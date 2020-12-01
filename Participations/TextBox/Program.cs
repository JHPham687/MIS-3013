using System;

namespace TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox textbox1 = new TextBox(1, ConsoleColor.DarkBlue, ConsoleColor.White, "This is text box 1");

            TextBox textbox2 = new TextBox(1, ConsoleColor.Yellow, ConsoleColor.Green, "This is text box 2");

            Console.WriteLine("Write a sentence for textbox 1");
            string response1 = Console.ReadLine();



            Console.ReadKey();

        }
    }
}
