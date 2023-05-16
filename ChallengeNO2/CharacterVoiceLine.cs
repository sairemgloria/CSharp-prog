using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeNO2
{
    internal class CharacterVoiceLine
    {
        public string characterName;
        public string characterVoiceLine;
        public CharacterVoiceLine(string characterName, string characterVoiceLine)
        {
            this.characterName = characterName;
            this.characterVoiceLine = characterVoiceLine;
            Console.WriteLine(characterName + " : " + characterVoiceLine);
        }
    }
}
