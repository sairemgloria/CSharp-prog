namespace NO17_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic No 17 : Constructor */
            Console.WriteLine("Topic No 17 : Constructor");

            //Product productOne = new Product("Coke", 75);
            //Product productTwo = new Product("Milk", 150);

            //// this is output for Coke
            //Console.WriteLine("Product : {0}", productOne.name);
            //Console.WriteLine("Price   : {0}", productOne.price);

            //// this is output for Milk
            //Console.WriteLine("Product : {0}", productTwo.name);
            //Console.WriteLine("Price   : {0}", productTwo.price);
            
            try
            {
                Console.Write("Enter Firstname : ");
                string firstname = Console.ReadLine();
                Console.Write("Enter Lastname : ");
                string lastname = Console.ReadLine();
                Console.Write("Enter Age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Sex : ");
                char sex = Convert.ToChar(Console.ReadLine());
                Student student = new Student(firstname, lastname, age, sex);
            }
            catch
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}