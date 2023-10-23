using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Prac
{
    public class Basic_Prac
    {
        public static void Main(string[] args)
        {
            // 1. Simple list
            {
                //List<int> list1 = new List<int> {1,2,3,4,5,6,7,8,9,10};

                //// Using LINQ
                //var query1 = from i in list1
                //             where i <= 5
                //             select i;

                //foreach (int i in query1)
                //{
                //    Console.WriteLine(i);
                //}


                //// Using method approach
                //foreach (int i in list1)
                //{
                //    if(i <= 5)
                //    {
                //        Console.WriteLine(i);
                //    }
                //}
                

            }

            // 2. Simple Dictionary
            {
                // Contains 'year' as value and number of 'births per year' as key
                //Dictionary<int, int> dict1 = new Dictionary<int, int>();
                //dict1.Add(2001, 3000);
                //dict1.Add(2002, 5000);
                //dict1.Add(2003, 1000);
                //dict1.Add(2004, 2500);
                //dict1.Add(2005, 7000);
                //dict1.Add(2006, 4000);
                //dict1.Add(2007, 3500);
                //dict1.Add(2008, 5000);

                //// LINQ - query1
                //var query1 = from entry in dict1
                //             where entry.Key < 2006
                //             select entry;

                //foreach (var entry in query1)
                //{
                //    Console.WriteLine($"{entry.Key} : {entry.Value}");
                //}

                //// LINQ - query2
                //Console.WriteLine("QUERY 2 -->");
                //var query2 = from entry in dict1
                //             where entry.Value > 2500 && entry.Value < 6000
                //             orderby entry.Value
                //             select entry;


                //foreach (var entry in query2)
                //{
                //    Console.WriteLine($"{entry.Key} : {entry.Value}");
                //}


            }


            // 3. Simple Stack
            {
                Console.WriteLine("Stack starts here...");
                Stack<int> stack1 = new Stack<int>();
                stack1.Push(2);
                stack1.Push(1);
                stack1.Push(3);
                stack1.Push(6);
                stack1.Push(4);
                stack1.Push(5);

                // LINQ
                var query1 = from s in stack1
                             where s > 3 
                             orderby s descending
                             select s;

                foreach (var s in query1)
                {
                    Console.WriteLine(s);
                }

            }

        }
    }
}
