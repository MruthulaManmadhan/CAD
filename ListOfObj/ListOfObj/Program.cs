using System;
using System.Collections.Generic;

namespace ListOfObj
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            Console.WriteLine("Enter the number of students");
            int Num = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<Num;i++)
            {
                Console.WriteLine("enter the Id");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the Name");
                string Name = Convert.ToString(Console.ReadLine());
                Student s1 = new Student(Id, Name);
                Students.Add(s1);
            }
            Console.WriteLine("Details of Students");
            for(int i=0;i<Students.Count;i++)
            {
                Console.WriteLine("Id : {0}  Name : {1} ", Students[i].Id, Students[i].Name);
            }
            Console.ReadLine();
        }
    }
}
