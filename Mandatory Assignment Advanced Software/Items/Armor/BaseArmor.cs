using System;
using System.Collections.Generic;
using System.Text;

namespace Mandatory_Assignment_Advanced_Software.Items.Armor
{
    public abstract class BaseArmor
    {
        private string _name;
        private int _defence;
        private int _weight;
        private int _value;

        public BaseArmor()
        {
            Name = this.GetType().Name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Defence: {Defence} Weight: {Weight}, Value: {Value}";
        }

    }
    
}
