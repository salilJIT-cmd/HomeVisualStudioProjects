using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections{

    public class List_HashSet_tut
    {
        public static bool isEven(int a)
        {
            return a % 2 == 0;
        }

        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // 1. Insertion
            list.Add("salil");
            list.Add("Anchal");
            list.Add("Sahil");
            Console.WriteLine(list.Count);

            // You can use collection initializer syntax to add multiple elements to a list when creating it.
            List<int> list2 = new List<int>() {1,2,3,4,5,6};

            // 2. Accessing an element
            // Console.WriteLine(list[1]);
            list[2] = "change";


            // 3.Deletion
            //list.Remove("change");   // delete element from value
            //list.RemoveAt(1);   // delete element from index


            // 4. Printing the whole list
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}


            // 5. Find an element based on a particular condition

            // 5a.
            string returnedValue = 
            list.Find(x =>
            {
                return x.Contains("c");
            });
            Console.WriteLine(returnedValue);

            // 5b.
            Console.WriteLine(list2.Find(isEven));  // the method that we provide here must have a bool return type



            // HASHSET (similar to list)
            // HashSet ensures that all elements within it are unique. Adding duplicate elements has no effect.
            {

                //// Inserting elements
                //HashSet<int> numbers = new HashSet<int>();
                //numbers.Add(1);
                //numbers.Add(2);
                //numbers.Add(3);
                //numbers.Add(2); // Duplicate, will be ignored

                //// Check if an element exists in the set
                //bool containsTwo = numbers.Contains(2); // true
                //bool containsFour = numbers.Contains(4); // false

                //// Remove an element
                //numbers.Remove(3);

                //// Iterate through the elements
                //Console.WriteLine("Elements in the HashSet:");
                //foreach (int number in numbers)
                //{
                //    Console.WriteLine(number);
                //}


            }


            // Arraylist(similar to list or we can say its a non-generic list)
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("hello");
            arrayList1.Add(true);

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }


        }

    }


}
