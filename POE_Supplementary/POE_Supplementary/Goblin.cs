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

        public override Movement Returnmove(Movement move = Movement.Nothing)
        {
            int Direction;
            Random ran = new Random();
            Direction = ran.Next(0, 5);
            switch (Direction)
            {
                case 0://downn
                    if (VISION[2].GetType() == typeof(Obstacle) || VISION[2].GetType() == typeof(Enemy))
                    {
                        move = Movement.Nothing;
                    }
                    else
                        move = Movement.down;
                    break;

                case 1://up
                    if (VISION[0].GetType() == typeof(Obstacle) || VISION[0].GetType() == typeof(Enemy))
                    {
                        move = Movement.Nothing;
                    }
                    else
                        move = Movement.up;
                    break;

                case 2://left
                    if (VISION[3].GetType() == typeof(Obstacle))
                    {
                        move = Movement.Nothing;
                    }
                    else
                        move = Movement.left;
                    break;

                case 3://right
                    if (VISION[1].GetType() == typeof(Obstacle) || VISION[1].GetType() == typeof(Enemy))
                    {
                        move = Movement.Nothing;
                    }
                    else
                        move = Movement.right;
                    break;

                case 4://nothing
                    move = Movement.Nothing;
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
