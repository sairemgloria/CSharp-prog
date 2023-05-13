namespace NO5_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 5 : Loops */
            Console.WriteLine("Topic 5 : Loops"); // -> display title
            Console.WriteLine("OUTPUT FOR WHILE LOOP: ");
            WhileLoop();
            Console.WriteLine("OUTPUT FOR DO WHILE LOOP: ");
            DoWhileLoop();
            Console.WriteLine("OUTPUT FOR FOR LOOP: ");
            ForLoop();
        }

        /* While Loop Function */
        static void WhileLoop()
        {
            int i = 1; // -> declared variable, count starts at 1 to 5
            while (i <= 5) // -> check the condition
            {
                Console.WriteLine("Hello, world!", i); // -> output
                i++; // -> iteration or increment
            }
        }

        /* Do While Loop Function */
        static void DoWhileLoop()
        {
            int j = 1; // -> declared variable, count starts at 1 to 5
            do
            {
                Console.WriteLine("Henlo, mundo!", j); // -> output
                j++; // -> iteration or increment
            } while (j <= 5); // -> check the condition
        }

        /* For Loop Function */
        static void ForLoop()
        {
            for (int k = 1; k <= 5; k++)
            {
                Console.WriteLine("Hellow, wazzap!", k);
            }
        }
    }
}