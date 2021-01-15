﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    abstract class Enemy: Character
    {
        protected Random ran = new Random();

        public Enemy(int X, int Y, int damage, int hp, char smbl)
            : base(X, Y, smbl)
        {
            this.X = X;
            this.Y = Y;
            this.DAMAGE = damage;
            this.HP = hp;
            this.MAXHP = hp;
        }

        public override string ToString()
        {
            //EnemyClassName at[X, Y] (Amount DMG)-------------- message that must be displayed 
            string output = typeof(Enemy).Name +" at [" + this.X + "," + this.Y + "] ( Dmg: " + this.DAMAGE + " HP: "+this.HP+" )";
            return output;
        }
    }
}
