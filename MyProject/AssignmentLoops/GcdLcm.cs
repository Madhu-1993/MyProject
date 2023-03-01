using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentLoops
{
    internal class GcdLcm
    {
        static void Main(string[] args)
        {
            int num1, num2, temp, GCD, LCM;
            Console.WriteLine("Enter the numbers");
            num1=int.Parse(Console.ReadLine());
            num2=int.Parse(Console.ReadLine());
            int n1 = num1;
            int n2= num2;

            while(n2!=0)
            {
                temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            GCD = n1;
            LCM = (num1 * num2) / GCD;
            //Console.WriteLine("GCD="+ GCD +" " + "LCM="+ LCM);
            Console.WriteLine("LCM for {0} and {1} is {2}", num1,num2, LCM);
            Console.WriteLine("GCD for {0} and {1} is {2}", num1,num2, GCD);
        }
    }
}
