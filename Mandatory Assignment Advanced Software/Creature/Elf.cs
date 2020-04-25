using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Creature
{
    class Elf : BaseCreature
    {
        public Elf()
        {
            HealthPointCurrent = 80;
            BaseDamage = 5;
            BaseSpeed = 20;
            Size = 5;
            Alive = true;
        }
    }
}
