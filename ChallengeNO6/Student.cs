using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO6
{
    internal class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int year { get; set; }
        public string course { get; set; }
        public char section { get; set; }

        public Student(string firstname, string lastname, int year, string course, char section)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.year = year;
            this.course = course;
            this.section = section;
        }

        public void StudentInfo()
        {
            Console.WriteLine("+-+ Student Information +-+");
            Console.WriteLine();
            Console.WriteLine("First Name : " + firstname);
            Console.WriteLine("Last Name  : " + lastname);
            Console.WriteLine("Year       : " + year);
            Console.WriteLine("Course     : " + course);
            Console.WriteLine("Section    : " + section);
            Console.WriteLine();
        }
    }
}
