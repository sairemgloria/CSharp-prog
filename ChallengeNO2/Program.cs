namespace ChallengeNO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge NO2 */
            Console.WriteLine("Challenge NO2"); 

            Console.Write("Enter character name : ");
            string charName = Console.ReadLine();
            Console.Write("Enter character type : ");
            string charType = Console.ReadLine();
            Console.Write("Enter character power : ");
            int charPow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter character voice line : ");
            string charVoiceLine = Console.ReadLine();
            

            CharacterVoiceLine characterVoiceLine = new CharacterVoiceLine(charName, charVoiceLine);
            CharacterClassType characterClassType = new CharacterClassType(charType, charPow);
        }
    }
}