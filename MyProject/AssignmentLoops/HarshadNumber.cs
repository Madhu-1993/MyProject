using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class HarshadNumber
    {
        static void Main(string[]args)
        {
            int num, sum = 0, rem = 0;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            int n = num;

            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            if(n%sum==0)
            {
                Console.WriteLine("The number is Harshad Number");
            }
            else
            {
                Console.WriteLine("The number is not Harshad Number");
            }
        }
    }
}
