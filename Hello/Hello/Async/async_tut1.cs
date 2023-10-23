using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Asynchronous_Programming
{
    public class Class1
    {
        public async Task<int> FetchData()
        {
            Console.WriteLine("Method1 - Fetching Data from database");
            await Task.Delay(5000);   // can be replaced by a real-world async operation like data fetching
            return 10;
        }
        public async Task<int> GettingEmail()
        {
            await Task.Delay(3000);
            return 20;
        }
    }
    public class Task_tut1
    {

        // You can use Task<T> to return a result from an asynchronous operation.
        

        //public static async Task Main(string[] args)
        public static void Main(string[] args)

        {
            // 1------------------------------1
            {
                //Class1 class1 = new Class1();

                //// await tells the program to wait 
                ////int result1 = await class1.FetchData();
                ////Console.WriteLine($"Result1: {result1}");

                ////int result2 = await class1.GettingEmail();
                ////Console.WriteLine($"Result2: {result2}");


                //Task<int> gotTask = class1.FetchData();
                //Task<int> gotTask2 = class1.GettingEmail();


                //Console.WriteLine("Main method continues its work1...");

                //int gotTask2Result = gotTask2.Result;
                //Console.WriteLine(gotTask2Result);

                //Console.WriteLine("Main method continues its work2...");

                //int gotTaskResult = gotTask.Result;
                //Console.WriteLine(gotTaskResult);

                //Console.WriteLine("Main method continues its work3...");

            }



            // 2---------------------2
            // Running a simple task asynchronously
            {
                //Task task1 = Task.Run(async () =>
                //{
                //    await Task.Delay(3000);
                //    Console.WriteLine("Fetching data from database");
                //});

                //Console.WriteLine("Main method continues its work...");


                //// This line tells the main() method to stop for the task1 and don't finish executing
                //await task1;
                //// or
                ////task.Wait();

            }


            // 3-----------------------3
            // Continuations with Tasks:
            // You can attach continuations to a Task to specify what to do when the task completes.
            {

                Task<int> task1 = Task.Run( async() =>
                {
                    await Task.Delay(3000);
                    Console.WriteLine("Fetching data from database...");
                    return 10;  // got from the database
                });

                //Task task2 = task1.ContinueWith((previousTask) =>
                //{
                //    int task1Result = task1.Result;
                //    Task.Delay(3000).Wait();
                //    Console.WriteLine("Store the database value in a file...");
                //});

                Console.WriteLine("Main method continues its work...");

                 //await task1; 
                 // there's no need to await for task1 as task2 depends on task1 to complete
                 // So as long as the main program waits for task2, it indirectly waits for task1 as well
                //await task2;
                task1.Wait();

                Console.WriteLine("Main method finished!!!");

            }

        }
    }
}
