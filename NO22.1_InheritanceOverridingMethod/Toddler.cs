using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO22._1_InheritanceOverridingMethod
{
    internal class Toddler : Person
    {
        public string hobby { get; set; }

        public Toddler(string name, string gender, int age, string hobby) : base(name, gender, age)
        {
            this.hobby = hobby;
        }

        /* We use Overriding Methods here */
        public void introduceSelf()
        {
            base.introduceSelf(); // overriding method from Person Class.
            Console.WriteLine("Hobby  : " + hobby); // added object method.
        }
    }
}
