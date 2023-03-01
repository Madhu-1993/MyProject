using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyProject.BasicCode
{
    internal class PerOf5SubMarks
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5, per;
            sub1=int.Parse(Console.ReadLine());
            sub2 = int.Parse(Console.ReadLine());
            sub3 = int.Parse(Console.ReadLine());
            sub4 = int.Parse(Console.ReadLine());
            sub5 = int.Parse(Console.ReadLine());
            per = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of 5 subjects");

            per= (sub1+sub2+sub3+sub4+sub5/500)*100;
            Console.WriteLine("The Percentage is"+per);

        }
    }
}
