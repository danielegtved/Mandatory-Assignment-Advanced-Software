using System;
using System.Collections.Generic;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Items.Armor;

namespace Mandatory_Assignment_Advanced_Software.Decorator
{
    class DefenceDecorator : BaseArmor
    {
        public BaseArmor BaseArmor;
        public double faktor;

        public DefenceDecorator(BaseArmor baseArmor, double faktor)
        {
            this.BaseArmor = baseArmor;
            this.faktor = faktor;
        }

        public override int Defence
        {
            get { return (int)(BaseArmor.Defence * faktor); }
            set { BaseArmor.Defence = value; }
        }
    }
}