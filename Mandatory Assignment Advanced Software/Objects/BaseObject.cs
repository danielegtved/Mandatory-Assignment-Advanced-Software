using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Objects
{
    public abstract class BaseObject
    {
        private string _writing;
        private bool _opened = false;
        private bool _chopped = false;
        private int _size;
        private int posX;
        private int posY;

        public string Writing
        {
            get { return _writing; }
            set { _writing = value; }
        }

        public bool Opened
        {
            get { return _opened; }
            set { _opened = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public bool Chopped
        {
            get { return _chopped; }
            set { _chopped = value; }
        }
    }
}

