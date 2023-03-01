using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class ProductOfDigit
    {
        static void Main(string[] args)
        {
            int num,rem=0,product=1;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());

            while(num>0)
            {
                rem=num%10;
                product = product * rem;
                num = num / 10;
                //count++;
            }
            Console.WriteLine("The product of given number " + product);
        }
    }
}
