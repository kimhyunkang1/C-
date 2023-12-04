using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ghost : Terran
    {
        public Ghost()
        {
            health = 45;
            maxHealth = health;
        }

        public override void Recovery()
        {
            health = maxHealth;
            Console.WriteLine("health : " + health);
        }
    }
}
