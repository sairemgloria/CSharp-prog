using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO22._2_InheritanceOverridingMethodContinuation
{
    internal class Enemy
    {
        public string name { get; set; }
        public int health { get; set; }

        public Enemy(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public void attack()
        {
            Console.Write("Attacking");
        }

        public void die()
        {
            Console.WriteLine(name + " is Dead..");
        }
    }
}
