using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Creature
{
    class Troll : BaseCreature
    {
        public Troll()
        {
            HealthPointCurrent = 200;
            BaseDamage = 20;
            BaseSpeed = 5;
            Size = 10;
            Alive = true;
        }
    }
}
