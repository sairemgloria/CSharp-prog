namespace NO16_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic No 16 : OOP */
            Console.WriteLine("Topic No 16 : OOP");

            Person personOne = new Person();
            personOne.FirstName = "Alleria";
            personOne.LastName = "Galleria";
            personOne.Age = 20;
            personOne.Gender = 'F';

            Console.WriteLine(personOne.FirstName + " " + personOne.LastName);

            Person personTwo = new Person();
            personTwo.FirstName = "Benny";
            personTwo.LastName = "Saure";
            personTwo.Age = 22;
            personTwo.Gender = 'M';

            Person personThree = new Person();
            personThree.FirstName = "Cally";
            personThree.LastName = "Fornias";
            personThree.Age = 21;
            personThree.Gender = 'F';
        }
    }
}