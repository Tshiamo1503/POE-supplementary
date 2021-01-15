using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class MeleeWeapon : Weapon
    {
        public enum Types
        {
            Dagger, longsword
        }

        public override int Range { get => base.range; set => base.range = 1; }

        public MeleeWeapon(Types melee, int x, int y)
            : base('M', x, y)
        {
            switch (melee)
            {
                case Types.Dagger:
                    Weapontype = "Dagger";
                    Durability = 10;
                    Damage = 3;
                    Cost = 3;
                    break;

                case Types.longsword:
                    Weapontype = "longsword";
                    Durability = 6;
                    Damage = 4;
                    Cost = 5;
                    break;
            }
        }
    }
}
