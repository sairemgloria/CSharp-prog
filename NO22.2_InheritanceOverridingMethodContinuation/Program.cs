namespace NO22._2_InheritanceOverridingMethodContinuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 22.2 : Inheritance Overriding Method Continue */
            Console.WriteLine("Topic NO 22.2 : Inheritance Overriding Method Continue");

            BasicEnemy BE = new BasicEnemy("Evil enemy", 100, 5);
            BE.attack();
            BE.walk();
            BE.die();
            Console.WriteLine();

            FlyingEnemy FE = new FlyingEnemy("Air enemy", 100, 25);
            FE.attack();
            FE.fly();
            FE.die();
            Console.WriteLine();
        }
    }
}