using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Programs
{
    class fnex
    {
        static void Main(string[] args)
        {
            fnex m1 = new fnex();
            m1.add(10, 11);
            Console.WriteLine("The sum of numbers is: " + m1.sum(9, 8));
            Console.ReadLine();
        }

        public void add(int a, int b)
        {
            Console.WriteLine("The result of addition is: " + (a + b));
        }
        
        public int sum(int a, int b)
        {
            return (a + b);
        }
    }
}
