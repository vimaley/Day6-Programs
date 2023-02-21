using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class ipmatrixarr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row size: ");
            int rowsize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter column size: ");
            int colsize = int.Parse(Console.ReadLine());

            int[,] arr = new int[rowsize, colsize];

            Console.WriteLine("Enter Array elements are: ");
            for (int i = 0; i < rowsize; i++)
            {
                for (int j = 0; j < colsize; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rowsize; i++)
            {
                for (int j = 0; j < colsize; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
