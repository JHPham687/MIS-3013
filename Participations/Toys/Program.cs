using System;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of the toy you are looking for");
            string name = Console.ReadLine();
            Console.WriteLine("\nPlease enter the name of the manufacturer");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("\nPlease enter the price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter any special notes");
            string notes = Console.ReadLine();

            Toy newToy = new Toy();
            Console.WriteLine(newToy);



            Console.ReadKey();
        }
    }
}
