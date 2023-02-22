using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class Stackpgm
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push(22);
            s1.Push(3);
            s1.Push(34);
            s1.Push(45);
            s1.Push(67);
            s1.Push(57);
            s1.Push(89);

            Console.WriteLine("Stack elements are: ");
            foreach(int i in s1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("The count of elements in Stack: " + s1.Count);
            s1.Pop();
            Console.WriteLine("The topmost element in stack is: " + s1.Peek());

            Stack s2 = new Stack();
            s2.Push("Vimal");
            s2.Push(2.343f);
            s2.Push(1);

            Console.WriteLine("Elements in Stack2: ");

            foreach(var i in s2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
