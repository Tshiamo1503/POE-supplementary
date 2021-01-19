using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    [Serializable()]
    abstract class Character: Tile
    {
        protected int hP;
        protected int mAxHP;
        protected int damage;
        protected Tile[] vision;
        protected int Goldpurse;
        protected Weapon weapon;

        public enum Movement { Nothing = 0, left, right, up, down }

        public Tile[] VISION { get => vision; set => vision = value; }
        public int MAXHP { get => mAxHP; set => mAxHP = value; }
        public int HP { get => hP; set => hP = value; }
        public int DAMAGE { get => damage; set => damage = value; }
        public int GoldP { get => Goldpurse; set => Goldpurse = value; }
        public Weapon Weapon => weapon;

        public Character(int x, int y, char symbol) : base(x, y)
        {
            this.x = x;
            this.y = y;
            VISION = new Tile[4];
        }

        public virtual void Attack(Character target)
        {
            target.HP -= DAMAGE;
        }

        public bool IsDead()
        {
            bool dead;
            if (HP <= 0)
            {
                dead = true;
            }
            else
            {
                dead = false;
            }

            return dead;
        }

        public virtual bool CheckRange(Character Chartarget)
        {
            bool valid = false;
            int range = DistanceTo(Chartarget);
            int wrange = weapon.Range;
            if (range <= wrange)
            {
                valid = true;
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

        public void Pickup(Item i)
        {
            if (i.GetType() == typeof(Gold))
            {
                GoldP += ((Gold)i).AmountG;// for some reason all gold items are the same amount for this
                //GoldP += new Gold(0,0).Amount;
            }
            else 
            {
                Equip((Weapon)i);
            }
        }

        private void Equip(Weapon w)
        {
            weapon = w;
            weapon.Damage = damage = w.Damage;
            Weapon.Weapontype = w.Weapontype;
            weapon.Range = w.Range;
            weapon.Durability = w.Durability;
            weapon.Cost = w.Cost;
        }

        public void Loot(Character target)
        {
            this.Goldpurse += target.GoldP;
            target.GoldP = 0;

            if (weapon == null)
            {
                this.weapon = target.weapon;
            }
        }
    }
}
