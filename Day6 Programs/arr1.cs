using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class arr1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] arr1 = new int[5] { 2, 3, 4, 5, 6 };
            int[] arr2 = new int[6];
            arr2[0] = 1;
            arr2[1] = 2;
            arr2[2] = 3;
            arr2[3] = 4;
            arr2[4] = 5;

            foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
