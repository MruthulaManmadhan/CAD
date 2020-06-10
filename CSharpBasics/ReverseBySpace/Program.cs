using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseBySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence");
            string Sentence = Convert.ToString(Console.ReadLine());

            string[] Word = Sentence.Split(' ');
            for (int i = (Word.Length-1); i >=0; i--)
            {
                Console.Write("{0}  ",Word[i]);
            }
            Console.ReadLine();
        }
    }
}
