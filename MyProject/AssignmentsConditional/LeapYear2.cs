using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentsConditional
{
    internal class LeapYear2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year=int.Parse(Console.ReadLine()); 
            if((year%4==0) && (year%100!=0) || (year%400==0))
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
            Console.ReadLine();
        }
    }
}
