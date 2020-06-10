using System;
using System.Collections.Generic;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>();
            int Num;
            Console.WriteLine("Enter the number of digits");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the digits");
            for (int i=0;i<Count;i++)
            {
                Num = Convert.ToInt32(Console.ReadLine());
                MyList.Add(Num);
            }
            Console.WriteLine("Numbers before removing");
            for (int i = 0; i < MyList.Count; i++)
            {
                Console.WriteLine("{0}", MyList[i]);
            }
            Console.WriteLine("Enter the number to be deleted");
            Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Count; i++)
            {
                if (MyList[i] == Num)
                {
                    MyList.Remove(Num);
                }
            }
            Console.WriteLine("Numbers After removing");
            for (int i = 0; i < MyList.Count; i++)
            {
                Console.WriteLine("{0}", MyList[i]);
            }
            Console.ReadLine();
        }
    }
}
