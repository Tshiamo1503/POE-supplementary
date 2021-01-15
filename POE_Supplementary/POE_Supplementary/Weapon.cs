using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    abstract class Weapon : Item
    {
        protected int damage;//=============================================Damage
        public int Damage { get { return damage; } set { damage = value; } }

        protected int range;//=============================================Range
        public virtual int Range { get { return range; } set { range = value; } }

        protected int durability;//=============================================Durability
        public int Durability { get { return durability; } set { durability = value; } }

        protected int cost;//=============================================Cost
        public int Cost { get { return cost; } set { cost = value; } }

        protected string WeaponType;//=============================================Types
        public string Weapontype { get { return WeaponType; } set { WeaponType = value; } }

        public Weapon(char Symbl, int x, int y)
            : base(x, y)
        {

        }
    }
}
