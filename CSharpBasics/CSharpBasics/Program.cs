using CSharpBasics.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{  
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1,"Vava","Neenu");//if ISchool s=new Student() => the we can use only School() and Name Cant use props of Student class
            float numf = 5;
            int num = (int)numf;
            s.RollNumber =num;
            s.Name = "Mruthula";
            s.Display();
            s.School();
            s.ClassA();
            Student s2 = new Student(7,"Shilpa","Gayathri");
            s2.Display();
            s2.School();
            s2.ClassA();
            Console.ReadLine();
        }
    }
}
