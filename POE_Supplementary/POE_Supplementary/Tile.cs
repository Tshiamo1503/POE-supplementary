using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    abstract class Tile
    {
        protected int x, y;

        public enum TileType
        {
            Hero, Enemy, Gold, Weapon
        }

        public Tile(int xval, int yval)
        {
            x = xval;
            y = yval;
        }

        public int X { get { return x; } set { x = value; } }

        public int Y { get { return y; } set { y = value; } }
    }
}
