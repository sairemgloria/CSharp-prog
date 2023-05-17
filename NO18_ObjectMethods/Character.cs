using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO18_ObjectMethods
{
    // this is the class
    internal class Character
    {
        // this is are the attributes
        public string name, dialog;
        public int hp, mp, lvl;

        // this is the constructor of the class
        public Character(string name, string dialog, int hp, int mp, int lvl)
        {
            this.name = name;
            this.dialog = dialog;
            this.hp = hp;
            this.mp = mp;
            this.lvl = lvl;
        }

        // this is are the object methods
        public void introduce()
        {
            Console.WriteLine("I am " + name);
        }
        public void sayDialog()
        {
            Console.WriteLine(name + "'s Voice Line : " + dialog);
        }
        public void characterInfo()
        {
            Console.WriteLine(name + "'s Information :");
            Console.WriteLine("Level : " + lvl);
            Console.WriteLine("HP    : " + hp);
            Console.WriteLine("MP    : " + mp);
        }
    }
}