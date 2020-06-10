using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char[] Characters = new char[50];
                Console.WriteLine("Enter the string");
                string Word = Convert.ToString(Console.ReadLine());//getting string
                if (Word.Length > 50)
                {
                    Console.WriteLine("Large String");
                }
                else// operation only if length of string with in the limit of char array
                {
                    Characters = SingleChars(Word);//get the array of chars which appear only once in the string
                    Console.WriteLine("Characters which appear only once in String {0} :", Word);
                    for (int i = 0; i < Characters.Length; i++)
                    {
                        Console.Write("{0} ", Characters[i]);
                    }
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Occured error : {0}", ex);
            }
        }


        //method for returning an array of chars which appear only once in the given string
        static char[] SingleChars(string word)
        {
            char[] CharsInWord = new char[word.Length];
            int[] Count = new int[word.Length];
            Dictionary<int, string> Words = new Dictionary<int, string>();

            //Getting each char from string into a char array and count to an int array
            for (int i = 0; i < word.Length; i++)
            {
                if (Words.ContainsValue(Convert.ToString(word[i])))
                {
                    //Words.
                }
                CharsInWord[i] = word[i];
                Count[i] = 1;
                for (int j = 0; j < word.Length; j++)
                {
                    if (char.ToUpperInvariant(CharsInWord[i]) == char.ToUpperInvariant(word[j]) && i != j)
                    {
                        Count[i]++;
                    }
                }
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("{0} : {1}", CharsInWord[i], Count[i]);
            }


            int SingleCharCount = -1;
            //if Count array contain 1 get the char from char array to another char array which contain only chars which appear once

            int CountSingle = 0;
            for (int i = 0; i < Count.Length; i++)
            {
                if (Count[i] == 1)
                {
                    CountSingle++;
                }
            }
            char[] SingleChars = new char[CountSingle];

            for (int i = 0; i < Count.Length; i++)
            {
                if (Count[i] == 1)
                {
                    SingleCharCount++;
                    SingleChars[SingleCharCount] = CharsInWord[i];
                }
            }
            return SingleChars;
        }
    }
}
