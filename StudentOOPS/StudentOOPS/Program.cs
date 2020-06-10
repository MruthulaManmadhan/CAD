using System;

namespace StudentOOPS
{

    class Program
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
        class StudentDetails : Student
        {
            public string Branch { get; set; }
            public string Hobby { get; set; }
            public StudentDetails(int id, string name, string branch, string hobby):base(id,name)
            {
            Branch = branch;
            Hobby = hobby;
            }   
            public void Display()
            {
                Console.WriteLine("Student id={0} Name= {1} Branch={2} Hobby={3}", Id, Name, Branch, Hobby);
            }
        }
        static void Main(string[] args)
        {
            StudentDetails s = new StudentDetails(1, "Mruthula", "Computer Science", "Traveling");
            s.Display();
            Console.ReadLine();
        }
    }
}
