using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.General
{
    internal class tuplePrac
    {
        public static void Main(string[] args)
        {
            // Ways of creating Tuples
            (int, string) person1 = (22, "Salil");
            Console.WriteLine(person1.Item1);
            person1.Item1 = 1;
            Console.WriteLine(person1.Item1);

            (int Age, string Name) person2 = (23, "Enjoy");
            Console.WriteLine(person2.Name);


            Tuple<int, string> person3 = Tuple.Create(24, "Bhul");

        }
        

    }
}
