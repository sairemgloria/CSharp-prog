using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO5_Polymorphism
{
    class Cat : Animal // Derived Class (Child) 
    {
        /* Cat encapsulated field attribute(s) */
        private string meow;

        /* Getter & Setter for Cat Encapsulated Field Attribute(s) */
        public string Meow { get { return meow; } set {  meow = value; } }

        /* Cat Constructor with inherited Animal Class */
        public Cat(string AnimalName, string AnimalGender, int AnimalAge, string Meow) : base(AnimalName, AnimalGender, AnimalAge)
        {
            this.Meow = Meow;
        }

        /* Cat Class Object Methods Using Polymorphism */
        public override void AnimalSound()
        {
            Console.WriteLine("The cat says : meoww! meow!");
        }
    }
}
