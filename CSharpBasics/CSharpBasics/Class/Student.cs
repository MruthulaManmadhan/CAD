using CSharpBasics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Classes
{
    public class Student : ISchool, IClass//If we need to use only methods and props of interfaces then i interface need to impliment other then class need to impliment that
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string SchoolName = "XYZ";
        public string Teacher { get; set; }
        public void ClassA()
        {
            Console.WriteLine("{0}'s class teacher is {1}", Name, Teacher);
        }
        public void Display()
        {
            Console.WriteLine("Roll Number : {0}      Name : {1}", RollNumber, Name);
        }
        public void School()
        {
            Console.WriteLine("{0} is a student of {1} school", Name, SchoolName);
        }
        public Student(int rollNumber, string name, string teacher)
        {
            RollNumber = rollNumber;
            Name = name;
            Teacher = teacher;
        }
    }
}
