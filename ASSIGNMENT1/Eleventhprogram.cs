using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Eleventhprogram
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double max = Math.Max(num1, num2);
            double min = Math.Min(num1, num2);

            Console.WriteLine($"Maximum of {num1} and {num2} is: {max}");
            Console.WriteLine($"Minimum of {num1} and {num2} is: {min}");
            Console.ReadLine();
        }
    }
}
