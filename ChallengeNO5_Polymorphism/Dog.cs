using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO5_Polymorphism
{
    class Dog : Animal // Derived Class (Child) 
    {
        /* Dog encapsulated field attribute(s) */
        private string bark;

        /* Getter & Setter for Dog Class Encapsulated Field Attribute(s) */
        public string Bark { get { return bark; } set { bark = value; } }

        /* Dog Constructor with inherited Animal Class */
        public Dog(string AnimalName, string AnimalGender, int AnimalAge, string Bark) : base(AnimalName, AnimalGender, AnimalAge)
        {
            this.Bark = Bark;
        }

        /* Dog Class Object Methods Using Polymorphism */
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says : rarwf! rarwf!");
        }
    }
}
