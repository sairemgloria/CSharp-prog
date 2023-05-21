namespace NO25_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 25 : Interface */
            Console.WriteLine("Topic NO 25 : Interface");
            Console.WriteLine();

            Console.WriteLine("Dog Detail :");
            Dog dog = new Dog();
            dog.walk();
            dog.makeSound();
            Console.WriteLine();

            Console.WriteLine("Cat Detail :");
            Cat cat = new Cat();
            cat.walk();
            cat.makeSound();
            Console.WriteLine();

            Console.WriteLine("Bird Detail :");
            Bird bird = new Bird();
            bird.walk();
            bird.makeSound();
            bird.fly();
        }
    }
}