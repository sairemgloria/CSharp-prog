namespace ChallengeNO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge NO : 4 */
            Agent agent = new Agent("Smoke", "Updraft", "Dash", "Wind of Blades", 1, "Jett", "Duelist");
            agent.AgentInformation();
            agent.AgentSkills();
        }
    }
}