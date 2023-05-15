namespace NO8_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 8 : Try Catch */
            Console.WriteLine("Topic 8 : Try Catch"); // -> display title
            TryCatchSample();
        }

        static void TryCatchSample()
        {
            try
            {
                /* Division Sample */
                Console.WriteLine("Enter first number : ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int Quotient = firstNumber / secondNumber;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The error is : {0}", ex.Message); // -> this is the error message due to unable to divide the numbers.
            }
            
        }
    }
}