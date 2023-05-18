namespace NO19._1_EncapsulationWithGetSetShortcut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 19.1 : Encapsulation */
            Console.WriteLine("Topic NO 19.1 : Encapsulation");

            User user = new User(1000,"HaxHex","Hax","Hex");

            Console.WriteLine("UID       : {0}", user.userID);
            Console.WriteLine("Username  : {0}", user.userName);
            Console.WriteLine("Firstname : {0}", user.firstName);
            Console.WriteLine("lastname  : {0}", user.lastName);
        }
    }
}