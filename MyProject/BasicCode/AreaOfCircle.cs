using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BasicCode
{
    internal class AreaOfCircle
    {
        static void Main(string[]args)
        {
            int rad=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Radius");

            double pi = 3.14;
            double area= pi * rad * rad;
            Console.WriteLine("The area of circle is" + area);

        }
    }
}
