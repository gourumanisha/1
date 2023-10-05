using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Eighthprogram
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                double result = 2 * difference;
                Console.WriteLine("Double the absolute difference: " + result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Absolute difference: " + difference);
                Console.ReadLine();
            }
        }
    }
}
