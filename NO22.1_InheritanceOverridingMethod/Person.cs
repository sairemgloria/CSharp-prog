using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO22._1_InheritanceOverridingMethod
{
    internal class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        public Person(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        /* Object Method default */
        public void introduceSelf()
        {
            Console.WriteLine("Name   : " + name);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Age    : " + age);
        }
    }
}
