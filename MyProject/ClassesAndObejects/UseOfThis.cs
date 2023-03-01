using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ClassesAndObejects
{
     class UseOfThis
    {
        int a,b;
        public void Input(int a, int b)
        {
            this.a = a;
            this.b = b;
            this.Display();
        }
        public void add()
        {
            int add = a + b;
            Console.WriteLine(add);
        }
        public void Display()
        {
            Console.WriteLine(a, b);
            this.add();
           // Console.WriteLine(add);

        }

        static void Main(string[]args)
        {
            UseOfThis ut = new UseOfThis();
            ut.Input(10,20);
            ut.Display();
        }
    }
   
}
