using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentsConditional
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            int choice, a, b;
            
            Console.WriteLine("Enter the number");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the choice");
            Console.WriteLine("1. Addition\n 2.Division\n 3.Substraction\n 4.Multiplication");
            Console.WriteLine("Enter the choice from 1-4");
            choice = int.Parse(Console.ReadLine());
           

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition"+ " " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Division"+ " " + (a / b));
                    break;
                case 3:
                    Console.WriteLine("Substraction"+ " " + (a - b));
                    break;
                case 4:
                    Console.WriteLine("Multiplication"+ " " + (a * b));
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
           // Console.WriteLine("Do you wnat to continue");
            //ch = Convert.ToChar(Console.ReadLine());
            
        }
    }
}
