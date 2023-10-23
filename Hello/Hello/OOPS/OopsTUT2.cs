using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.OOPS
{
    // abstract classes and virtual/override/sealed keyword
    abstract public class Mobile
    {
        abstract public string Name();

        public virtual void off()
        {
            Console.WriteLine("BaseClass's sealed method.");
        }
    }

    // Note - so there's no way, if i want to restrict the immediate class to override a method in c#
    public class Nokia : Mobile
    {
        public override string Name()
        {
            return "Nokia";
        }

        public sealed override void off()
        {
            Console.WriteLine("Nokia OFF");
        }   
    }

    internal class OopsTUT2
    {
        public static void Main(string[] args) { 

        }

    }
}
