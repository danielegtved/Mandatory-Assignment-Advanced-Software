using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.World
{
    class EmptySpot : WorldBase
    {
        public EmptySpot(string name, string description, Point position) : base(name, description, position)
        {
            Position = position;
            
        }
    }
}
