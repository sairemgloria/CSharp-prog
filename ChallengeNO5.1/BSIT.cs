using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO5._1
{
    internal class BSIT : Student
    {
        private string majorPrograming;
        public string MajorProgramming
        {
            get { return majorPrograming; }
            set { majorPrograming = value; }
        }

        public BSIT(int StudentIDNo, string firstname, string middlename, string lastname, string studentYear, string studentCourse, char studentGender, string studentContactNo, string MajorProgramming) 
            : base(StudentIDNo, firstname, middlename, lastname, studentYear, studentCourse, studentGender, studentContactNo)
        {
            this.MajorProgramming = MajorProgramming;
        }

        public override void StudentInfo()
        {
            Console.WriteLine("- - - BSIT Student Information - - -");
            Console.WriteLine();
            base.StudentInfo(); // use this method for polymorphism, this is base on Student Class.
            Console.WriteLine("Major Focus  : " + MajorProgramming);
        }
    }
}
