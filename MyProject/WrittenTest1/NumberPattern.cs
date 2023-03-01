using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.WrittenTest1
{
    internal class NumberPattern
    {
        static void Main(string[]args)
        {
            int n = 4;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write("  ");
                }
                for(int j=1;j<=2*i-1;j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
