using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Fifthprogram
    {
        static void Main()
        {
            Console.Write("Enter a digit: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Using Console.Write
            Console.Write("{0} {0} {0} {0}\n", number);
            Console.Write("{0}{0}{0}{0}\n", number);

            // Using {0} format
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.ReadLine();
        }
    }
}
