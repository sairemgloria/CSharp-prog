namespace NO15_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic arithmetic = new Arithmetic();
            //Constants constants = new Constants();

            /* Topic 15 : Static */
            Console.WriteLine("Topic 15 : Static"); // -> display title
            Console.Write("Enter your name : ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your age : ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                Greetings.greetings(name, age);
            }
            catch
            {
                Console.WriteLine("invalid input");
            }

            //Console.WriteLine("Sum : {0}", Arithmetic.Add(5, 2)); // we can now use the Arithmetic class and Add function without calling the instance of a Class Arithmetic.

            //Console.WriteLine("Product : {0}", Arithmetic.Multiply(5, 2));
            Arithmetic.Multiply(5, 2);
            Arithmetic.Add(5, 2);

            Console.WriteLine("PI Value : {0}", Constants.PI);
            Console.WriteLine("Gravity Value : {0}", Constants.GRAVITY);
            Console.WriteLine("Tan Value : {0}", Constants.Tan);

            Console.WriteLine(Subtract(5,2));
        }

        static int Subtract(int x, int y)
        {
            int diff = x - y;
            return diff;
        }
    }
}