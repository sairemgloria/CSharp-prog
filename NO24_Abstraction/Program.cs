namespace NO24_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 24 : Abstraction */
            Console.WriteLine("Topic NO 24 : Abstraction");
            Console.WriteLine();

            Animal cat = new Cat("Kiragerla",1,"GrayWhite");
            cat.petInfo();
            Console.Write("Cat sound : ");
            cat.makeSound();
            cat.sleep();
            Console.WriteLine();

            Animal dog = new Dog("Porkee",2,"White");
            dog.petInfo();
            Console.Write("Dog sound : ");
            dog.makeSound();
            dog.sleep();
        }
    }
}