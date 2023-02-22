using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class MyClass
    {
        static void Swap<T>(ref T num1, ref T num2)
        {
            T temp = default(T);

            temp = num2;
            num2 = num1;
            num1 = temp;
        }

        static void Main(string[] args)
        {
            int first = 4;
            int second = 5;

            Swap<int>(ref first, ref second);

            Console.WriteLine(first);
            Console.WriteLine(second);

            Console.ReadLine();
        }
    }

    
}
