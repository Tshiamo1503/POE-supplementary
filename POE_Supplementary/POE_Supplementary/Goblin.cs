using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class Goblin: Enemy
    {
        public Goblin(int x, int y): base(x, y, 1, 10, 'G')
        {
            this.y = y;
            this.x = x;
            this.MAXHP = 10;
            //this.Weapon = new MeleeWeapon(MeleeWeapon.Types.Dagger, x, y);
        }

        public override Movement Returnmove(Movement move = Movement.Nothing)// ========need to fix!!!
        {
            int Direction;
            Random ran = new Random();
            Direction = ran.Next(0, 5);
            switch (Direction)
            {
                case 0:
                    move = Movement.down;
                    break;
                case 1:
                    move = Movement.left;
                    break;
                case 2:
                    move = Movement.Nothing;
                    break;
                case 3:
                    move = Movement.right;
                    break;
                case 4:
                    move = Movement.up;
                    break;
                default:
                    move = Movement.Nothing;
                    break;
            }
            return move;
            throw new NotImplementedException();
        }
    }
}
