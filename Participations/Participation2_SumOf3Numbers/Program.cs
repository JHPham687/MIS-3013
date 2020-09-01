using System;

namespace Participation2_SumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            double FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            double ThirdNumber = Convert.ToDouble(Console.ReadLine());

            double sumAnswer = (FirstNumber + SecondNumber + ThirdNumber);

            double constant = 7.777;

            double mulAnswer = (sumAnswer * constant);

            Console.WriteLine("The sum of these 3 numbers is " +
                sumAnswer.ToString("N3"));

            Console.WriteLine("The sum multiplied by the constant is " +
                mulAnswer.ToString("N3"));



        }
    }
}
