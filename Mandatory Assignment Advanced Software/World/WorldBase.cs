using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Interfaces;

namespace Mandatory_Assignment_Advanced_Software.World
{
    class WorldBase : IWorldobject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Point Position { get; set; }


        public WorldBase(string name, string description, Point position)
        {
            Name = name;
            Description = description;
            Position = position;
        }

        public WorldBase()
        {
            
        }

        public int posX { get; set; }
        public int posY { get; set; }
    }
}
