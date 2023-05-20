namespace NO23_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 23 : Polymorphism */
            Console.WriteLine("Topic NO 23 : Polymorphism");

            /* NOTE : If you used the child class (base on the code : Cat and Dog are the child class, and Animal is the base class.) 
               We used the base class(Animal). We cannot perform the Object Method base on Animal class because we are using the OOP 
               technique 'Polymorphism'.
               Syntax Example:

               Animal cat = new Cat("Kiragerla", "Female");
               cat.makeSound();
               Console.WriteLine();

               Animal dog = new Dog("Porkee", "Male");
               dog.makeSound();
             
               NOTE : If we use the child class(Cat and Dog). We can perform the Object Method base on Animal class.
               It will output the sound of the animals. EX: 'rawrf rawrf!' and 'meow meow'.
               Syntax Example:

               Cat cat = new Cat("Kiragerla", "Female");
               cat.makeSound();

               Dog dog = new Dog("Porkee", "Male");
               dog.makeSound();
               
               Hope this explanation may help you.. */

            Animal cat = new Cat("Kiragerla", "Female");
            cat.petInfo();
            cat.makeSound();
            Console.WriteLine();

            Animal dog = new Dog("Porkee", "Male");
            dog.petInfo();
            dog.makeSound();
        }
    }
}