namespace NO14_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 14 : Classes */
            Console.WriteLine("Topic 14 : Classes"); // -> display title

            Arithmetic arithmetic = new Arithmetic(); // we instantiate the Arithmetic Class here.
            Constants constants = new Constants(); // we instantiate the Constants Class here.

            //arithmetic.Add(5,3);
            //arithmetic.Subtract(5, 3);
            //arithmetic.Multiply(5, 3);
            //arithmetic.Divide(5, 3);
            //constants.PI;
            //constants.GRAVITY;

            Console.WriteLine("Sum : {0}", arithmetic.Add(5, 3));
            Console.WriteLine("Differnce : {0}", arithmetic.Subtract(5, 3));
            Console.WriteLine("Product : {0}", arithmetic.Multiply(5, 3));
            Console.WriteLine("Quotient : {0}", arithmetic.Divide(5, 3));
            Console.WriteLine("Value of PI : {0}", constants.PI);
            Console.WriteLine("Gravity : {0}", constants.GRAVITY);
        }
    }
}