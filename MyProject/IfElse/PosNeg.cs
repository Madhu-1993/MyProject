using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.IfElse
{
    internal class PosNeg
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num");
            if(num>0)
            {
                Console.WriteLine("The num is Positive");
            }
            else
            {
                Console.WriteLine("The num is Negative");
            }
        }
       
    }
}
