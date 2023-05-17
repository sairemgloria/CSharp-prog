namespace NO18_ObjectMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Topic NO 18 : Object Methods */
            Console.WriteLine("Topic NO 18 : Object Methods");

            Character character = new Character("Cypher","Greetings!",100,50,1);
            character.introduce();
            character.sayDialog();
            character.characterInfo();
        }
    }
}