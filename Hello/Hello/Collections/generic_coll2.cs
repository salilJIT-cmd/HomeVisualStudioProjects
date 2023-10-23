using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{

    public class Dictionary_and_SortedList_tut
    {


        static public void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // 1. Insertion
            dict.Add(1, "salil");
            dict.Add(2, "Anchal");
            dict.Add(3, "Sahil");
            //dict.Add(3, "oyee");  // duplicate keys can't be added (gives error)
            Console.WriteLine(dict.Count);

            // Collection Initialization Syntax
            Dictionary<int, string> dict2 = new Dictionary<int, string>
            {
                {1, "salil" },
                {2, "anchal" }
            };

            // 2. Accessing and changing an element
            //Console.WriteLine(dict[1]);  // find value with key 1
            //dict[2] = "change";


            // 3. Deletion (possible using key only)
            //dict.Remove(1);   // delete value with key 1
            //dict.Clear();  // delete all elements


            // 4. Printing the whole dicti
            foreach (KeyValuePair<int, string> pair in dict)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }


            // 5. Check the availiability of key or value
            if (dict.ContainsKey(1) == true)  // check by key
            {
                Console.WriteLine("Key is found");
            }

            if (dict.ContainsValue("Anchal") == true)  // check by value
            {
                Console.WriteLine("Value is found");
            }


            // ******************
            // SortedList is just like dictionary (non-generic sortedlist is not available is newer version of .NET)
            // The only difference is that it stores key-value pairs with the ascending order of the key
            SortedList<int, string> slist = new SortedList<int, string>();

            // I have added in random order and when i print it, it is sorted
            slist.Add(3, "salil");
            slist.Add(1, "Anchal");
            slist.Add(2, "Sahil");

            // priting the whole sortedlist
            foreach (KeyValuePair<int, string> pair in slist)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }

            // OR
      
            foreach (var pair in slist)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }

            // Note - In C#, SortedList doesn't have a built-in method for reversing its order
            // because it's designed to maintain elements in sorted order by their keys.


        }
    }


}
