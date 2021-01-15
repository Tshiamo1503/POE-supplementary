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
            DAMAGE = 5;
        }

        public override void Attack(Character target)
        {
            base.Attack(target);

        }

        public override Movement Returnmove(Movement move = Movement.Nothing)
        {
            return move;
            throw new NotImplementedException();
        }

        public override bool CheckRange(Character Chartarget)
        {
            bool valid = false;
            if ((Chartarget.X == this.x + 1 && Chartarget.Y == this.y) || (Chartarget.X == this.x - 1 && Chartarget.Y == this.y) || (Chartarget.Y == this.y + 1 && Chartarget.X == this.x) || (Chartarget.Y == this.y + 1 && Chartarget.X == this.x) ||
                (Chartarget.X == this.x + 1 && Chartarget.Y == this.y + 1) || (Chartarget.X == this.x + 1 && Chartarget.X == this.y - 1) || (Chartarget.X == this.x - 1 && Chartarget.X == this.y - 1) || (Chartarget.X == this.x - 1 && Chartarget.X == this.y + 1))
            {
                valid = true;
            }
            return valid;
        }
    }
}
