using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Supplementary
{
    class Map
    {
        private Tile[,] MAPTiles;
        private Hero Hero;
        private Enemy[] enemies;
        private Item[] Items;
        private int width, height;
        private Random randomize = new Random();

        public Obstacle obstacle = new Obstacle(0, 0);
        public EmptyTile emptyTile = new EmptyTile(0, 0);
        public Goblin GoblinOBJ = new Goblin(0, 0);
        public Mage MageOBJ = new Mage(0, 0);
        public Leader leaderOBJ = new Leader(0,0);

        public Gold GoldOBJ = new Gold(0, 0);
        public int[] goldcost;
        public int count, iteemcount;

        public Tile[,] MAPtiles { get => MAPTiles; set => MAPTiles = value; }
        public Hero HeroGS { get => Hero; set => Hero = value; }
        public Enemy[] Enemies { get => enemies; set => enemies = value; }
        public Item[] ITEMs { get => Items; set => Items = value; }
        public int WIDTH { get => width; set => width = value; }
        public int HEIGHT { get => height; set => height = value; }
        public Random RANDOM { get => randomize; set => randomize = value; }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies, int goldamount, int numWeapons)
        {
            this.WIDTH = randomize.Next(minWidth, maxWidth + 1);
            this.HEIGHT = randomize.Next(minHeight, maxHeight + 1);
            this.MAPtiles = new Tile[WIDTH, HEIGHT];
            this.enemies = new Enemy[numEnemies];
            this.Items = new Item[goldamount + numWeapons];
            goldcost = new int[goldamount];

            Createmap();

            Create(Tile.TileType.Hero);                            //hero

            for (int i = 0; i < numEnemies; i++)
            {
                count = i;
                Create(Tile.TileType.Enemy);
            }                //enemy

            for (int i = 0; i < goldamount; i++)                   
            {
                count = i;
                Create(type: Tile.TileType.Gold);
            }                //gold

            for (int i = 0; i < ITEMs.Length; i++)
            {
                count = i;
                if (ITEMs[i] == null)
                {
                    Create(Tile.TileType.Weapon);
                }
            }

            for (int A = 0; A < numEnemies; A++)
            {
                count = A;
               UpdateVision(enemies[count]);
            }

            UpdateVision(HeroGS);
        }

        public void UpdateVision(Character character)//fix this
        {
            if (MAPTiles[character.X,character.Y-1].GetType() == typeof(EmptyTile) || MAPTiles[character.X, character.Y-1].GetType() == typeof(Gold))
            {
                character.VISION[0] = new EmptyTile(character.X, character.Y-1);
            }
            else
            {
                character.VISION[0] = new Obstacle(character.X, character.Y-1);
            }

            if (MAPTiles[character.X+1, character.Y].GetType() == typeof(EmptyTile) || MAPTiles[character.X+1, character.Y].GetType() == typeof(Gold))
            {
                character.VISION[1] = new EmptyTile(character.X+1, character.Y);
            }
            else
            {
                character.VISION[1] = new Obstacle(character.X+1, character.Y);
            }

            if (MAPTiles[character.X, character.Y+1].GetType() == typeof(EmptyTile) || MAPTiles[character.X, character.Y+1].GetType() == typeof(Gold))
            {
                character.VISION[2] = new EmptyTile(character.X, character.Y+1);
            }
            else
            {
                character.VISION[2] = new Obstacle(character.X, character.Y+1);
            }

            if (MAPTiles[character.X-1, character.Y].GetType() == typeof(EmptyTile) || MAPTiles[character.X-1, character.Y].GetType() == typeof(Gold))
            {
                character.VISION[3] = new EmptyTile(character.X-1, character.Y);
            }
            else
            {
                character.VISION[3] = new Obstacle(character.X-1, character.Y);
            }
        }

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
                    HeroGS = new Hero(50, 0, 0);
                    while (MAPtiles[HeroGS.X, HeroGS.Y] != emptyTile)
                    {
                        HeroGS.X = randomize.Next(WIDTH);
                        HeroGS.Y = randomize.Next(HEIGHT);
                    }
                    HeroGS = new Hero(50, HeroGS.X, HeroGS.Y);
                    MAPtiles[HeroGS.X, HeroGS.Y] = HeroGS;
                    return HeroGS;

                case Tile.TileType.Enemy://====================================================Enemy
                    if (count == 0)
                    {
                        enemies[count] = new Leader(0, 0);
                        while (MAPtiles[enemies[count].X, enemies[count].Y] != emptyTile)
                        {
                            enemies[count].X = randomize.Next(0, WIDTH);
                            enemies[count].Y = randomize.Next(0, HEIGHT);
                        }
                        enemies[count] = new Leader(enemies[count].X, enemies[count].Y);
                        MAPtiles[enemies[count].X, enemies[count].Y] = enemies[count];
                        return enemies[count];
                    }
                    else
                    switch (RANDOM.Next(0,2))
                    {
                        case 0:
                            enemies[count] = new Goblin(0,0);
                            while (MAPtiles[enemies[count].X, enemies[count].Y] != emptyTile)
                            {
                                enemies[count].X = randomize.Next(0,WIDTH);
                                enemies[count].Y = randomize.Next(0,HEIGHT);
                            }
                            enemies[count] = new Goblin(enemies[count].X, enemies[count].Y);
                            MAPtiles[enemies[count].X, enemies[count].Y] = enemies[count];
                            return enemies[count];

                        case 1:
                            enemies[count] = new Mage(0, 0);
                            while (MAPtiles[enemies[count].X, enemies[count].Y] != emptyTile)
                            {
                                enemies[count].X = randomize.Next(0, WIDTH);
                                enemies[count].Y = randomize.Next(0, HEIGHT);
                            }
                            enemies[count] = new Mage(enemies[count].X, enemies[count].Y);
                            MAPtiles[enemies[count].X, enemies[count].Y] = enemies[count];
                            return enemies[count];

                        default:
                            enemies[count] = new Goblin(0, 0);
                            while (MAPtiles[enemies[count].X, enemies[count].Y] != emptyTile)
                            {
                                enemies[count].X = randomize.Next(0, WIDTH);
                                enemies[count].Y = randomize.Next(0, HEIGHT);
                            }
                            enemies[count] = new Goblin(enemies[count].X, enemies[count].Y);
                            MAPtiles[enemies[count].X, enemies[count].Y] = enemies[count];
                            return enemies[count];
                    }

                case Tile.TileType.Gold://====================================================Gold
                    ITEMs[count] = new Gold(0,0);
                    while (MAPtiles[ITEMs[count].X, ITEMs[count].Y] != emptyTile)
                    {
                        ITEMs[count].X = randomize.Next(0, WIDTH);
                        ITEMs[count].Y = randomize.Next(0, HEIGHT);
                    }
                    ITEMs[count] = new Gold(ITEMs[count].X,ITEMs[count].Y);
                    MAPtiles[ITEMs[count].X, ITEMs[count].Y] = ITEMs[count];
                    return ITEMs[count];

                case Tile.TileType.Weapon://====================================================Weapon
                    switch (RANDOM.Next(0,4))
                    {
                        case 0:
                            ITEMs[count] = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0);
                            while (MAPtiles[ITEMs[count].X, ITEMs[count].Y] != emptyTile)
                            {
                                ITEMs[count].X = randomize.Next(0, WIDTH);
                                ITEMs[count].Y = randomize.Next(0, HEIGHT);
                            }
                            ITEMs[count] = new MeleeWeapon(MeleeWeapon.Types.Dagger,ITEMs[count].X, ITEMs[count].Y);
                            MAPtiles[ITEMs[count].X, ITEMs[count].Y] = ITEMs[count];
                            return ITEMs[count];

                        case 1:
                            ITEMs[count] = new MeleeWeapon(MeleeWeapon.Types.longsword, 0, 0);
                            while (MAPtiles[ITEMs[count].X, ITEMs[count].Y] != emptyTile)
                            {
                                ITEMs[count].X = randomize.Next(0, WIDTH);
                                ITEMs[count].Y = randomize.Next(0, HEIGHT);
                            }
                            ITEMs[count] = new MeleeWeapon(MeleeWeapon.Types.longsword, ITEMs[count].X, ITEMs[count].Y);
                            MAPtiles[ITEMs[count].X, ITEMs[count].Y] = ITEMs[count];
                            return ITEMs[count];

                        case 2:
                            ITEMs[count] = new RangedWeapon(RangedWeapon.Types.Longbow, 0, 0);
                            while (MAPtiles[ITEMs[count].X, ITEMs[count].Y] != emptyTile)
                            {
                                ITEMs[count].X = randomize.Next(0, WIDTH);
                                ITEMs[count].Y = randomize.Next(0, HEIGHT);
                            }
                            ITEMs[count] = new RangedWeapon(RangedWeapon.Types.Longbow, ITEMs[count].X, ITEMs[count].Y);
                            MAPtiles[ITEMs[count].X, ITEMs[count].Y] = ITEMs[count];
                            return ITEMs[count];

                        case 3:
                            ITEMs[count] = new RangedWeapon(RangedWeapon.Types.Rifle, 0, 0);
                            while (MAPtiles[ITEMs[count].X, ITEMs[count].Y] != emptyTile)
                            {
                                ITEMs[count].X = randomize.Next(0, WIDTH);
                                ITEMs[count].Y = randomize.Next(0, HEIGHT);
                            }
                            ITEMs[count] = new RangedWeapon(RangedWeapon.Types.Rifle, ITEMs[count].X, ITEMs[count].Y);
                            MAPtiles[ITEMs[count].X, ITEMs[count].Y] = ITEMs[count];
                            return ITEMs[count];

                        default:
                            ITEMs[count] = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0);
                            while (MAPtiles[ITEMs[count].X, ITEMs[count].Y] != emptyTile)
                            {
                                ITEMs[count].X = randomize.Next(0, WIDTH);
                                ITEMs[count].Y = randomize.Next(0, HEIGHT);
                            }
                            ITEMs[count] = new MeleeWeapon(MeleeWeapon.Types.Dagger, ITEMs[count].X, ITEMs[count].Y);
                            MAPtiles[ITEMs[count].X, ITEMs[count].Y] = ITEMs[count];
                            return ITEMs[count];
                    }

                default://====================================================Hero
                    HeroGS = new Hero(10, 0, 0);
                    while (MAPtiles[HeroGS.X, HeroGS.Y] != emptyTile)
                    {
                        HeroGS.X = randomize.Next(WIDTH);
                        HeroGS.Y = randomize.Next(HEIGHT);
                    }
                    MAPtiles[HeroGS.X, HeroGS.Y] = HeroGS;
                    return HeroGS;
            }
        }

        public Item GetItemAtPosition(int xpos, int ypos)//================ getitem method
        {
            Item item;
            for (int i = 0; i < Items.Length; i++)
            {
                if (ITEMs[i].X == xpos && ITEMs[i].Y == ypos)
                {
                    item = Items[i];
                    ITEMs[i] = null;
                    return item;
                }
            }
            return null;
        }
    }
}
