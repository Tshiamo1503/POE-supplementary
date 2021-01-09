using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class Map
    {
        private Tile[,] Maptiles;
        private Hero hero;
        private Enemy[] enemies;
        //private Item[] Items;
        private int width, height;
        private Random randomize = new Random();

        public Tile[,] MAPtiles { get => Maptiles; set => Maptiles = value; }
        public Hero HeroGS { get => hero; set => hero = value; }
        public int WIDTH { get => width; set => width = value; }
        public int HEIGHT { get => height; set => height = value; }
        public Random RANDOM{ get => randomize; set => randomize = value; }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies, int goldamount, int numWeapons)
        {
            this.width = randomize.Next(minWidth, maxWidth + 1);
            this.height = randomize.Next(minHeight, maxHeight + 1);
            this.Maptiles = new Tile[width, height];
            this.enemies = new Enemy[numEnemies];
            //this.Items = new Item[goldamount + numWeapons];

            Create(Tile.TileType.Hero);//hero

            for (int i = 0; i < numEnemies; i++)
            {
                Create(Tile.TileType.Enemy);//enemy
                //enemies = new Enemy();
            }

            UpdateVision();
        }

        public void UpdateVision()
        {

        }

        public void createmap()
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j == 0 || i == 0 || j == height - 1 || i == width - 1)
                    {
                        Maptiles[j, i] = new Obstacle(j,i);
                    }
                    else
                    {
                        Maptiles[j, i] = new EmptyTile(j,i);
                    }
                }
            }
        }

        private Tile Create(Tile.TileType type)
        {
            switch (type)
            {
                case Tile.TileType.Hero:
                    hero.X = randomize.Next(WIDTH);
                    hero.Y = randomize.Next(HEIGHT);
                    hero = new Hero(10, hero.X, hero.Y);
                    MAPtiles[hero.X, hero.Y] = hero;
                    return hero;

                case Tile.TileType.Enemy:
                    Random enemytype = new Random();
                    Enemy enemy = new Goblin(0, 0);
                    Random ran = new Random();
                    enemy.X = ran.Next(0, width);
                    enemy.Y = ran.Next(0, height);
                    enemy = new Goblin(enemy.X, enemy.Y);
                    Maptiles[enemy.Y, enemy.X] = enemy;
                    return enemy;

                case Tile.TileType.Gold:
                    return hero;

                case Tile.TileType.Weapon:
                    return hero;

                default:
                    hero.X = randomize.Next(WIDTH);
                    hero.Y = randomize.Next(HEIGHT);
                    hero = new Hero(10, hero.X, hero.Y);
                    MAPtiles[hero.X, hero.Y] = hero;
                    return hero;
            }
        }

    }
}
