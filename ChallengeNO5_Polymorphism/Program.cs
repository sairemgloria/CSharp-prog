namespace ChallengeNO5_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge NO 5 : Polymorphism */
            Animal animal = new Animal("Animal","Unknown",1);
            animal.AnimalDetails();
            Console.WriteLine();

            Dog dog = new Dog("Subaru", "Male", 3, "Bark Sound");
            dog.AnimalDetails();
            dog.AnimalSound();
            Console.WriteLine();

            Cat cat = new Cat("Kiragerla", "Female", 1, "Meow Sound");
            cat.AnimalDetails();
            cat.AnimalSound();
        }
    }
}