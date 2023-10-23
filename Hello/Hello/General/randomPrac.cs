using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class randomPrac
    {
        public static void Main(string[] args)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string randomStringWithLength10 = "";

            for (int i = 0; i < 10; i++) { 
            
                int randomNum = random.Next(chars.Length);
                randomStringWithLength10 += chars[randomNum];
            
            }
            Console.WriteLine(randomStringWithLength10);


            string[] arr = {"Achal", "Salil", "Rohit", "Karma" };
            Console.WriteLine(arr[random.Next(arr.Length)]);
        }
    }
}
