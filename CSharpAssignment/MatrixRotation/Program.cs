using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows, column;
            Console.WriteLine("Enther the number of rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enther the number of colums:");
            column = int.Parse(Console.ReadLine());
            int[,] a = new int[rows, column];
            Console.WriteLine("Enther the values of matrix");
            for (i=0;i<rows;i++)
            {
                for(j=0;j<column;j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for(i=0;i<rows;i++)
            {
                for(j=0;j<column;j++)
                {
                    Console.Write("\t"+ a[i, j]);
                }
                Console.Write("\n");
            }

            Console.Read();

        }
    }
}
