using System;
using System.Collections.Generic;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Creature;

namespace Mandatory_Assignment_Advanced_Software.Factories
{
    class EnemyFactory
    {

        Random random = new Random();
        public BaseCreature CreateCreature()
        {
            int posX = RandomPosition(10, 40);
            int posY = RandomPosition(10, 40);
            //TODO RandomPosition needs to be implemented

            int enemyType = random.Next(0, 3);

            switch (enemyType)
            {
                case 0:
                    return new Dragon();
                case 1:
                    return new Elf();
                default:
                    return new Troll();

                    //case 0:
                    //    return new Dragon(posX, posY);
                    //case 1:
                    //    return new Elf(posX, posY);
                    //default:
                    //    return new Troll(posX, posY);

            }
        }

        public int RandomPosition(int minValue, int maxValue)
        {
            int value = random.Next(minValue, maxValue);
            return value;
        }
    }
}
