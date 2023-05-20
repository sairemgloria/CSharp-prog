namespace ChallengeNO5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge NO 5.1 : Polymorphism */

            Student bsit = new BSIT(1, "Sairem", "Placido", "Gloria", "4th Year", "BSIT", 'M', "0999-123-4567", "C#");
            bsit.StudentInfo();
            Console.WriteLine();

            Student bscs = new BSCS(1, "Hax", "Unknown", "Hex", "4th Year", "BSCS", 'M', "0999-123-4567", "Robotics");
            bscs.StudentInfo();
        }
    }
}