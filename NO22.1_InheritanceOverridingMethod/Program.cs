namespace NO22._1_InheritanceOverridingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 22.1 : Inheritance Overriding Method */
            Console.WriteLine("Topic NO 22.1 : Inheritance Overriding Method");

            Console.WriteLine("Without Overriding Method :");
            Person person = new Person("Cake","Female",22);
            person.introduceSelf();
            Console.WriteLine();

            Console.WriteLine("With Overriding Method :");
            Toddler toddler = new Toddler("CinnamonRoll","Male",25,"Playing piano");
            toddler.introduceSelf();
            Console.WriteLine();
        }
    }
}