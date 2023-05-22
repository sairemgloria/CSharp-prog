namespace NO26._1_ArrayOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO26.1 : Array of Object */
            Console.WriteLine("Topic NO26.1 : Array of Object");
            Console.WriteLine();

            Animal[] animals = new Animal[5];
            animals[0] = new Pig();
            animals[1] = new Dog();
            animals[2] = new Dog();
            animals[3] = new Pig();
            animals[4] = new Dog();

            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].makeSound();
            }
        }
    }
}