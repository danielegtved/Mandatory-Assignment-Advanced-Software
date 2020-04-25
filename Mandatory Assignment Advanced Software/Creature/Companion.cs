using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Creature
{
    class Companion : BaseCreature
    {
        public Companion()
        {
            HealthPointCurrent = 100;
            BaseDamage = 10;
            BaseSpeed = 12;
            Size = 5;
            Alive = true;
        }
    }
}
