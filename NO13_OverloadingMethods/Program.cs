namespace NO13_OverloadingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 13 : Overloading Methods */
            Console.WriteLine("Topic 13 : Overloading Methods"); // -> display title
            Console.WriteLine(add(5,4)); // the output here is 9
            Console.WriteLine(add(5,6,7)); // the output here is 18
        }

        // this is sample of overloading methods check the code below
        static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}