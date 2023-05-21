using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO25_Interface
{
    /* We do not use Inherit here, instead we Implement the interface(s) here inside the class.
     * NOTE : only in Interface can multiple implementation inside the class.
     *        cannot be use multiple innheritance inside the class. */
    internal class Cat : Interface_Animal,Interface_LandAnimal
    {
        /* We can now access the method inside the interface(s).
         * NOTE : also use the public keyword for access modifier to prevent error. */
        public void makeSound() // this method is from Interface_Animal..
        {
            Console.WriteLine("meow");
        }
        public void walk() // this method is from Interface_LandAnimal..
        {
            Console.WriteLine("cat : walking slowly..");
        }
    }
}
