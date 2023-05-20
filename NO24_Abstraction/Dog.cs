using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO24_Abstraction
{
    internal class Dog : Animal // we inherited the Animal abstract class.
    {
        // Dog attribute(s)
        public string dogColor {  get; set; }

        // Dog constructor
        public Dog(string name, int age, string dogColor) : base(name, age)
        {
            this.dogColor = dogColor;
        }

        // abstract object methods.
        /* NOTE : we use the 'abstract' keyword in Abstraction and 'override' keyword in inherited(child) class. */
        public override void makeSound()
        {
            Console.WriteLine("rawrf rawrf!");
        }

        // Dog class object method(s) with Polymorphism.
        /* NOTE : we use the 'virtual' keyword in Polymorphism and 'override' keyword in inherited(child) class. */
        public override void petInfo()
        {
            Console.WriteLine("Pet Information : Dog");
            base.petInfo();
            Console.WriteLine("Color : " + dogColor);
        }
        public override void sleep()
        {
            Console.Write("Dog is sleeping.. ");
            base.sleep();
        }
    }
}
