using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> fibinocci = new List<int>();
            Console.WriteLine("Enter the number of elements to be showed in fibinocci series");
            int count = Convert.ToInt32(Console.ReadLine());
            //Fibinocci = GetFibinoccci(1,1,Count);
            fibinocci.Add(1);
            fibinocci.Add(1);
            count = count - 2;
            fibinocci = Fibinoccci(1, 1, count, fibinocci);
            Console.WriteLine("Fibinocci series :");
            Console.Write("{0}",string.Join(" ",fibinocci));
            ////string Numbers="";
            //List<int> NumberArray = new List<int>();
            //int Count = -1;
            //for (int i = 1; i < 100; i++)
            //{
            //    if((i%3==0)&&(i%5==0))
            //    {
            //        //Numbers += i.ToString();
            //        Count++;
            //        NumberArray.Add(i);
            //    }
            //}
            //Console.WriteLine("{0}",string.Join(",",NumberArray));
            ////Console.Write("{0}", Numbers.TrimEnd(','));
            Console.ReadLine();
        }
        static List<int> GetFibinocci(int count)
        {
            List<int> Fibinocci = new List<int>();
            int Element1 = 1;
            Fibinocci.Add(Element1);
            int Element2 = 1;
            Fibinocci.Add(Element2);
            int Count = 2;
            int Elemet3;
            while(Count!=count)
            {
                Elemet3 = Element1 + Element2;
                Fibinocci.Add(Elemet3);
                Element1 = Element2;
                Element2 = Elemet3;
                Count++;
            }
            return Fibinocci;
        }
        public static List<int> Fibinoccci(int element1,int element2,int count,List<int> fibinocci)
        {
            if (count > 0)
            {
                fibinocci.Add(element1+element2);
                count--;
                return(Fibinoccci(element2, element1+element2,count,fibinocci));
            }
            else
            {
                met();
                return fibinocci;
            }
            
        }
        public static int met()
        {
            return 1;
        }
    }
}


