using static System.Collections.Specialized.BitVector32;

namespace ChallengeNO6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge No : 6 */
            Console.Write("Enter the number of student's to be registered : ");
            int input = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[input];

            for (int x = 0; x < students.Length; x++)
            {
                Console.WriteLine("Student #" + (x + 1));
                Console.Write("First Name : ");
                string FirstName = Console.ReadLine();

                Console.Write("Last Name  : ");
                string LastName = Console.ReadLine();

                Console.Write("Year       : ");
                int Year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Course     : ");
                string Course = Console.ReadLine();

                Console.Write("Section    : ");
                char Section = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                students[x] = new Student(FirstName, LastName, Year, Course, Section);
            }

            foreach (Student student in students)
            {
                student.StudentInfo();
            }
        }
    }
}