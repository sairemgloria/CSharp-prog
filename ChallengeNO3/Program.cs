namespace ChallengeNO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge NO : 3 */
            Console.WriteLine("Challenge NO    : 3");

            Console.Write("Enter first name    : ");
            string FirstName = Console.ReadLine();

            Console.Write("Enter last name     : ");
            string LastName = Console.ReadLine();

            Console.Write("Year level          : ");
            string Year = Console.ReadLine();

            Console.Write("Course name         : ");
            string Course = Console.ReadLine();

            Console.Write("Section             : ");
            string Section = Console.ReadLine();

            Console.Write("Enter prelim grade  : ");
            float PrelimGrade = float.Parse(Console.ReadLine());

            Console.Write("Enter midterm grade : ");
            float MidtermGrade = float.Parse(Console.ReadLine());

            Console.Write("Enter final grade   : ");
            float FinalGrade = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Student studentOne = new Student(FirstName, LastName, Year, Course, Section, PrelimGrade, MidtermGrade, FinalGrade);
            studentOne.introduceSelf();
            studentOne.evaluateGrade();
        }
    }
}