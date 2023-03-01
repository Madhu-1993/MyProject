using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.IfElse
{
    internal class GretrLess
    {
        static void Main(string[] args)
        {
            int Num;
            Num=int.Parse(Console.ReadLine());
            Console.WriteLine(Num);
            if(100>Num)
            {
                Console.WriteLine("The num is less than 100");
            }
                else if(Num>50)
                {
                Console.WriteLine("The num is greater then 50");
                }
                else
                {
                Console.WriteLine("The num is invalid");
                }
        }
    }
}
