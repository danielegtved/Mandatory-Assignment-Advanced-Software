using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Interfaces;
using static System.Drawing.Color;

namespace Mandatory_Assignment_Advanced_Software.World
{
    class World : WorldBase
    {
        private int _xSideWorld;
        private int _ySideWorld;
        public Color[,] Colors { get; set; }
        private IWorldobject[,] _map;


        public World()
        {
            XSideWorld = 50;
            YSideWorld = 50;
            _map = new IWorldobject[XSideWorld, YSideWorld];
        }

        public bool MakeGameWorld()
        {
            for (int i = 0; i < XSideWorld; i++)
            {
                for (int j = 0; j < YSideWorld; j++)
                {
                   // _map[i, j] = new WorldBase("Empty", "No description", new Point(posX , posY));
                    _map[i, j] = new EmptySpot("Empty", "No description", new Point(posX, posY));
                }
            }

            return true;
        }

        public int XSideWorld
        {
            get { return _xSideWorld; }
            set { _xSideWorld = value; }
        }

        public int YSideWorld
        {
            get { return _ySideWorld; }
            set { _ySideWorld = value; }
        }
    }
}
