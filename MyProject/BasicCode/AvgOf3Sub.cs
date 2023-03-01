using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BasicCode
{
    internal class AvgOf3Sub
    {
        static void Main(String[] args)
        {
            int sub1,sub2,sub3,avg;
            avg=int.Parse(Console.ReadLine());
            sub1 = int.Parse(Console.ReadLine());
            sub2 = int.Parse(Console.ReadLine());
            sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of 3 subjects");
            avg = sub1 + sub2 + sub3 / 3;
            Console.WriteLine("The avrg of 3 subjects"+avg);

        }
    }
}
