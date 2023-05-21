using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO25_Interface
{
    /* NOTE : We use inheritance in the interface. We can now access the Parent class\interface and Child class\interface. */
    internal class Bird : Interface_Animal,Interface_AirAnimal
    {
        public void makeSound() // this method is from Interface_Animal..
        {
            Console.WriteLine("chirp chirp");
        }
        public void walk() // this method is from Interface_LandAnimal..
        {
            Console.WriteLine("bird : walk slower...");
        }
        public void fly() // this method is from Interface_AirAnimal..
        {
            Console.WriteLine("bird : wooosh!!");
        }
    }
}
