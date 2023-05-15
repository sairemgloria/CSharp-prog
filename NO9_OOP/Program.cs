namespace NO9_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 9 : Methods */
            Console.WriteLine("Topic 9 : Methods"); // -> display title
            // this will show message "Hi"
            sayHi();

            // this code will do for loop and output has five times of "Hello"
            for(int i = 1; i < 5; i++)
            {
                sayHello();
            }
        }

        // this method will say "Hello"
        static void sayHello()
        {
            Console.WriteLine("Hello");
        }

        // this method will say "Hi"
        static void sayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}