using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace POE_Supplementary
{
    [Serializable()]
    class GameEngine: ISerializable
    {
        private Map Map;
        public Map MAP { get => Map; set => Map = value; }

        public GameEngine()
        {
            Map = new Map(12, 14, 12, 14, 10, 15, 5);
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
                    move = true;
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.emptyTile;
                    MAP.HeroGS.Move(MAP.HeroGS.Returnmove(Character.Movement.left));
                    if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(Gold) || MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(MeleeWeapon) || MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(RangedWeapon))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] == MAP.ITEMs[l])
                            {
                                MAP.HeroGS.Pickup(MAP.ITEMs[l]);
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.HeroGS;
                    break;

                case Character.Movement.right:
                    move = true;
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.emptyTile;
                    MAP.HeroGS.Move(MAP.HeroGS.Returnmove(Character.Movement.right));
                    if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(Gold) || MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(MeleeWeapon) || MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(RangedWeapon))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] == MAP.ITEMs[l])
                            {
                                MAP.HeroGS.Pickup(MAP.ITEMs[l]);
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.HeroGS;
                    break;

                case Character.Movement.up:
                    move = true;
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.emptyTile;
                    MAP.HeroGS.Move(MAP.HeroGS.Returnmove(Character.Movement.up));
                    if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(Gold) || MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(MeleeWeapon) || MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(RangedWeapon))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] == MAP.ITEMs[l])
                            {
                                MAP.HeroGS.Pickup(MAP.ITEMs[l]);
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.HeroGS;
                    break;

                case Character.Movement.down:
                    move = true;
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.emptyTile;
                    MAP.HeroGS.Move(MAP.HeroGS.Returnmove(Character.Movement.down));
                    if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(Gold) || MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(MeleeWeapon) || MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(RangedWeapon))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] == MAP.ITEMs[l])
                            {
                                MAP.HeroGS.Pickup(MAP.ITEMs[l]);
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.HeroGS;
                    break;

            }
            return move;
        }

        private static readonly char HeroC = 'H', GoblinC = 'G', ObsticleC = 'X', EmptyC = '.', MageC = 'M', LeaderC = 'L', GoldC = '$', RangeW = 'r', meleeW = 'm';

        public override string ToString()
        {
            string output = "";
            for (int j = 0; j < Map.HEIGHT; j++)
            {
                for (int i = 0; i < Map.WIDTH; i++)
                {
                    if (MAP.MAPtiles[i,j].GetType() == typeof(EmptyTile))                       //empty
                    {
                        output += EmptyC;
                    }
                    if (MAP.MAPtiles[i, j].GetType() == typeof(Obstacle))                      //obstacle
                    {
                        output += ObsticleC;
                    }
                    if (MAP.MAPtiles[i, j].GetType() == typeof(Hero))                        //hero
                    {
                        output += HeroC;
                    }

                    for (int k = 0; k < MAP.Enemies.Length; k++)
                    {
                        if (MAP.MAPtiles[i, j] == MAP.Enemies[k])
                        {
                            if (MAP.Enemies[k].GetType() == typeof(Goblin))
                            {
                                output += GoblinC;
                                break;
                            }
                            if (MAP.Enemies[k].GetType() == typeof(Mage))
                            {
                                output += MageC;
                                break;
                            }
                            if (MAP.Enemies[k].GetType()== typeof(Leader))
                            {
                                output += LeaderC;
                                break;
                            }
                        }
                    }                                  //Enenmies

                    for (int k = 0; k < MAP.ITEMs.Length; k++)
                    {
                        if (MAP.MAPtiles[i, j] == MAP.ITEMs[k])
                        {
                            if (MAP.ITEMs[k].GetType() == typeof(Gold))
                            {
                                output += GoldC;
                                //break;
                            }
                            if (MAP.ITEMs[k].GetType() == typeof(MeleeWeapon))
                            {
                                output += meleeW;
                                //break;
                            }
                            if (MAP.ITEMs[k].GetType() == typeof(RangedWeapon))
                            {
                                output += RangeW;
                                //break;
                            }
                        }
                    }       

                }
                output += "\n";
            }

            return output;
        }

        public void EnemyAttacks(int F)
        {
            if (MAP.Enemies[F].HP>0)
            {
                MAP.Enemies[F].Attack(MAP.HeroGS);
            }
        }

        public void MoveEnemies()
        {
            for (int i = 0; i < MAP.Enemies.Length; i++)
            {
                if (MAP.Enemies[i].HP > 0)
                {
                    MAP.MAPtiles[MAP.Enemies[i].X, MAP.Enemies[i].Y] = MAP.emptyTile;
                    MAP.Enemies[i].Move(MAP.Enemies[i].Returnmove(Character.Movement.Nothing));
                    if (MAP.MAPtiles[MAP.Enemies[i].X, MAP.Enemies[i].Y].GetType() == typeof(Gold))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.Enemies[i].X, MAP.Enemies[i].Y] == MAP.ITEMs[l])
                            {
                                MAP.Enemies[i].Pickup(MAP.ITEMs[l]);
                                break;
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.Enemies[i].X, MAP.Enemies[i].Y] = MAP.Enemies[i];
                }
            }
        }

        public void Save()// =============saving in binary format
        {
            Stream stream = File.Open("MAP-Data.bin", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, MAP);

            stream.Close();
        }

        public void Load()
        {
            MAP = null;

            Stream stream = File.Open("MAP-Data.bin", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            Map = (Map)formatter.Deserialize(stream);

            stream.Close();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {        
            info.AddValue("Map-Display", MAP);
        }

        public GameEngine(SerializationInfo info, StreamingContext context)
        {
            MAP = (Map)info.GetValue("Map-Display", typeof(Map));
        }
    }
}
