using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ClassesAndObejects
{
     class Employee
    {
        int eid,esallary;
        string ename;
        
        static void Main(string[]args)
        {
            Employee e = new Employee();
            e.eid = 1;
            e.ename = "XYZ";
            e.esallary = 10000;
            Console.WriteLine("Id= " + e.eid +" " + " Name= " + e.ename +" "+  "Sallaery= " + e.esallary);
        }
    }
}
