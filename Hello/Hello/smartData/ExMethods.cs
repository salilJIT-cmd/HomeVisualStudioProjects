using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.smartData
{

    interface Animal
    {
        void sound();
    }

    static class AnimalExtend
    {
        public static void methAE(this Animal a)
        {
            Console.WriteLine("Sound of this Animal is:");
            a.sound();
        }
    }

    public class Dog : Animal
    {
        public void sound()
        {
            Console.WriteLine("Barking...");
        }
    }

    public class Cat : Animal
    {
        public void sound()
        {
            Console.WriteLine("Meowwwwwww...");
        }
    }



    public class ExMethods
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.sound();
            dog.methAE();

        }
    }
}
