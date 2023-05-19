using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO5_Polymorphism
{
    class Animal // Base Class(Parent)
    {
        /* Animal field attribute(s) */
        public string AnimalName { get; set; }
        public string AnimalGender { get; set; }
        public int AnimalAge { get; set; }

        /* Animal Constructor */
        public Animal(string AnimalName, string AnimalGender, int AnimalAge)
        {
            this.AnimalName = AnimalName;
            this.AnimalGender = AnimalGender;
            this.AnimalAge = AnimalAge;
        }

        public void AnimalDetails()
        {
            Console.WriteLine("Pet Information :");
            Console.WriteLine("Name            : " + AnimalName);
            Console.WriteLine("Gender          : " + AnimalGender);
            Console.WriteLine("Age             : " + AnimalGender);
        }

        /* Animal Class Object Methods Using Polymorphism */
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
}
