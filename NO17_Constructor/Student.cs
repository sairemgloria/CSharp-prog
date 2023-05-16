using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO17_Constructor
{
    internal class Student
    {
        // attributes
        public string firstname;
        public string lastname;
        public int age;
        public char sex;

        // constructor
        public Student(string firstname, string lastname, int age, char sex)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.sex = sex;

            Console.WriteLine("Student successfully created!");
            Console.WriteLine("Firstname : {0}", firstname);
            Console.WriteLine("Lastname  : {0}", lastname);
            Console.WriteLine("Age       : {0}", age);
            Console.WriteLine("Sex       : {0}", sex);
            Console.WriteLine();
        }
    }
}
