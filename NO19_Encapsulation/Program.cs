namespace NO19_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 19 : Encapsulation */
            Console.WriteLine("Topic NO 19 : Encapsulation");

            try
            {
                // this are the Getters ..
                Console.Write("Enter user id   : "); int UserID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter username  : "); string Username = Console.ReadLine();
                Console.Write("Enter firstname : "); string FirstName = Console.ReadLine();
                Console.Write("Enter lastname  : "); string LastName = Console.ReadLine();

                User u = new User(UserID, Username, FirstName, LastName); // we instantiate the User class ..

                // this are the Setters ..
                Console.WriteLine("Person Information");
                Console.WriteLine("UID       : {0}", u.UserID);
                Console.WriteLine("Username  : {0}", u.Username);
                Console.WriteLine("Firstname : {0}", u.FirstName);
                Console.WriteLine("Lastname  : {0}", u.LastName);
                Console.WriteLine("Fullname  : {0}", u.FullName);
            }
            catch
            {
                Console.WriteLine("Invalid: Input was not recognized.");
            }
        }
    }
}