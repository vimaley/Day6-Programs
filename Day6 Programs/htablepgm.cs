//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day6_Programs
//{
//    class htablepgm
//    {
//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();
//            ht.Add(1, "China");
//            ht.Add(2, "Japan");
//            ht.Add(3, "India");

//            Console.WriteLine("Hash table elements are: ");
//            foreach(DictionaryEntry item in ht)
//            {
//                Console.WriteLine(item.Key + "   " + item.Value);
//            }

//            Console.WriteLine("The no of elements in hastable is:" + ht.Count);
//            ht.Remove(2);
//            Console.WriteLine("The elements in hastable after removing is:");
//            foreach (DictionaryEntry item in ht)
//            {
//                Console.WriteLine(item.Key + "   " + item.Value);
//            }
//            Console.WriteLine(ht.ContainsValue("India"));
//            Console.WriteLine(ht.ContainsKey(1));
//            Console.WriteLine(ht.Contains(1));
//            if (ht.IsFixedSize == true)
//                Console.WriteLine("Size fixed");
//            else
//                Console.WriteLine("Size not fixed");
//            Console.ReadLine();


//        }
//    }
//}
