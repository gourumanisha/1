using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class Ninethprogram
    {
        static void Main()
        {
            Console.Write("Enter the number of days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years, weeks, days;

            // Calculate years
            years = totalDays / 365;

            // Calculate the remaining days after calculating years
            int remainingDays = totalDays % 365;

            // Calculate weeks
            weeks = remainingDays / 7;

            // Calculate the remaining days after calculating weeks
            days = remainingDays % 7;

            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {days}");
            Console.ReadLine();
        }
    }
}
