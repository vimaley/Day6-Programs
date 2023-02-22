//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day6_Programs
//{
//    class sortedlistpgm
//    {
//        static void Main(string[] args)
//        {
//            SortedList s1 = new SortedList();
//            s1.Add(1, "China");
//            s1.Add(2, "Japan");
//            s1.Add(3, "India");
//            s1.Add(4, "Korea");
//            s1.Add(5, "USA");

//            Console.WriteLine("Hash table elements are: ");
//            foreach (DictionaryEntry item in s1)
//            {
//                Console.WriteLine(item.Key + "   " + item.Value);
//            }

//            s1.Remove(1);
//            s1.RemoveAt(2);
//            Console.WriteLine(s1.ContainsKey(5));
//            Console.WriteLine(s1.ContainsValue("Korea"));
//            Console.WriteLine(s1.Contains(5));
//            Console.ReadLine();
//        }
//    }
//}
