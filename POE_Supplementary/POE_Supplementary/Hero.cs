using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class Hero: Character
    {
        public Hero(int hp, int xval, int yval) : base(xval, yval, 'H')
        {
            this.HP = hp;
            this.MAXHP = hp;
            this.DAMAGE = 2;
            weapon = new MeleeWeapon(MeleeWeapon.Types.Barehanded, x, y);
        }

        public override Movement Returnmove(Movement move)//=========== need to fix!!!!
        {
            switch (move)
            {
                case Movement.Nothing:
                    break;

                case Movement.left:
                    if (VISION[3].GetType() == typeof(Obstacle) || VISION[3].GetType() == typeof(Goblin) || VISION[3].GetType() == typeof(Mage) || VISION[3].GetType() == typeof(Leader))
                    {
                        move = Movement.Nothing;
                    }
                    else
                    {
                        move = Movement.left;
                    }
                    break;

                case Movement.right:
                    if (VISION[1].GetType() == typeof(Obstacle) || VISION[1].GetType() == typeof(Goblin) || VISION[1].GetType() == typeof(Mage) || VISION[1].GetType() == typeof(Leader))
                    {
                        move = Movement.Nothing;
                    }
                    else
                    {
                        move = Movement.right;
                    }
                    break;

                case Movement.up:
                    if (VISION[0].GetType() == typeof(Obstacle) || VISION[0].GetType() == typeof(Goblin) || VISION[0].GetType() == typeof(Mage) || VISION[0].GetType() == typeof(Leader))
                    {
                        move = Movement.Nothing;
                    }
                    else
                    {
                        move = Movement.up;
                    }
                    break;

                case Movement.down:
                    if (VISION[2].GetType() == typeof(Obstacle) || VISION[2].GetType() == typeof(Goblin) || VISION[2].GetType() == typeof(Mage) || VISION[2].GetType() == typeof(Leader))
                    {
                        move = Movement.Nothing;
                    }
                    else
                    {
                        move = Movement.down;
                    }
                    break;

                default:
                    move = Movement.Nothing;
                    break;
            }
            return move;
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string output;
            output = "Player Stats:" + "\n"
                + "HP: " + HP + "/" + MAXHP + " HP" + "\n"
                + "Gold: " + GoldP + "\n"
                + "[" + x + "," + y + "]" + "\n"
                + "Weapon type: " + weapon.Weapontype + "\n"
                + "Weapon Range: " + weapon.Range + "\n"
                + "Weapon Damage: " + DAMAGE;
            return output;
        }
    }
}
