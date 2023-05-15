namespace NO11_ParametersArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 11 : Parameters or Arguments */
            Console.WriteLine("Topic 11 : Parameters or Arguments"); // -> display title
            say(); // we displayed the output of method here, by calling the methods name.
            Console.WriteLine();
            SumOfTwoNumbers(2,4); // the output here is 6.
            Console.WriteLine();
            MyInformation("Hex", 22);
        }

        static void say(string name = "Hex") // we declare string data type variable that has a value of "Hex"
        {
            Console.WriteLine(name);
        }

        static void SumOfTwoNumbers(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void MyInformation(string name, int age) // we can add any data types in argument but make sure that we arrange it properly in calling the method.
        {
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My age is " + age);
        }
    }
}