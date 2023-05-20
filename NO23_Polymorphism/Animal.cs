using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO23_Polymorphism
{
    internal class Animal
    {
        public string name { get; set; }
        public string sex { get; set; }

        public Animal(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        // we use the virtual keyword to apply the polymorphism
        public virtual void petInfo()
        {
            // this is for polymorphism
            Console.WriteLine("NOTE : Override this to make method in Cat and Dog Class.");
        }

        // we use the virtual keyword to apply the polymorphism
        public virtual void makeSound()
        {
            // this is for polymorphism
            Console.WriteLine("NOTE : Override this to make method in Cat and Dog Class.");
        }
    }
}
