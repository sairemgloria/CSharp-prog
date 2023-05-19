using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO4
{
    class Agent : AgentAbility
    {
        /* Agent Name Attribute(s) */
        /* NOTE : These attributes are encapsulated. */
        private int agentID;
        private string agentName;
        private string agentDesc;

        /* Agent Name Getter & Setter */
        public int AgentID
        {
            get { return agentID; }
            set { agentID = value; }
        }
        public string AgentName
        {
            get { return agentName; }
            set { agentName = value; }
        }
        public string AgentDesc
        {
            get { return agentDesc; }
            set { agentDesc = value; }
        }

        /* Agent Constructor */
        public Agent(string agent_FirstSkill, string agent_SecondSkill, string agent_ThirdSkill, string agent_UltimateSkill, int AgentID, string AgentName, string AgentDesc) : base(agent_FirstSkill, agent_SecondSkill, agent_ThirdSkill, agent_UltimateSkill)
        {
            this.agentID = AgentID;
            this.agentName = AgentName;
            this.agentDesc = AgentDesc;
        }

        /* Agent Object Method */
        public void AgentInformation()
        {
            Console.WriteLine("+-+-+-+-+  Valorant Agent Information +-+-+-+-+");
            Console.WriteLine("Agent ID          : " + AgentID);
            Console.WriteLine("Agent Name        : " + AgentName);
            Console.WriteLine("Agent Description : " + AgentDesc);
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        }

    }
}
