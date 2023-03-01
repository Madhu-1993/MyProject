using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class Table
    {
        static void Main(string[] args)
        {
            int n;
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num");
            
            for(int i=1;i<=10;i++)
            {
                i = n * i;
                Console.WriteLine(i);
            }
        }
    }
}
