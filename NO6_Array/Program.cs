namespace NO6_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 6 : Array */
            Console.WriteLine("Topic 6 : Array"); // -> display title
            Arrays(); // -> display the output of function
        }

        static void Arrays()
        {
            string[] cars = {"Toyota","BMW","Ferrari"};
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Car Brand : " + cars[i]);
            }
        }
    }
}