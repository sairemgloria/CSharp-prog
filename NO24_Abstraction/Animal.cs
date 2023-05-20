using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO24_Abstraction
{
    abstract internal class Animal // we need to add abstract word in the class.
    {
        // this are the attribute(s) of Animal class..
        public string name { get; set; }
        public int age { get; set; }

        // we create constructor for Animal class..
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // we need to set as public the methods here because the default method is always set in private.
        /* NOTE : we use the 'abstract' keyword in Abstraction and 'override' keyword in inherited(child) class. */
        public abstract void makeSound();

        // Animal abstract class object method(s) with Polymorphism.
        /* NOTE : we use the 'virtual' keyword in Polymorphism and 'override' keyword in inherited(child) class. */
        public virtual void petInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age  : " + age);
        }
        public virtual void sleep()
        {
            Console.WriteLine("zzZ");
        }
    }
}
