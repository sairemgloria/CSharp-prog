namespace NO6_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 6 : Array */
            Console.WriteLine("Topic 6 : Array"); // -> display title
            Arrays(); // -> display the output of function
            Console.WriteLine();
            ForeachTuts(); // -> display the output of foreach function
        }

        /* Array */
        static void Arrays()
        {
            string[] cars = {"Toyota","BMW","Ferrari"};
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Car Brand : " + cars[i]);
            }
        }

        /* Foreach */
        static void ForeachTuts()
        {
            string[] Fruits = { "Apple", "Banana", "Mango" };
            foreach (string f in Fruits)
            {
                Console.WriteLine(f);
            }
        }
    }
}