using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class A<T>
    {
        public A(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A<string> gen = new A<string>("This is genric class");
            A<int> genI = new A<int>(101);
            A<char> gench = new A<char>('I');

            Console.ReadLine();
        }
    }
}
