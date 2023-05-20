using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO22._2_InheritanceOverridingMethodContinuation
{
    internal class FlyingEnemy : Enemy
    {
        public int flightSpeed { get; set; }

        public FlyingEnemy(string name, int health, int flightSpeed) : base(name, health)
        {
            this.flightSpeed = flightSpeed;
        }

        public void attack()
        {
            base.attack();
            Console.WriteLine(" on the Air...");
        }

        public void fly()
        {
            Console.WriteLine(name + " is Flying..");
        }
    }
}
