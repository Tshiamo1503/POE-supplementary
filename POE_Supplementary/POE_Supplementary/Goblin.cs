﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    [Serializable()]
    class Goblin: Enemy
    {
        public Goblin(int x, int y): base(x, y, 1, 10, 'G')
        {
            this.y = y;
            this.x = x;
            DAMAGE =1;
            HP = 10;
            MAXHP = 10;
            weapon = new MeleeWeapon(MeleeWeapon.Types.Dagger, x, y);
            damage = weapon.Damage;
            GoldP = 1;
        }

        public override Movement Returnmove(Movement move = Movement.Nothing)
        {
            int Direction;
            Random ran = new Random();
            Direction = ran.Next(0, 5);
            switch (Direction)
            {
                case 0://downn
                    if (VISION[2].GetType() == typeof(Obstacle) || VISION[2].GetType() == typeof(Goblin) || VISION[2].GetType() == typeof(Mage) || VISION[2].GetType() == typeof(Leader) || VISION[2].GetType() == typeof(Hero))
                    {
                        move = Movement.Nothing;
                    }
                    else
                        move = Movement.down;
                    break;

                case 1://up
                    if (VISION[0].GetType() == typeof(Obstacle) || VISION[0].GetType() == typeof(Goblin) || VISION[0].GetType() == typeof(Mage) || VISION[0].GetType() == typeof(Leader) || VISION[0].GetType() == typeof(Hero))
                    {
                        move = Movement.Nothing;
                    }
                    else
                        move = Movement.up;
                    break;

                case 2://left
                    if (VISION[3].GetType() == typeof(Obstacle) || VISION[3].GetType() == typeof(Goblin) || VISION[3].GetType() == typeof(Mage) || VISION[3].GetType() == typeof(Leader) || VISION[3].GetType() == typeof(Hero))
                    {
                        move = Movement.Nothing;
                    }
                    else
                        move = Movement.left;
                    break;

                case 3://right
                    if (VISION[1].GetType() == typeof(Obstacle) || VISION[1].GetType() == typeof(Goblin) || VISION[1].GetType() == typeof(Mage) || VISION[1].GetType() == typeof(Leader) || VISION[1].GetType() == typeof(Hero))
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
