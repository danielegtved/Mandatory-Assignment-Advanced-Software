﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Creature;

namespace Mandatory_Assignment_Advanced_Software.World
{
    class Town : WorldBase
    {
        public Town(string name, string description, Point position) : base(name, description, position)
        {

        }

        public virtual void Heal(BaseCreature creature)
        {
            creature.HealToFullHealth();
        }
    }
}
