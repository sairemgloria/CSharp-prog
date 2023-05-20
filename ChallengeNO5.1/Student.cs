using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChallengeNO5._1
{
    internal class Student
    {
        /* Student Attribute(s) */
        private int studentIDNo; // this is encapsulated attribute we need to use getter and setter to access this attribute.
        public int StudentIDNo
        {
            get { return studentIDNo; }
            set { studentIDNo = value; }
        }

        public string firstname {  get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string studentYear { get; set; }
        public string studentCourse { get; set; }
        public char studentGender { get; set; }
        public string studentContactNo { get; set; }

        /* Student Constructor */
        public Student(int StudentIDNo, string firstname, string middlename, string lastname, string studentYear, string studentCourse, char studentGender, string studentContactNo)
        {
            this.StudentIDNo = StudentIDNo;
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.studentYear = studentYear;
            this.studentCourse = studentCourse;
            this.studentGender = studentGender;
            this.studentContactNo = studentContactNo;
        }

        /* Student Object Methods */
        public virtual void StudentInfo()
        {
            // use this method for polymorphism.
            Console.WriteLine("Student ID   : " + StudentIDNo);
            Console.WriteLine("First Name   : " + firstname);
            Console.WriteLine("Middle Name  : " + middlename);
            Console.WriteLine("Last Name    : " + lastname);
            Console.WriteLine("Year         : " + studentYear);
            Console.WriteLine("Course       : " + studentCourse);
            Console.WriteLine("Gender       : " + studentGender);
            Console.WriteLine("Contact      : " + studentContactNo);
        }
    }
}
