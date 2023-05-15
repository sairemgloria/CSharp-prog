namespace NO10_VariableScoping
{
    internal class Program
    {
        /* this are example of GLOBAL Variables
         * can be access in other functions or methods. */
        static string global_name = "Hax"; 
        static int global_age = 21;

        static void Main(string[] args)
        {
            /* Topic 10 : Variable Scoping */
            Console.WriteLine("Topic 10 : Variable Scoping"); // -> display title
            // output for local variables
            Console.WriteLine("Local Informations : ");
            MyInfo();
            Console.WriteLine();

            // output for global variables
            Console.WriteLine("Global Informations :");
            Console.WriteLine("Global name is : " + global_name);
            Console.WriteLine("Global age is : " + global_age);
        }

        static void MyInfo()
        {
            string local_name = "Hex"; // this are local variables, cannot be access to another method,classes.
            int local_age = 22; // this are local variables, cannot be access to another method,classes.
            Console.WriteLine("My name is " + local_name);
            Console.WriteLine("My age is " + local_age);
        }
    }
}