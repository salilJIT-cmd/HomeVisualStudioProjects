using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class Queue_tut
    {

        static public void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            // 1. Insertion
            myQueue.Enqueue("salil"); // Adds an object to the end of the Queue.
            myQueue.Enqueue("Anchal");
            myQueue.Enqueue("Sahil");
            Console.WriteLine(myQueue.Count);


            // 2. Accessing an element
            // Note - The Queue class is also not indexed like Stack.
            //Console.WriteLine(myQueue[1]);  // gives error
            Console.WriteLine(myQueue.Peek()); // returns the object at the beginning of Queue

            // Note: As a queue is not indexed, we cannot directly modify a particular element


            // 3.Deletion
            Console.WriteLine(myQueue.Dequeue());   // Removes and returns the object at the beginning of the Queue.
            //myQueue.Clear();   // delete entire queue


            // 4. Printing the whole queue
            foreach (string item in myQueue)
            {
                Console.WriteLine(item);
            }


            // 5. Find an element based on a particular condition
            //just use foreach loop like above


            // 6. Check the availiability of a value
            Console.WriteLine(myQueue.Contains("salil"));  // gives false



        }
    }


}
