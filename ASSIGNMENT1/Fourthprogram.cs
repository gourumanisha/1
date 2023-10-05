using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Fourthprogram
    {

        static void Main()
        {
            double x, y, z;

            Console.Write("Enter first number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third number: ");
            z = Convert.ToDouble(Console.ReadLine());

            double result1 = (x + y) * z;
            double result2 = (x * y) + (y * z);

            Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");
            Console.ReadLine();
        }
    }
}
    

