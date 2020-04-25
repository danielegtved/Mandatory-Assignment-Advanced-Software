using System;
using System.Collections.Generic;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Items.Weapon;

namespace Mandatory_Assignment_Advanced_Software.Creature
{
    class Player : BaseCreature
    {
        public Player()
        {
            HealthPointCurrent = 100;
            BaseDamage = 10;
            BaseSpeed = 12;
            Size = 5;
            Alive = true;
        }
    }
}
