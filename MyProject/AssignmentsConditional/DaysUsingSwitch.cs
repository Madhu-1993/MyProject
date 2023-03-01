using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentsConditional
{
    internal class DaysUsingSwitch
    {
        static void Main(string[] args)
        {
            int days;
            Console.WriteLine("Week days");
            Console.WriteLine(" 1.Monday\n 2.Tuesday\n 3.Wednesday\n 4.Thursday\n 5.Friday\n 6.Saturday\n 7.Sunday");
            Console.WriteLine("Enter the day Number");
            days = int.Parse(Console.ReadLine());

            switch (days)
            {
                case 1:
                    Console.WriteLine("The day is exixt " + "Monday");
                    break;
                case 2:
                    Console.WriteLine("The day is exixt " + "Tuesday");
                    break;
                    case 3:
                    Console.WriteLine("The day is exixt " + "Wednesday");
                    break;
                    case 4:
                    Console.WriteLine("The day is exixt " + "Thursday");
                    break;
                    case 5:
                    Console.WriteLine("The day is exixt " + "Friday");
                    break;
                    case 6:
                    Console.WriteLine("The day is exixt " + "Saturday");
                    break;
                    case 7:
                    Console.WriteLine("The day is exixt " + "Sunday");
                    break;
                default:
                    Console.WriteLine("error, The day is not exixt");
                    break;

            }
        }
    }
}
