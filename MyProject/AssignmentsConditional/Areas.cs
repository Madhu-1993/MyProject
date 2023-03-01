using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentsConditional
{
    internal class Areas
    {
        static void Main(string[] args)
        {
            int choice;
            double area;
            Console.WriteLine("Enter the choice");
            choice=int.Parse(Console.ReadLine());
            Console.WriteLine("1.Area of circle\n 2.Area of traingle\n 3.Area of rectangle\n 4.Area of square");
            //area=int.Parse(Console.ReadLine()); 

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the Radius");
                    int r=int.Parse(Console.ReadLine());
                    double pi = 3.14;
                    area = pi * r * r;
                    Console.WriteLine("Area of circle is" + " " + area);
                    break;

                case 2:
                    Console.WriteLine("Enter the base and height");
                    int Base=int.Parse(Console.ReadLine());
                    int height=int.Parse(Console.ReadLine());
                    area = 0.5 * Base * height;
                    Console.WriteLine("Area of traingle is" + " " + area);
                    break;

                case 3:
                    Console.WriteLine("Enter the length and breath");
                    int l=int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    area = l * b;
                    Console.WriteLine("Area of Rectangle is" + " " + area);
                    break;

                case 4:
                    Console.WriteLine("Enter the side of square");
                    int s= int.Parse(Console.ReadLine());
                    area = s * s;
                    Console.WriteLine("Area of Square is" + " " + area);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
