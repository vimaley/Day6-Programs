//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day6_Programs
//{
//    class addmat
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter row size: ");
//            int rowsize = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter column size: ");
//            int colsize = int.Parse(Console.ReadLine());

//            int[,] arr = new int[rowsize, colsize];

//            Console.WriteLine("Enter 1st Array elements : ");
//            for (int i = 0; i < rowsize; i++)
//            {
//                for (int j = 0; j < colsize; j++)
//                {
//                    arr[i, j] = int.Parse(Console.ReadLine());
//                }
//            }


//            int[,] arr1 = new int[rowsize, colsize];

//            Console.WriteLine("Enter 2nd Array elements : ");
//            for (int i = 0; i < rowsize; i++)
//            {
//                for (int j = 0; j < colsize; j++)
//                {
//                    arr1[i, j] = int.Parse(Console.ReadLine());
//                }
//            }

//            int[,] arr2 = new int[rowsize, colsize];

//            for (int i = 0; i < rowsize; i++)
//            {
//                for (int j = 0; j < colsize; j++)
//                {
//                    arr2[i, j] = arr[i,j] + arr1[i,j];
//                }
//            }

//            Console.WriteLine("The sum of 2 matrix is: ");

//            for (int i = 0; i < rowsize; i++)
//            {
//                for (int j = 0; j < colsize; j++)
//                {
//                    Console.Write(arr2[i, j] + " ");
//                }
//                Console.WriteLine();
//            }

//            Console.ReadLine();


//        }
//    }
//}
