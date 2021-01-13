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
                    move = false;
                    break;
                case Character.Movement.left:
                    if (Map.MAPtiles[Map.HeroGS.X - 1, Map.HeroGS.Y] == MAP.emptyTile)
                    {
                        move = true;
                    }
                    break;
                case Character.Movement.right:
                    if (Map.MAPtiles[Map.HeroGS.X + 1, Map.HeroGS.Y] == MAP.emptyTile)
                    {
                        move = true;
                    }
                    break;
                case Character.Movement.up:
                    if (Map.MAPtiles[Map.HeroGS.X, Map.HeroGS.Y - 1] == MAP.emptyTile)
                    {
                        move = true;
                    }
                    break;
                case Character.Movement.down:
                    if (Map.MAPtiles[Map.HeroGS.X, Map.HeroGS.Y + 1] == MAP.emptyTile)
                    {
                        move = true;
                    }
                    break;
            }
            return move;
        }

        private static readonly char HeroC = 'H', GoblinC = 'G', ObsticleC = 'X', EmptyC = '.';

        public override string ToString()
        {
            string output = "";
            for (int j = 0; j < Map.WIDTH; j++)
            {
                for (int i = 0; i < Map.HEIGHT; i++)
                {
                    output += Map.MAPtiles[j, i];
                }
                output += "\n";
            }
            return output;
        }
    }
}
