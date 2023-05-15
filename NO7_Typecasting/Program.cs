namespace NO7_Typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 7 : Typecasting */
            Console.WriteLine("Topic 7 : Typecasting"); // -> display title
            SumProcess();
        }

        static void SumProcess()
        {
            Console.WriteLine("Enter first number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of two number is : {0}", firstNumber + secondNumber);
        }
    }
}