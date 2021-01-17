using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class RangedWeapon: Weapon
    {
        public enum Types
        {
            Rifle, Longbow
        }

        public override int Range { get => base.range; set => base.range = value; }

        public RangedWeapon(Types RanGe, int x, int y)
        : base('R', x, y)
        {
            switch (RanGe)
            {
                case Types.Rifle:
                    Weapontype = "Rifle";
                    Durability = 3;
                    Range = 3;
                    Damage = 5;
                    Cost = 7;
                    break;

                case Types.Longbow:
                    Weapontype = "Longbow";
                    Durability = 4;
                    Range = 2;
                    Damage = 4;
                    Cost = 6;
                    break;
            }
        }

        public RangedWeapon(Types RanGe, int DURABILITY, int x, int y)
            : base('R', x, y)
        {
            switch (RanGe)
            {
                case Types.Rifle:
                    Weapontype = "Rifle";
                    Durability = DURABILITY;
                    Range = 3;
                    Damage = 5;
                    Cost = 7;
                    break;

                case Types.Longbow:
                    Weapontype = "Longbow";
                    Durability = DURABILITY;
                    Range = 2;
                    Damage = 4;
                    Cost = 6;
                    break;
            }

        }

        public override string ToString()
        {
            throw new Exception();
        }
    }
}
