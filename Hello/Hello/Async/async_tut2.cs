using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Asynchronous_Programming
{
    public class Task_Exceptions
    {
        public static async Task doSomethingAsync()
        {
            Console.WriteLine("doSomethingAsync started...");

            await Task.Delay(4000);
            
            //Task.Delay(4000).Wait();

            // The difference between the above two lines is huge
            // When you don't specify the await keywork, the main thread is blocked


            Console.WriteLine("doSomethingAsync ended!!!");
        }

        public static void Main(string[] args)
        {

            // Here we are handling exception which occurs during the execution of the task with
            // try-catch block
            // In this example we are taking input as 0 and dividing it which gives an exception
            {

                //Console.Write("Enter a number : ");
                //int input = Convert.ToInt32(Console.ReadLine());

                //Task task1 = Task.Run(() =>
                //{
                //    try
                //    {
                //        Task.Delay(3000).Wait();
                //        Console.WriteLine($"Input received was {input + 10}");
                //        int result = 10 / input;
                //    }

                //    catch (Exception ex)
                //    {
                //        Console.WriteLine($"Expection is {ex}");
                //    };
                //});

                //Console.WriteLine("Main function continues its work...");

                //task1.Wait();

                //Console.WriteLine("Main function finished!!");
            }


            // Making a function run in background
            {
                Console.WriteLine("Main function started...");

                Task t1 = doSomethingAsync();
                
                Console.WriteLine("Main function continues its work...");

                t1.Wait();
                Console.WriteLine("Main function finished!!");
            }

        }
    }
}
