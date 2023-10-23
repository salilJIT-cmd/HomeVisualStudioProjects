using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello2
{
    public class Animal
    {
        int age;

        public int Age
        {
            get { 
                return age;
            }
            set { 
                age = value;
            }

        }
        public Animal(string _name)
        {
            Console.WriteLine("Animal Constructor ", _name);
        }

        public void simple()
        {
            Console.WriteLine("Simple in dog");
        }

        public virtual void sound()
        {
            Console.WriteLine("Animal Sound");
        }

        ~Animal() {
            Console.WriteLine("Destructor called");
        }


    }

    public class Dog : Animal
    { 
        public Dog() : base("cat")
        {
            Console.WriteLine("Dog Constructor Called");
        }

        public void simple()
        {
            Console.WriteLine("Simple in dog");
        }

        public override sealed void sound()
        {
            Console.WriteLine("Dog Sound");
        }




    }

    public class Human
    {
        Animal animal1 = new Animal("Cat");

       
    }
}
