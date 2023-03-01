using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class TableOfGivenNumber
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());

            for(i=1;i<=10;i++)
            {
                
                int table = num * i;
                Console.WriteLine( table);

            }
        }
    }
}
