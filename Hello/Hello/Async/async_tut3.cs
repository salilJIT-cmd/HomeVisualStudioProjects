using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Asynchronous_Programming
{
    public class async_tut3
    {
        public static void Main(string[] args)
        {
            Task<int> task1 = Task.Run(() =>
            {
                Task.Delay(3000).Wait();
                Console.WriteLine("Fetching data from database...");
                return 10;  // got from the database
            });

            Task task2 = task1.ContinueWith((previousTask) =>
            {
                int task1Result = task1.Result;
                Console.WriteLine("Store the database value in a file...");
            });

            Console.WriteLine("Main method continues its work...");

            //await task1;
            task2.Wait();

            Console.WriteLine("Main method finished!!");

        }
    }
}
