using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO5._1
{
    internal class BSCS : Student
    {
        private string majorSoftware;
        public string MajorSoftware 
        { 
            get { return majorSoftware; } 
            set {  majorSoftware = value; } 
        }

        public BSCS(int StudentIDNo, string firstname, string middlename, string lastname, string studentYear, string studentCourse, char studentGender, string studentContactNo, string MajorSoftware)
            : base(StudentIDNo, firstname, middlename, lastname, studentYear, studentCourse, studentGender, studentContactNo)
        {
            this.MajorSoftware = MajorSoftware;
        }

        public override void StudentInfo()
        {
            Console.WriteLine("- - - BSCS Student Information - - -");
            Console.WriteLine();
            base.StudentInfo(); // use this method for polymorphism, this is base on Student Class.
            Console.WriteLine("Major Focus  : " + MajorSoftware);
        }
    }
}
