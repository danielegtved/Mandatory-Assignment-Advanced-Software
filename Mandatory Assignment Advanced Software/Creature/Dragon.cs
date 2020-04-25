using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Creature
{
    class Dragon : BaseCreature
    {
        public Dragon()
        {
            HealthPointCurrent = 1000;
            BaseDamage = 55;
            BaseSpeed = 3;
            Size = 20;
            Alive = true;
        }
    }
}
