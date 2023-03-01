using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AssignmentsConditional
{
    internal class VowelConsonent
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the Character");
            ch= Convert.ToChar(Console.ReadLine());

            if(ch=='A' || ch=='0' || ch=='U' || ch=='E' || ch=='I' || ch=='a'|| ch=='e'||ch=='i'||ch=='o'||ch=='u')
            {
                Console.WriteLine("The character is Vowel");
            }
            else if((ch>='a' && ch<='z')|| (ch>='A' && ch<='Z'))
            {
                Console.WriteLine("The character is Consonent");
            }
            else
            {
                Console.WriteLine("The characte is not vowel or consonent");
            }
        }
    }
}
