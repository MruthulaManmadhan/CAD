using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[,] Matrix = new int[10, 10];
                Console.WriteLine("Enter number of rows of the matrix");
                int Row = Convert.ToInt32(Console.ReadLine());
                if (Row <= 10)
                {
                    Console.WriteLine("Enter number of coloumns of the matrix");
                    int Coloumn = Convert.ToInt32(Console.ReadLine());
                    {
                        if (Coloumn <= 10)
                        {
                            Matrix = GetMatrix(Row, Coloumn);
                            Console.WriteLine("Entered Metrix");
                            WriteMetrix(Matrix, Row, Coloumn);
                            int[,] InvertedMatrix = Invert(Matrix, Row, Coloumn);
                            Console.WriteLine("Inverted Matrix");
                            WriteMetrix(InvertedMatrix, Coloumn, Row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Occured error : {0}", ex);
            }
            Console.ReadLine();
        }

        //method for getting the matrix
        static int[,] GetMatrix(int row,int coloumn)
        {
            int[,] Matrix = new int[10, 10];
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("Enter Digits for row {0}", i + 1);
                for (int j = 0; j < coloumn; j++)
                {
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return Matrix;
        }
        

        //Method for printing the matrix
        static void WriteMetrix(int[,] matrix,int row,int coloumn)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    Console.Write("{0}  ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


        //Method for reversing the matrix
        static int[,] Invert(int[,] matrix, int row, int coloumn)
        {
            int[,] Matrix = new int[coloumn, row];
            for (int i = 0; i < coloumn; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Matrix[i, j] = matrix[j,i];
                }
            }
            return Matrix;
        }
    }
}
