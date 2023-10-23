using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello2;
using Generic_Collections;
using System.Collections;

namespace Hello
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Salil And His Girl Anchal";
            string s2 = "salil.deogade@gmail.com";

            //
            Console.WriteLine(s1.Substring(4));
            Console.WriteLine(s1.Substring(4, 7));


            //
            string[] newArray = s2.Split('@');
            foreach (string item in newArray)
            {
                //Console.WriteLine(item);
            }

            string s3 = string.Join("@", newArray);
            //Console.WriteLine(s3);

            // 
            for(int i = 0;  i < s1.Length; i = i + 2)
            {
                Console.WriteLine(s1[i]);

            }
        }
    }
}
