using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    [Serializable()]
    class MeleeWeapon : Weapon
    {
        public enum Types
        {
            Dagger, longsword,Barehanded
        }

        public override int Range { get => base.Range; set => base.Range = 1; }

        public MeleeWeapon(Types melee, int x, int y)
            : base('M', x, y)
        {
            range = 1;
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

                case Types.Barehanded:
                    Weapontype = "BareHanded";
                    Durability = 0;
                    damage = 0;
                    cost = 0;
                    break;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
