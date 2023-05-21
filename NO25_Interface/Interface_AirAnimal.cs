using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO25_Interface
{
    /* This is for Land Animal Interface.
     * NOTE : We can inherit the Interface(s). */
    internal interface Interface_AirAnimal : Interface_LandAnimal
    {
        /* 'abstract' keyword is optional here, it can be accessible in Classes. */
        void fly();
    }
}
