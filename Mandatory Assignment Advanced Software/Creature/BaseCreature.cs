using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using Mandatory_Assignment_Advanced_Software.Items.Weapon;

namespace Mandatory_Assignment_Advanced_Software.Creature
{
    class BaseCreature
    {
        private int _healthPointCurrent;
        private int _healthPointMax;
        private int _baseDamage;
        private int _baseSpeed;
        private int _totalDamage;
        private int _size;
        private bool _alive;
        private int posX;
        private int posY;
        private BaseWeapon _equippedWeapon;


        public virtual void CalcDamage()
        {
            TotalDamage = BaseDamage * BaseSpeed;

            if (EquippedWeapon != null) TotalDamage += EquippedWeapon.Damage * EquippedWeapon.Speed;
        }

        public void RecieveDamage(int amount)
        {
            if (amount > 0)
            {
                HealthPointCurrent -= amount;
            }
        }

        public void HealToFullHealth()
        {
            HealthPointCurrent = _healthPointMax;
        }

        public void InstantDeath()
        {
            HealthPointCurrent = 0;
        }

        public int HealthPointCurrent
        {
            get { return _healthPointCurrent; }
            set { _healthPointCurrent = value; }
        }

        public int BaseDamage
        {
            get { return _baseDamage; }
            set { _baseDamage = value; }
        }

        public int BaseSpeed
        {
            get { return _baseSpeed; }
            set { _baseSpeed = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        public int TotalDamage
        {
            get { return _totalDamage; }
            set { _totalDamage = value; }
        }

        public BaseWeapon EquippedWeapon
        {
            get => _equippedWeapon;
            set
            {
                if (EquippedWeapon == null)
                {
                    EquippedWeapon = value;
                }
                else if (_equippedWeapon.Damage * _equippedWeapon.Speed < value.Speed)
                {
                    _equippedWeapon = value;
                }

                CalcDamage();
            }
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

        public int HealthPointMax
        {
            get { return _healthPointMax; }
            set { _healthPointMax = value; }
        }
    }
}
