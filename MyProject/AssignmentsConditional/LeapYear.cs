using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentsConditional
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            //char year;
            int days;
            Console.WriteLine("Enter the days");
            days=int.Parse(Console.ReadLine());
            if (days==366)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }
    }
}
