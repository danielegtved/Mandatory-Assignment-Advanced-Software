using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Objects
{
    class TreasureChest : BaseObject
    {
        public bool OpenChest()
        {
            if (Opened = true)
            {
                Console.WriteLine("Congratulations you got gold");
                return true;
            }

            return false;
        }
    }
}
