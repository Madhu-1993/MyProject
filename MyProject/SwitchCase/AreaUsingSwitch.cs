using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyProject.SwitchCase
{
    internal class AreaUsingSwitch
    {
        static void Main(string[]args)
        {
            int rad,s,b,h,l,choice;
            double pi = 3.14,area;
            
            choice=int.Parse(Console.ReadLine());
            rad=int.Parse(Console.ReadLine());
            s=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            h=int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the choice");
            Console.WriteLine("1. Circle /n 2. Rectangle /n 3.Traingle /n 4.Circle");

            switch(choice)
            {
                case 0:
                    Console.WriteLine("Enter the radious");
                    area = pi * rad * rad;
                    Console.WriteLine("The area of circle" + area);
                    break;

                case 1:
                    Console.WriteLine("Enter the side");
                    area = s * s;
                    Console.WriteLine("The area of square is"+area);
                    break;

                case 3:
                    Console.WriteLine("Enter the lenght and breadth");
                    area = b * l;
                    Console.WriteLine("The area of Rectangle is" + area);
                    break;

                case 4:
                    Console.WriteLine("Enter the base and height");
                    area = 0.5 * h * b;
                    Console.WriteLine("The area of Traingle");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}
