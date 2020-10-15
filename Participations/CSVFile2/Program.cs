using System;
using System.IO;

namespace CSVFile2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filepath);


            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string name = pieces[4];
                string transactionDate = pieces[0];
                string country = pieces[7];
                string paymentType = pieces[3];

                if (pieces[3] == "Visa" && pieces[7] == "United States")
                {
                    Console.Write(transactionDate);
                    Console.WriteLine(" " + name);
                }
            }

 
            Console.ReadKey();
        }
    }
}
