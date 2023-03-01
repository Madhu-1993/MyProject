using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WrittenTest1
{
    internal class FactorialSum
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int fact = 1,sum=0;

            for (int i=1;i<=n;i++)
            {
                fact=fact * i;
                sum=sum +fact;
            }
            Console.WriteLine("Factorial="+fact+" "+"Sum="+sum);
        }
    }
}
