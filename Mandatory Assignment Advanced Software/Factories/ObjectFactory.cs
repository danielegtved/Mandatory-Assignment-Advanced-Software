using System;
using System.Collections.Generic;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Objects;

namespace Mandatory_Assignment_Advanced_Software.Factories
{
    class ObjectFactory
    {
        Random random = new Random();
        public BaseObject CreateObject()
        {
            int posX = RandomPosition(10, 40);
            int posY = RandomPosition(10, 40);
            //TODO RandomPosition needs to be implemented

            int objectType = random.Next(0, 3);

            switch (objectType)
            {
                case 0:
                    return new Tree();
                case 1:
                    return new TreasureChest();
                default:
                    return new Rock();

                    //case 0:
                    //    return new Rock(posX, posY);
                    //case 1:
                    //    return new Signpost(posX, posY);
                    //case 2:
                    //    return new TreasureChest(posX, posY);
                    //default:
                    //    return new Tree(posX, posY);

            }
        }

        public int RandomPosition(int minValue, int maxValue)
        {
            int value = random.Next(minValue, maxValue);
            return value;
        }
    }
}
