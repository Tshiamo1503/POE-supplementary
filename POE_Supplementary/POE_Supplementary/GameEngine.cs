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
    class GameEngine : ISerializable
    {
        private Map Map;
        public Map MAP { get => Map; set => Map = value; }

        public GameEngine()
        {
            Map = new Map(10, 15, 10, 15, 10, 10, 5);
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
                    if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(Gold))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] == MAP.ITEMs[l])
                            {
                                MAP.HeroGS.Pickup(MAP.ITEMs[l]);
                                break;
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.HeroGS;
                    break;

                case Character.Movement.right:
                    move = true;
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.emptyTile;
                    MAP.HeroGS.Move(MAP.HeroGS.Returnmove(Character.Movement.right));
                    if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(Gold))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] == MAP.ITEMs[l])
                            {
                                MAP.HeroGS.Pickup(MAP.ITEMs[l]);
                                break;
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.HeroGS;
                    break;

                case Character.Movement.up:
                    move = true;
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.emptyTile;
                    MAP.HeroGS.Move(MAP.HeroGS.Returnmove(Character.Movement.up));
                    if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(Gold))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] == MAP.ITEMs[l])
                            {
                                MAP.HeroGS.Pickup(MAP.ITEMs[l]);
                                break;
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.HeroGS;
                    break;

                case Character.Movement.down:
                    move = true;
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.emptyTile;
                    MAP.HeroGS.Move(MAP.HeroGS.Returnmove(Character.Movement.down));
                    if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y].GetType() == typeof(Gold))
                    {
                        for (int l = 0; l < MAP.ITEMs.Length; l++)
                        {
                            if (MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] == MAP.ITEMs[l])
                            {
                                MAP.HeroGS.Pickup(MAP.ITEMs[l]);
                                break;
                            }
                        }
                    }
                    MAP.MAPtiles[MAP.HeroGS.X, MAP.HeroGS.Y] = MAP.HeroGS;
                    break;

            }
            return move;
        }

        private static readonly char HeroC = 'H', GoblinC = 'G', ObsticleC = 'X', EmptyC = '.', MageC = 'M', LeaderC = 'L', GoldC = '$';

        public override string ToString()
        {
            string output = "";
            for (int j = 0; j < Map.HEIGHT; j++)
            {
                for (int i = 0; i < Map.WIDTH; i++)
                {
                    if (MAP.MAPtiles[i,j].GetType() == Map.emptyTile.GetType())                       //empty
                    {
                        output += EmptyC;
                    }
                    if (MAP.MAPtiles[i, j].GetType() == MAP.obstacle.GetType())                      //obstacle
                    {
                        output += ObsticleC;
                    }
                    if (MAP.MAPtiles[i, j].GetType() == MAP.HeroGS.GetType())                        //hero
                    {
                        output += HeroC;
                    }

                    for (int k = 0; k < MAP.Enemies.Length; k++)
                    {
                        if (MAP.MAPtiles[i, j] == MAP.Enemies[k])
                        {
                            if (MAP.Enemies[k].GetType() == MAP.GoblinOBJ.GetType())
                            {
                                output += GoblinC;
                                break;
                            }
                            if (MAP.Enemies[k].GetType() == MAP.MageOBJ.GetType())
                            {
                                output += MageC;
                                break;
                            }
                        }
                    }                                  //Enenmies

                    for (int k = 0; k < MAP.ITEMs.Length; k++)
                    {
                        if (MAP.MAPtiles[i, j] == MAP.ITEMs[k])
                        {
                            if (MAP.ITEMs[k].GetType() == MAP.GoldOBJ.GetType())
                            {
                                output += GoldC;
                                break;
                            }
                            /*if (MAP.ITEMs[k] == MAP.MageOBJ)
                            {
                                output += MageC;
                                break;
                            }*/
                        }
                    }       

                }
                output += "\n";
            }

            return output;
        }

        public void EnemyAttacks()
        {
            for (int i = 0; i < MAP.Enemies.Length; i++)
            {
                MAP.Enemies[i].Attack(MAP.HeroGS);
            }


        }

        public void MoveEnemies()
        {
            for (int i = 0; i < MAP.Enemies.Length; i++)
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

        public void Save()// =============saving in binary format
        {


            if (File.Exists("Map Data"))
            {
                Stream stream = File.Open("Map-Data.dat", FileMode.Open);
                BinaryFormatter Bin = new BinaryFormatter();

                Bin.Serialize(stream, Map);
                stream.Close();
            }
            else
            {
                Stream stream = File.Open("Map-Data.dat", FileMode.Create);
                BinaryFormatter Bin = new BinaryFormatter();

                Bin.Serialize(stream, Map);
                stream.Close();
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Map-Display", Map);
            throw new NotImplementedException();
        }

        public GameEngine(SerializationInfo info, StreamingContext context)
        {
            Map = (Map)info.GetValue("Map-Display", typeof(Map));
        }

        public void Load()
        {
            Map = null;

            Stream stream = File.Open("Map-Data.dat", FileMode.Open);
            BinaryFormatter Bin = new BinaryFormatter();

            Map = (Map)Bin.Deserialize(stream);
            stream.Close();
        }
    }
}
