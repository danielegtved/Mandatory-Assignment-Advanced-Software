using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Items.Weapon
{
    public abstract class BaseWeapon
    {
        private string _name;
        private int _handling;
        private int _damage;
        private int _speed;
        private int _weight;

        public BaseWeapon()
        {
            Name = this.GetType().Name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Handling
        {
            get { return _handling; }
            set { _handling = value; }
        }

        public virtual int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }


        public override string ToString()
        {
            return $"Name: {Name}, Handling: {Handling} BaseDamage: {Damage}, BaseSpeed: {Speed}, Weight: {Weight}";
        }
    }
}
