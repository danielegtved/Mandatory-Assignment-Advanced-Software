using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Objects
{
    class Tree : BaseObject
    {
        public bool ChopTree()
        {
            if (Chopped = true) 
            {
                Console.WriteLine("You got some wood");
                return true;
            }

            return false;
        }
    }
}
