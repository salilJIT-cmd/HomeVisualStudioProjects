using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class Stack_tut
    {

        static public void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();

            // 1. Insertion
            myStack.Push("salil");  // adds the element to the top of the stack
            myStack.Push("Anchal");
            myStack.Push("Sahil");
            Console.WriteLine(myStack.Count);

            // The collection initializer syntax for Stack<T>
            // doesn't directly support adding elements like it does for some other
            // collection types like lists or dictionaries. 
            //Stack<int> myStack2 = new Stack<int>() {1, 2, 3};  // gives error


            // 2. Accessing an element
            // Note - The Stack class is designed as a last-in, first-out (LIFO) data structure,
            // and its elements are not directly indexed or accessible by index.
            //Console.WriteLine(myStack[1]);  // gives error
            Console.WriteLine(myStack.Peek()); // gives the element at the top 

            // Note: As a stack is not indexed, we cannot directly modify a particular element


            // 3.Deletion
            Console.WriteLine(myStack.Pop());   // deletes element from top
            myStack.Clear();   // delete entire stack


            // 4. Printing the whole stack
            foreach (string item in myStack)
            {
                Console.WriteLine(item);
            }


            // 5. Find an element based on a particular condition
            //just use foreach loop like above


            // 6. Check the availiability of a value
            Console.WriteLine(myStack.Contains("salil"));  // gives false


        }
    }


}
