using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO2
{
    internal class CharacterClassType
    {
        public string characterDefinition;
        public int characterPower;
        public CharacterClassType(string characterDefinition, int characterPower)
        {
            this.characterDefinition = characterDefinition;
            this.characterPower = characterPower;
            Console.WriteLine("Type : {0}", characterDefinition);
            Console.WriteLine("Power : {0}", characterPower);
        }
    }
}
