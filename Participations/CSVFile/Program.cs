using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;

namespace CSVFile
{
    class Program
    {
        static void Main(string[] args)
        { 
            string filepath = @"C:\Users\jhpha\Downloads\Fall 2020 MIS 3013\sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filepath);

            /*
            *Sales = 4
            *Status = 6
            *Month = 8
            *Year = 9
            */

            double sum = 0;
            double sumFor2003 = 0;
            double sumFor2004 = 0;
            double sumFor2005 = 0;
            double sumForJan = 0;
            double sumForFeb = 0;
            double sumForMar = 0;
            double sumForApr = 0;
            double sumForMay = 0; 
            double sumForJun = 0;
            double sumForJul = 0;
            double sumForAug = 0;
            double sumForSep = 0;
            double sumForOct = 0;
            double sumForNov = 0;
            double sumForDec = 0;

            for (int i = 1; i < lines.Length; i++)
            { 
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                string month = pieces[8];
                //sum = sum + Convert.ToDouble(pieces[4]);

                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumFor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumFor2004 += sale;
                    }
                    else
                    {
                        sumFor2005 += sale;
                    }
                    sum += sale;
                    if (Convert.ToDouble(month) == 1)
                    {
                        sumForJan += sale;
                    }
                    else if (Convert.ToDouble(month) == 2)
                    {
                        sumForFeb += sale;
                    }
                    else if (Convert.ToDouble(month) == 3)
                    {
                        sumForMar += sale;
                    }
                    else if (Convert.ToDouble(month) == 4)
                    {
                        sumForApr += sale;
                    }
                    else if (Convert.ToDouble(month) == 5)
                    {
                        sumForMay += sale;
                    }
                    else if (Convert.ToDouble(month) == 6)
                    {
                        sumForJun += sale;
                    }
                    else if (Convert.ToDouble(month) == 7)
                    {
                        sumForJul += sale;
                    }
                    else if (Convert.ToDouble(month) == 8)
                    {
                        sumForAug += sale;
                    }
                    else if (Convert.ToDouble(month) == 9)
                    {
                        sumForSep += sale;
                    }
                    else if (Convert.ToDouble(month) == 10)
                    {
                        sumForOct += sale;
                    }
                    else if (Convert.ToDouble(month) == 11)
                    {
                        sumForNov += sale;
                    }
                    else if (Convert.ToDouble(month) == 12)
                    {
                        sumForDec += sale;
                    }

                }
            }
            Console.WriteLine($"The total sales for shipped orders in 2003 is {sumFor2003.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in 2004 is {sumFor2004.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in 2005 is {sumFor2005.ToString("C2")}.");

            Console.WriteLine($"The total sales for shipped orders in January is {sumForJan.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in February is {sumForFeb.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in March is {sumForMar.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in April is {sumForApr.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in May is {sumForMay.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in June is {sumForJun.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in July is {sumForJul.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in August is {sumForAug.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in September is {sumForSep.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in October is {sumForOct.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in November is {sumForNov.ToString("C2")}.");
            Console.WriteLine($"The total sales for shipped orders in December is {sumForDec.ToString("C2")}.");

            Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")}.");
            
            Console.ReadKey();
        }
    }
}
