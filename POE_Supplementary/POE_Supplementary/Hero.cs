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
        }

        public override Movement Returnmove(Movement move)//=========== need to fix!!!!
        {
            switch (move)
            {
                case Movement.Nothing:
                    break;
                case Movement.left:
                    break;
                case Movement.right:
                    break;
                case Movement.up:
                    break;
                case Movement.down:
                    break;
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string output = "Player Stats" + "\n" + "HP: " + this.HP + "/" + this.MAXHP + " HP" /*+ "\n" + "Gold: " + this.gold + "\n" + "[" + this.y + "," + this.x + "]"*/;
            return output;
        }
    }
}
