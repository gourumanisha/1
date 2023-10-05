using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Seventhprogram
    { 
        static void Main()
        {
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                int tripleSum = 3 * sum;
                Console.WriteLine("The two integers are equal, and the triple of their sum is: " + tripleSum);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The sum of the two integers is: " + sum);
                Console.ReadLine();
            }
        }
    }

}
