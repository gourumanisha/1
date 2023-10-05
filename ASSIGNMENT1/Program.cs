using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            Console.Write("Input the First Number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            // Swap the numbers
            (firstNumber, secondNumber) = (secondNumber, firstNumber);

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + firstNumber);
            Console.WriteLine("Second Number: " + secondNumber);
            Console.ReadLine();
        }
    }
}
