namespace NO12_ReturnType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 12 : Return Type */
            Console.WriteLine("Topic 12 : Return Type"); // -> display title
            int AddNum = add(5, 2);
            Console.WriteLine("The Sum is : " + AddNum);
            Console.WriteLine();
            Console.WriteLine("Your full name is : {0}", wholeName("Hax","Hex"));
        }

        // this is for int method
        static int add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        // this is for string method
        static string wholeName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}