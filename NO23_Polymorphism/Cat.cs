using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO23_Polymorphism
{
    internal class Cat : Animal
    {
        public Cat(string name, string sex) : base(name, sex)
        {
            this.name = name;
            this.sex = sex;
        }

        // we use the override keyword to apply the polymorphism
        public override void petInfo()
        {
            Console.WriteLine("Pet Information");
            Console.WriteLine("Pet name : " + name);
            Console.WriteLine("Gender : " + sex);
        }

        // we use the override keyword to apply the polymorphism
        public override void makeSound()
        {
            Console.WriteLine("The cat say's 'meow meow'..");
        }
    }
}
