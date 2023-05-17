using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO3
{
    internal class Student
    {

        /* Attributes of Student */
        public string firstName, lastName;
        public string year, course, section;
        public float prelimGrade, midtermGrade, finalGrade;

        /* Constructor of Student */
        public Student(string firstName, string lastName, string year, string course, string section, float prelimGrade, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            this.prelimGrade = prelimGrade;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public void introduceSelf()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine();
            Console.WriteLine("Student Name : " + firstName + " " + lastName);
            Console.WriteLine("Course       : " + course);
            Console.WriteLine("Year         : " + year);
            Console.WriteLine("Section      : " + section);
            Console.WriteLine();
        }

        public void evaluateGrade()
        {
            float average = (prelimGrade + midtermGrade + finalGrade) / 3;
            if(average > 100)
            {
                Console.WriteLine("Invalid Grade");
            }
            else if (average >= 98)
            {
                Console.WriteLine("Standing : With Highest Honors");
            }
            else if (average >= 95)
            {
                Console.WriteLine("Standing : With High Honors");
            }
            else if (average >= 90)
            {
                Console.WriteLine("Standing : With Honors");
            }
            else if (average >= 75)
            {
                Console.WriteLine("Standing : Passed");
            }
            else
            {
                Console.WriteLine("Standing : Failed");
            }
            Console.WriteLine("Average : " + average);
        }
    }
}
