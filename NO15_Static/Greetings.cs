using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO15_Static
{
    static class Greetings
    {
        public static void greetings(string name, int age)
        {
            Console.WriteLine("Your name is : {0}" , name);
            Console.WriteLine("Your age is : {0}", age);
        }
    }
}
