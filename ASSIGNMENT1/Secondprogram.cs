using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Secondprogram
    {
       
       
            static void Main()
            {
                double firstNumber, secondNumber, thirdNumber;

                Console.Write("Input the first number to multiply: ");
                firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input the second number to multiply: ");
                secondNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input the third number to multiply: ");
                thirdNumber = Convert.ToDouble(Console.ReadLine());

                double result = firstNumber * secondNumber * thirdNumber;

                Console.WriteLine($"{firstNumber} x {secondNumber} x {thirdNumber} = {result}");
            Console.ReadLine();
            }
        }
    }
    

