using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BasicCode
{
    internal class AreaOfRectangle
    {
        static void Main(string[] args)
        {
            int b,h;
            Console.WriteLine("Enter the base and height");

            b = int.Parse(Console.ReadLine());
            h=int.Parse(Console.ReadLine());
            double area = b * h;
            Console.WriteLine("The area of rectangle is"+area);
        }

    }
}
