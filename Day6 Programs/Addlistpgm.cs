using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class Addlistpgm
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(22);
            arr.Add(33);
            arr.Add(44);
            arr.Add(15);
            arr.Add(29);
            arr.Add(25);
            arr.Add(100);

            Console.WriteLine("Arraylist elements are: ");
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            arr.Sort();
            Console.WriteLine("Arraylist elements after sort are: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            arr.Reverse();
            Console.WriteLine("Arraylist elements after reversing are: ");
                foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            arr.Remove(1); //1 value will be removed from the array list
            arr.RemoveAt(0); // 0th index value will be removed
            arr.RemoveRange(0, 2); //from the 0th index 2 values will be removed

            Console.WriteLine("Arraylist after removing elements: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
    }
}
