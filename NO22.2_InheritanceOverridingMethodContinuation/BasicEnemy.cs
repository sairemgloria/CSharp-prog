using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO22._2_InheritanceOverridingMethodContinuation
{
    internal class BasicEnemy : Enemy
    {
        public int walkSpeed { get; set; }

        public BasicEnemy(string name, int health, int walkSpeed) : base(name, health)
        {
            this.walkSpeed = walkSpeed;
        }

        public void attack()
        {
            base.attack();
            Console.WriteLine(" on the Ground...");
        }

        public void walk()
        {
            Console.WriteLine(name + " is Walking..");
        }
    }
}
