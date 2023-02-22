using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class queuepgm
    {
        static void Main(string[] args)
        {
            Queue s1 = new Queue();
            s1.Enqueue(1);
            s1.Enqueue(22);
            s1.Enqueue(3);
            s1.Enqueue(34);
            s1.Enqueue(45);
            s1.Enqueue(67);
            s1.Enqueue(57);
            s1.Enqueue(89);

            Console.WriteLine("Queue elements are: ");
            foreach (int i in s1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("The count of elements in Queue: " + s1.Count);
            s1.Dequeue();
            Console.WriteLine("The topmost element in Queue is: " + s1.Peek());

            Queue s2 = new Queue();
            s2.Enqueue("Vimal");
            s2.Enqueue(2.343f);
            s2.Enqueue(1);

            Console.WriteLine("Elements in Queue2: ");

            foreach (var i in s2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
