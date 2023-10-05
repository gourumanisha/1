using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Thirdprogram
    {
       
        static void Main()
        {
            double firstNumber, secondNumber;

            Console.Write("Input the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            double additionResult = firstNumber + secondNumber;
            double subtractionResult = firstNumber - secondNumber;
            double multiplicationResult = firstNumber * secondNumber;
            double divisionResult = firstNumber / secondNumber;
            double modulusResult = firstNumber % secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {additionResult}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {subtractionResult}");
            Console.WriteLine($"{firstNumber} x {secondNumber} = {multiplicationResult}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {divisionResult}");
            Console.WriteLine($"{firstNumber} mod {secondNumber} = {modulusResult}");
            Console.ReadLine();
        }
    }

}

    

