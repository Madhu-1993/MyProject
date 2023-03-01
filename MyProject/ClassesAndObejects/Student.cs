using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ClassesAndObejects
{
     class Student
    {
        int id,m1,m2,m3,per;
        string name;
        
       // bool ischeck;

        public void AcceptDetails(int sid, string sname, int mt1, int mt2, int mt3)
        {
            id = sid;
            name = sname;
            m1 = mt1;
            m2 = mt2;
            m3 = mt3;
        }   
        
        public void percentage()
        {
            int totalMarks = m1 + m2 + m3;
            per=(totalMarks*100)/300;
        }
        public void Display()
        {
            Console.WriteLine("Student id=" + id + "Nmae=" + name + "Maths=" + m1 + "Science=" + m2 + "History=" + m3 + "Percentage" + per);
        }
        static void Main(string[]args)
        {
            Student stud;
            stud = new Student();
            stud.AcceptDetails(1, "Ayushi", 40, 50, 70);
            stud.percentage();

        }
    }
}
