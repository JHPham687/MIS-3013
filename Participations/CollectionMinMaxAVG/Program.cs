using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionMinMaxAVG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("Please enter your exam grade");
                double examGrade = Convert.ToDouble(Console.ReadLine());

                examGrades.Add(examGrade);

                Console.WriteLine("Do you have another exam grade you want to add?");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            double minGrade = examGrades[1];
            double maxGrade = examGrades[1];

            foreach (var grade in examGrades)
            {
                if (grade <= minGrade)
                {
                    minGrade = grade;
                }
            }
            foreach (var grade in examGrades)
            {
                if (grade >= maxGrade)
                {
                    maxGrade = grade;
                }
            }

            double examGradeSum = examGrades.Sum();
            int examGradeCount = examGrades.Count();

            double examAverage = examGradeSum / examGradeCount;

            Console.WriteLine("Your Maximum Exam Grade is " + maxGrade);
            Console.WriteLine("Your Minimum Exam Grade is " + minGrade);
            Console.WriteLine("Your Average Exam Grade is " + examAverage);

            Console.ReadKey();    
        }
    }
}
