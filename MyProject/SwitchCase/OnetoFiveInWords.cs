using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.SwitchCase
{
    internal class OnetoFiveInWords
    {
        static void Main(string[] args)
        {
            int num;
            num =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num 1 to 5");

            switch(num)
            {
                case '1': Console.WriteLine("One");
                    break;

                case '2': Console.WriteLine("Two");
                    break;

                case '3':
                    Console.WriteLine("Three");
                    break;

                case '4':
                    Console.WriteLine("Four");
                    break;

                case '5':
                    Console.WriteLine("Five");
                    break;

                case '6':
                    Console.WriteLine("Six");
                    break;

                case '7':
                    Console.WriteLine("Seven");
                    break;

                case '8':
                    Console.WriteLine("Eight");
                    break;

                case '9':
                    Console.WriteLine("Nine");
                    break;

                //case '10':
                   // Console.WriteLine("Ten");
                   // break;

               default: Console.WriteLine("Invalid num");
                    break;
            }
        }
    }
}
