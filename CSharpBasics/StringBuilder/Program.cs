using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Hello ", 20);
            stringBuilder.Append("World");
            Console.WriteLine(stringBuilder);
            stringBuilder.AppendLine("!!");
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.Length);
            stringBuilder.Clear();
            stringBuilder.Append("Mruthula");
            Console.WriteLine(stringBuilder);
            Console.ReadLine();

        }
    }
}
