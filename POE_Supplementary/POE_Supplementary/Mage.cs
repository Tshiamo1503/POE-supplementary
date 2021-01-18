using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class Mage: Enemy
    {
        public Mage(int Xpos, int Ypos) : base(Xpos, Ypos, 5, 5, 'M')
        {
            VISION = new Tile[9];
            weapon = new MeleeWeapon(MeleeWeapon.Types.Barehanded, x, y);
            DAMAGE = 5;
            GoldP = 3;
        }

        public override void Attack(Character target)
        {
            base.Attack(target);
            for (int i = 0; i < VISION.Length-1; i++)
            {
                if (VISION[i].GetType() == typeof(Enemy))
                {
                    Character enemy = (Character)VISION[i];
                    enemy.HP -= damage;
                }
            }
        }

        public override Movement Returnmove(Movement move = Movement.Nothing)
        {
            return move;
            throw new NotImplementedException();
        }

        public override bool CheckRange(Character Chartarget)
        {
            bool valid = false;
            if ((Chartarget.X == this.x + 1 && Chartarget.Y == this.y)/*RIGHT*/|| (Chartarget.X == this.x - 1 && Chartarget.Y == this.y)/*LEFT*/|| (Chartarget.Y == this.y + 1 && Chartarget.X == this.x)/*DOWN*/|| (Chartarget.Y == this.y - 1 && Chartarget.X == this.x)/*UP*/||
                (Chartarget.X == this.x + 1 && Chartarget.Y == this.y + 1)/*BOTTOM RIGHT*/|| (Chartarget.X == this.x + 1 && Chartarget.X == this.y - 1)/*TOP RIGHT*/|| (Chartarget.X == this.x - 1 && Chartarget.X == this.y - 1)/*TOP LEFT*/|| (Chartarget.X == this.x - 1 && Chartarget.X == this.y + 1)/*BOTTOM LEFT*/)
            {
                valid = true;
            }
            return valid;
        }

        
    }
}
