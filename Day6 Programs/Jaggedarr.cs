﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class Jaggedarr
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[] { 1, 2, 3, 4 };
            arr[1] = new int[] { 2, 3, 4 };

            for(int i=0; i<arr.Length; i++)
            {
                for(int j =0; j< arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j] + "  ");
                } Console.ReadLine();
            }Console.ReadLine();
        }
    }
}
