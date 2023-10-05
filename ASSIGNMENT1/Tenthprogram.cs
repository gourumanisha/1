using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASSIGNMENT1
{
    internal class Tenthprogram
    {
        static void Main()
        {
            Console.Write("Enter marks for Subject 1: ");
            int subject1Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 2: ");
            int subject2Marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 3: ");
            int subject3Marks = Convert.ToInt32(Console.ReadLine());

            int totalMarks = subject1Marks + subject2Marks + subject3Marks;
            double percentage = (totalMarks / 300.0) * 100;

            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage}%");

            if (percentage >= 60)
            {
                Console.WriteLine("Grade: First Class");
                Console.ReadLine();
            }
            else if (percentage >= 45)
            {
                Console.WriteLine("Grade: Second Class");
                Console.ReadLine();
            }
            else if (percentage >= 35)
            {
                Console.WriteLine("Grade: Third Class");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Grade: Fail");
                Console.ReadLine();
            }
        }
    }
    
  }
