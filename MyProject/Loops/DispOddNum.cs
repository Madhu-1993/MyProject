using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class DispOddNum
    {
        static void Main(string[] args)
        {
            int i;
           
           // n=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the num");

            for(i=35;i<=50;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
