using System;

namespace StaticSample
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public static string College { get; set; }
        public Student(int id,string name,int age)
        {
            College = "SSET";
            Id = id;
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine("Id={0} Name={1} Age={2} Collage={3}", Id, Name, Age, College);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Mruthula", 22);
            s1.Display();
            Student s2 = new Student(2,"Shilpa",23);
            s2.Display();
        }
    }
}
