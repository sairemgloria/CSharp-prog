namespace NO4_DeclaringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 4 : Declaring Functions */
            Console.WriteLine("Topic 4 : Declaring function"); // -> display title
            Console.WriteLine("Sum of two numbers are : " + SumOfTwoNumbers()); // -> display the function. ANSWER = 30
            Console.WriteLine("Condition : " + Condition());
            MySwitch("Apple");
        }

        /* Create function */
        static int SumOfTwoNumbers()
        {
            int numOne = 10;
            int numTwo = 20;
            return numOne + numTwo;
        }

        /* Create function with condition */
        static int Condition()
        {
            if(30 > 40)
            {
                return 0; // return false
            }
            else
            {
                return 1; // return true
            }
        }

        static string MySwitch(string myString)
        {
            switch(myString)
            {
                case "Apple":
                    Console.WriteLine("The value is Apple");
                    Console.Read();
                    break;
                case "Orange":
                    Console.WriteLine("The value is Orange");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("The value is not Apple or Orange its " + myString);
                    Console.Read();
                    break;
            }
            return myString;
        }
    }
}