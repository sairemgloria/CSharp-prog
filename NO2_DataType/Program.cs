namespace NO2_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 2 : Data Types */
            sbyte s = 120;
            short x = 3000;
            int number = 123456789;
            long LongNumber = 9000000000000;
            float FloatNumber = 99.55F; // -> need to put letter 'F' in the last digit of the number to considered as float || float can be used also in game development
            double DoubleNumber = 50.50; // -> 
            decimal DecimalNumber = 1.5M; // -> need to put letter 'M' in the last digit of the number to considered as decimal
            bool Switch = true;
            char SingleChar = 'C';
            string name = "Ryu";

            /* OUTPUTS */
            Console.WriteLine("sbyte: " + s);
            Console.WriteLine("short: " + x);
            Console.WriteLine("int: " + number);
            Console.WriteLine("long: " + LongNumber);
            Console.WriteLine("float: " + FloatNumber);
            Console.WriteLine("double: " + DoubleNumber);
            Console.WriteLine("decimal: " + DecimalNumber);
            Console.WriteLine("bool: " + Switch);
            Console.WriteLine("char: " + SingleChar);
            Console.WriteLine("string: " + name);

            /* NOTES */
            /* Always use declared variables unless it will allocate memory in the program :>  */
        }
    }
}