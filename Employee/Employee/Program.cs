using System;
using System.Collections.Generic;

namespace Employee
{
    class Program
    {
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Employee(int id,string name)
            {
                Id = id;
                Name = name;
            }
        }

        class EmployeeDetails:Employee
        {
            int Age { get; set; }
            long PhoneNumber { get; set; }
            public Location Location { get; set; }
            public EmployeeDetails(int id,string name,int age,long phoneNumber,Location loc):base(id,name)
            {
                Age = age;
                PhoneNumber = phoneNumber;
                Location = loc;
            }
        }

        static void Main(string[] args)
        {
            List<EmployeeDetails> EmployeeList = new List<EmployeeDetails>();

            EmployeeList.Add(new EmployeeDetails(1, "Mruthula", 22, 9653729086, Location.Kochi));
            EmployeeList.Add(new EmployeeDetails(2,"Maria", 22, 9662918736, Location.Hydrabad));
            EmployeeList.Add(new EmployeeDetails(3, "Shilpa", 23, 9253719276, Location.Banglore));
            EmployeeList.Add(new EmployeeDetails(4, "Haritha", 21, 9815273645, Location.Banglore));
            EmployeeList.Add(new EmployeeDetails(5, "Samar", 25, 8362015368, Location.Hydrabad));
            EmployeeList.Add(new EmployeeDetails(6, "Githin", 30, 8914283560, Location.Kochi));
            EmployeeList.Add(new EmployeeDetails(7, "jideesh", 27, 7924729015, Location.Hydrabad));
            EmployeeList.Add(new EmployeeDetails(8, "Hari", 23, 7192364720, Location.Banglore));

            Console.WriteLine("Employees Located Hydrabad are :");
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                if(EmployeeList[i].Location==Location.Hydrabad)
                {
                    Console.WriteLine("{0}", EmployeeList[i].Name);
                }

            }
            Console.ReadLine();

            Console.WriteLine("Employees whose name starts with S :");
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                if (EmployeeList[i].Name[0] == 'S')
                {
                    Console.WriteLine("{0}", EmployeeList[i].Name);
                }

            }
            Console.ReadLine();
        }
    }
    public enum Location
    {
        Hydrabad,
        Kochi,
        Banglore
    }
}
