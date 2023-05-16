using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO17_Constructor
{
    internal class Product
    {

        // this are attributes sample
        public string name;
        public float price;

        // this is a sample constructor
        public Product(string name, float price)
        {
            this.name = name; // this keyword refers to the Class Product. name refers to the string attribute inside the parameter.
            this.price = price; // this keyword refers to the Class Product. price refers to the float attribute inside the parameter.
        }
    }
}
