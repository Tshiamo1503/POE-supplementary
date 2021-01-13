using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class Map
    {
        private Enemy[] enemies;
        private Item[] Items;
        private Random randomize = new Random();
        public Obstacle obstacle = new Obstacle(0, 0);
        public EmptyTile emptyTile = new EmptyTile(0, 0);
        public int count;

        public Tile[,] MAPtiles { get; set; }
        public Hero HeroGS { get; set; }
        public int WIDTH { get; set; }
        public int HEIGHT { get; set; }
        public Random RANDOM { get => randomize; set => randomize = value; }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies, int goldamount, int numWeapons)
        {
            this.WIDTH = randomize.Next(minWidth, maxWidth + 1);
            this.HEIGHT = randomize.Next(minHeight, maxHeight + 1);
            this.MAPtiles = new Tile[WIDTH, HEIGHT];
            this.enemies = new Enemy[numEnemies];
            this.Items = new Item[goldamount + numWeapons];

            Createmap();

            Create(Tile.TileType.Hero);                                           //hero

            for (int i = 0; i < numEnemies; i++)
            {
                count = i;
                Create(Tile.TileType.Enemy);                                      //enemy
            }

            UpdateVision();
        }

        public void UpdateVision()
        {

        }//fix this

        public void Createmap()
        {
            for (int j = 0; j < WIDTH; j++)
            {
                for (int i = 0; i < HEIGHT; i++)
                {
                    if (j == 0 || i == 0 || j == WIDTH - 1 || i == HEIGHT - 1)
                    {
                        MAPtiles[j, i] = obstacle;
                    }
                    else
                    {
                        MAPtiles[j, i] = emptyTile;
                    }
                }
            }
        }

        private Tile Create(Tile.TileType type)
        {
            switch (type)
            {
                case Tile.TileType.Hero://====================================================Hero
                    HeroGS = new Hero(10, 0, 0);
                    while (MAPtiles[HeroGS.X, HeroGS.Y] != emptyTile)
                    {
                        HeroGS.X = randomize.Next(WIDTH);
                        HeroGS.Y = randomize.Next(HEIGHT);
                    }
                    HeroGS = new Hero(10, HeroGS.X, HeroGS.Y);
                    MAPtiles[HeroGS.X, HeroGS.Y] = HeroGS;
                    return HeroGS;

                case Tile.TileType.Enemy://====================================================Enemy
                    Random enemytype = new Random();
                    enemies[count] = new Goblin(0, 0);
                    while (MAPtiles[enemies[count].X, enemies[count].Y] != emptyTile)
                    {
                        enemies[count].X = randomize.Next(0, WIDTH);
                        enemies[count].Y = randomize.Next(0, HEIGHT);
                    }
                    enemies[count] = new Goblin(enemies[count].X, enemies[count].Y);
                    MAPtiles[enemies[count].X, enemies[count].Y] = enemies[count];
                    return enemies[count];

                case Tile.TileType.Gold://====================================================Gold
                    return HeroGS;

                case Tile.TileType.Weapon://====================================================Weapon
                    return HeroGS;

                default://====================================================Hero
                    HeroGS = new Hero(10, 0, 0);
                    while (MAPtiles[HeroGS.X, HeroGS.Y] != emptyTile)
                    {
                        HeroGS.X = randomize.Next(WIDTH);
                        HeroGS.Y = randomize.Next(HEIGHT);
                    }
                    HeroGS = new Hero(10, HeroGS.X, HeroGS.Y);
                    MAPtiles[HeroGS.X, HeroGS.Y] = HeroGS;
                    return HeroGS;
            }
        }

    }
}
