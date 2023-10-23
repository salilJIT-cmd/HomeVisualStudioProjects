using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Hello.OOPS
{
    // Basic OOPs revision
    public class Human {
        public string Name;
        public int Age;


        // Initializer Constructor(C# 9 and Later):
        public Human(string _Name, int _Age)
        {
            _ = (Name = _Name, Age = _Age);
        }


        public void eat()
        {
            Console.WriteLine("Human Eating!");
        }

    }

    public class Human2 : Human
    {
        public Human2(string _Name, int _Age): base(_Name, _Age) {
        }

        public void eat()
        {
            Console.WriteLine("Human2 Eating!");
        }
    }


    public class OopsTUT1
    {
        public static void Main(string[] args)
        {

        }
    }
}
