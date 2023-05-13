namespace NO3_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic 3 : Operators */
            int numOne = 10;
            int numTwo = 20;
            int SumOfTwoNum = numOne + numTwo;
            int DifferenceOfTwoNum = numOne - numTwo;
            int ProductOfTwoNum = numOne * numTwo;
            int QuotientOfTwoNum = numOne / numTwo;
            int ModulusOfTwoNum = numOne % numTwo;

            /* OUTPUTS */
            Console.WriteLine("The sum of two numbers are : " + SumOfTwoNum); // Since addition is used it will add the two numbers. ANSWER = 30
            Console.WriteLine("The difference of two numbers are : " + DifferenceOfTwoNum); // Since subtraction is used it will minus the two numbers. ANSWER = -10
            Console.WriteLine("The product of two numbers are : " + ProductOfTwoNum); // Since multiplication is used it will multiply the two numbers. ANSWER = 200
            Console.WriteLine("The quotient of two numbers are : " + QuotientOfTwoNum); // Since division is used it will divide the two numbers. ANSWER = 0
            Console.WriteLine("The remainder of two numbers are : " + ModulusOfTwoNum); // Since modulus is used it will get the remainder of the two numbers. ANSWER = 10
        }
    }
}