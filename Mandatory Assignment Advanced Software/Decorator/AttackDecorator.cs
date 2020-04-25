using System;
using System.Collections.Generic;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Items.Weapon;

namespace Mandatory_Assignment_Advanced_Software.Decorator
{
    public abstract class AttackDecorator : BaseWeapon
    {
        public BaseWeapon BaseWeapon;
        public double faktor;

        public AttackDecorator(BaseWeapon baseWeapon, double faktor)
        {
            this.BaseWeapon = baseWeapon;
            this.faktor = faktor;
        }

        public override int Damage
        {
            get { return (int)(BaseWeapon.Damage * faktor); }
            set { BaseWeapon.Damage = value; }
        }
    }
}