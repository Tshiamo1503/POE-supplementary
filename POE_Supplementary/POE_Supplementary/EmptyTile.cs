using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    [Serializable()]
    class EmptyTile: Tile
    {
        public EmptyTile(int xpos, int ypos)
        : base(xpos, ypos)
        {

        }
    }
}
