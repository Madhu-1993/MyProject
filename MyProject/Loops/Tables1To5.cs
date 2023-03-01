using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class Tables1To5
    {
        static void Main(string[] args)
        {
            int num, i = 0;
            Console.WriteLine("Table of given num");
            Console.WriteLine("Enter the num");
            num=int.Parse(Console.ReadLine());
            
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("{0}*{1}={2}\n",num,i,(num*i));
            }
        }
    }
}
