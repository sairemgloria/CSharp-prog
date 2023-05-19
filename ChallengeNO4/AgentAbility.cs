using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO4
{
    class AgentAbility
    {
        /* Agent Ability Attribute(s) */
        /* NOTE : These attributes are encapsulated. */
        public string agent_FirstSkill { get; set; }
        public string agent_SecondSkill { get; set; }
        public string agent_ThirdSkill { get; set; }
        public string agent_UltimateSkill { get; set; }

        /* Agent Constructor */
        public AgentAbility(string agent_FirstSkill, string agent_SecondSkill, string agent_ThirdSkill, string agent_UltimateSkill)
        {
            this.agent_FirstSkill = agent_FirstSkill;
            this.agent_SecondSkill = agent_SecondSkill;
            this.agent_ThirdSkill = agent_ThirdSkill;
            this.agent_UltimateSkill = agent_UltimateSkill;
        }
 
        /* Agent Object Method */
        public void AgentSkills()
        {
            Console.WriteLine("+-+-+-+-+-+ Agent Ability Description +-+-+-+-+");
            Console.WriteLine("First Skill    : " + agent_FirstSkill);
            Console.WriteLine("Second Skill   : " + agent_SecondSkill);
            Console.WriteLine("Third Skill    : " + agent_ThirdSkill);
            Console.WriteLine("Ultimate Skill : " + agent_UltimateSkill);
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        }
    }
}
