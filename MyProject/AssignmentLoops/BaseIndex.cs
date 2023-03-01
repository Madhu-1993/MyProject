using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class BaseIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Base Number");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent");
            int expo=int.Parse(Console.ReadLine());

            int power = 1;
            int i = 1;
            while(i<=expo)
            {
                power = power * baseNumber;
                i++;
            }
            Console.WriteLine(power);
        }
    }
}
