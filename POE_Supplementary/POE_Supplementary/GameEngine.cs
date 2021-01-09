using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class GameEngine
    {
        private Map Map;
        public Map MAP { get => Map; set => Map = value; }

        public GameEngine()
        {
            Map = new Map(8, 10, 8, 10, 10, 10, 5);
        }

        public bool MovePlayer(Character.Movement direction)
        {
            bool move = false;

            switch (direction)
            {
                case Character.Movement.Nothing:

                    break;
                case Character.Movement.left:
                    if (Map.MAPtiles[Map.HeroGS.X-1, Map.HeroGS.Y] == )
                    {
                        move = true;
                    }
                    break;
                case Character.Movement.right:
                    if (Map.Maptiles[Map.hero.Y, Map.hero.X + 1] == '.')
                    {
                        move = true;
                    }
                    break;
                case Character.Movement.up:
                    if (Map.Maptiles[Map.hero.Y - 1, Map.hero.X] == '.')
                    {
                        move = true;
                    }
                    break;
                case Character.Movement.down:
                    if (Map.Maptiles[Map.hero.Y + 1, Map.hero.X] == '.')
                    {
                        move = true;
                    }
                    break;
            }
            return move;
        }
    }
}
