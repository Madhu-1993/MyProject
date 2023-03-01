using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class PalindromeNum
    {
        static void Main(string[] args)
        {
            int r, sum = 0, temp;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num /= 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}
