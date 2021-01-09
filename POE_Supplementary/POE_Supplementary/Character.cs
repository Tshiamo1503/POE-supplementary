using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    abstract class Character: Tile
    {
        protected int hP;
        protected int mAxHP;
        protected int damage;
        protected Tile[] vision;

        public enum Movement { Nothing = 0, left, right, up, down }

        public Tile[] VISION { get => vision; set => vision = value; }
        public int MAXHP { get => mAxHP; set => mAxHP = value; }
        public int HP { get => hP; set => hP = value; }
        public int DAMAGE { get => damage; set => damage = value; }

        public Character(int x, int y, char symbol) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Attack(Character target)
        {
            target.HP -= DAMAGE;
        }

        public bool IsDead()
        {
            bool dead = false;
            if (this.HP <= 0)
            {
                dead = true;
            }

            return dead;
        }

        public virtual bool CheckRange(Character Chartarget)
        {
            bool barehanded = true;
            bool valid = false;
            int range = DistanceTo(Chartarget);

            while (barehanded == true)
            {
                if (range == 1)
                {
                    valid = true;
                }
            }
            return valid;
        }

        private int DistanceTo(Character target)
        {
            //calculations==========
            float distanceX = (target.x - this.x);//**************************************
            float distanceY = (target.y - this.y);//**************************************

            if (distanceX < 0)
            {
                distanceX *= -1;
            }

            if (distanceY < 0)
            {
                distanceY *= -1;
            }

            int distance = Convert.ToInt32(distanceX + distanceY);

            return distance;
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Nothing:
                    break;
                case Movement.left:
                    this.x -= 1;
                    break;
                case Movement.right:
                    this.x += 1;
                    break;
                case Movement.up:
                    this.y -= 1;
                    break;
                case Movement.down:
                    this.y += 1;
                    break;
            }
        }

        public abstract Movement Returnmove(Movement move = 0);

        public abstract override string ToString();
    }
}
