using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO24_Abstraction
{
    internal class Cat : Animal // we inherited the Animal abstract class.
    {
        // Cat attribute(s)
        public string catColor { get; set; }

        // Cat constructor
        public Cat(string name, int age, string catColor) : base(name, age)
        {
            this.catColor = catColor;
        }

        // abstract object methods.
        /* NOTE : we use the 'abstract' keyword in Abstraction and 'override' keyword in inherited(child) class. */
        public override void makeSound()
        {
            Console.WriteLine("meow meow!");
        }

        // Cat class object method(s) with Polymorphism.
        /* NOTE : we use the 'virtual' keyword in Polymorphism and 'override' keyword in inherited(child) class. */
        public override void petInfo()
        {
            Console.WriteLine("Pet Information : Cat");
            base.petInfo();
            Console.WriteLine("Color : " + catColor);
        }
        public override void sleep()
        {
            Console.Write("Cat is sleeping.. ");
            base.sleep();
        }
    }
}
