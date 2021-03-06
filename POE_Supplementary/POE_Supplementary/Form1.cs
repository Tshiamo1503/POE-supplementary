﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_Supplementary
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine = new GameEngine();
        private readonly Random ran = new Random();
        Shop shop ;
        int weaponbuy;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shop = new Shop(gameEngine.MAP.HeroGS);
            MAPlb.Text = gameEngine.ToString();//refresh map
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                enemylist.Items.Add(gameEngine.MAP.Enemies[i].ToString());
            }
            enemylist.SelectedIndex = 0;

            weaponbuy = ran.Next(0, 3);
            Shopbtn.Text = shop.DisplayWeapon(weaponbuy);

            if (shop.CanBuy(weaponbuy) == false)
            {
                Shopbtn.Enabled = false;
            }
            else
            {
                Shopbtn.Enabled = true;
            }

            Loadbtn.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)//Left
        {
            gameEngine.MovePlayer(Character.Movement.left);
            gameEngine.MAP.UpdateVision(gameEngine.MAP.HeroGS);
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            //========================================================enemy structure
            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                gameEngine.MAP.UpdateVision(gameEngine.MAP.Enemies[i]);
            }
            gameEngine.MoveEnemies();

            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                gameEngine.MAP.UpdateVision(gameEngine.MAP.Enemies[i]);
            }
            enemylist.Items.Clear();
            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                if (gameEngine.MAP.Enemies[i].HP > 0)
                {
                    enemylist.Items.Add(gameEngine.MAP.Enemies[i].ToString());
                }
            }
            enemylist.SelectedIndex = 0;
            bool enemyatk;
            for (int l = 0; l < gameEngine.MAP.Enemies.Length; l++)
            {
                if (gameEngine.MAP.Enemies[l].HP > 0)
                {
                    enemyatk = gameEngine.MAP.Enemies[l].CheckRange(gameEngine.MAP.HeroGS);
                    if (enemyatk == true)
                    {
                        gameEngine.EnemyAttacks(l);
                        AtkLogBox.AppendText(gameEngine.MAP.Enemies[l].GetType().Name + " Hit you from [" + gameEngine.MAP.Enemies[l].X + "," + gameEngine.MAP.Enemies[l].Y + "]" + "\n");
                        bool Hdead = gameEngine.MAP.HeroGS.IsDead();
                        if (Hdead == true)
                        {
                            MessageBox.Show("GAME OVER");
                            this.Close();
                        }
                        break;
                    }
                }
            }

            MAPlb.Text = gameEngine.ToString();//refresh map
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            if (shop.CanBuy(weaponbuy) == true)
            {
                Shopbtn.Enabled = true;
            }
        }

        private void Upbtn_Click(object sender, EventArgs e)//Up
        {
            gameEngine.MovePlayer(Character.Movement.up);
            gameEngine.MAP.UpdateVision(gameEngine.MAP.HeroGS);
            MAPlb.Text = gameEngine.ToString();
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            //========================================================enemy structure
            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                gameEngine.MAP.UpdateVision(gameEngine.MAP.Enemies[i]);
            }
            gameEngine.MoveEnemies();

            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                gameEngine.MAP.UpdateVision(gameEngine.MAP.Enemies[i]);
            }
            enemylist.Items.Clear();
            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                if (gameEngine.MAP.Enemies[i].HP > 0)
                {
                    enemylist.Items.Add(gameEngine.MAP.Enemies[i].ToString());
                }
            }
            enemylist.SelectedIndex = 0;

            bool enemyatk;
            for (int l = 0; l < gameEngine.MAP.Enemies.Length; l++)
            {
                if (gameEngine.MAP.Enemies[l].HP > 0)
                {
                    enemyatk = gameEngine.MAP.Enemies[l].CheckRange(gameEngine.MAP.HeroGS);
                    if (enemyatk == true)
                    {
                        gameEngine.EnemyAttacks(l);
                        AtkLogBox.AppendText(gameEngine.MAP.Enemies[l].GetType().Name + " Hit you from [" + gameEngine.MAP.Enemies[l].X + "," + gameEngine.MAP.Enemies[l].Y + "]" + "\n");
                        bool Hdead = gameEngine.MAP.HeroGS.IsDead();
                        if (Hdead == true)
                        {
                            MessageBox.Show("GAME OVER");
                            this.Close();
                        }
                        break;
                    }
                }
            }

            MAPlb.Text = gameEngine.ToString();//refresh map
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            if (shop.CanBuy(weaponbuy) == true)
            {
                Shopbtn.Enabled = true;
            }
        }

        private void Rightbtn_Click(object sender, EventArgs e)//Right
        {
            gameEngine.MovePlayer(Character.Movement.right);
            gameEngine.MAP.UpdateVision(gameEngine.MAP.HeroGS);
            MAPlb.Text = gameEngine.ToString();
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            //========================================================enemy structure
            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                gameEngine.MAP.UpdateVision(gameEngine.MAP.Enemies[i]);
            }
            gameEngine.MoveEnemies();

            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                gameEngine.MAP.UpdateVision(gameEngine.MAP.Enemies[i]);
            }
            enemylist.Items.Clear();
            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                if (gameEngine.MAP.Enemies[i].HP > 0)
                {
                    enemylist.Items.Add(gameEngine.MAP.Enemies[i].ToString());
                }
            }
            enemylist.SelectedIndex = 0;
            bool enemyatk;
            for (int l = 0; l < gameEngine.MAP.Enemies.Length; l++)
            {
                if (gameEngine.MAP.Enemies[l].HP > 0)
                {
                    enemyatk = gameEngine.MAP.Enemies[l].CheckRange(gameEngine.MAP.HeroGS);
                    if (enemyatk == true)
                    {
                        gameEngine.EnemyAttacks(l);
                        AtkLogBox.AppendText(gameEngine.MAP.Enemies[l].GetType().Name + " Hit you from [" + gameEngine.MAP.Enemies[l].X + "," + gameEngine.MAP.Enemies[l].Y + "]" + "\n");
                        bool Hdead = gameEngine.MAP.HeroGS.IsDead();
                        if (Hdead == true)
                        {
                            MessageBox.Show("GAME OVER");
                            this.Close();
                        }
                        break;
                    }
                }
            }

            MAPlb.Text = gameEngine.ToString();//refresh map
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            if (shop.CanBuy(weaponbuy) == true)
            {
                Shopbtn.Enabled = true;
            }
        }

        private void Downbtn_Click(object sender, EventArgs e)//Down
        {
            gameEngine.MovePlayer(Character.Movement.down);
            gameEngine.MAP.UpdateVision(gameEngine.MAP.HeroGS);
            MAPlb.Text = gameEngine.ToString();
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            //========================================================enemy structure
            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                gameEngine.MAP.UpdateVision(gameEngine.MAP.Enemies[i]);
            }
            gameEngine.MoveEnemies();

            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                gameEngine.MAP.UpdateVision(gameEngine.MAP.Enemies[i]);
            }
            enemylist.Items.Clear();
            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                if (gameEngine.MAP.Enemies[i].HP > 0)
                {
                    enemylist.Items.Add(gameEngine.MAP.Enemies[i].ToString());
                }
            }
            enemylist.SelectedIndex = 0;

            bool enemyatk;
            for (int l = 0; l < gameEngine.MAP.Enemies.Length; l++)
            {
                if (gameEngine.MAP.Enemies[l].HP > 0)
                {
                    enemyatk = gameEngine.MAP.Enemies[l].CheckRange(gameEngine.MAP.HeroGS);
                    if (enemyatk == true)
                    {
                        gameEngine.EnemyAttacks(l);
                        AtkLogBox.AppendText(gameEngine.MAP.Enemies[l].GetType().Name + " Hit you from [" + gameEngine.MAP.Enemies[l].X + "," + gameEngine.MAP.Enemies[l].Y + "]" + "\n");
                        bool Hdead = gameEngine.MAP.HeroGS.IsDead();
                        if (Hdead == true)
                        {
                            MessageBox.Show("GAME OVER");
                            this.Close();
                        }
                        break;
                    }
                }
            }

            MAPlb.Text = gameEngine.ToString();//refresh map
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            if (shop.CanBuy(weaponbuy) == true)
            {
                Shopbtn.Enabled = true;
            }
        }

        private void ATKbtn_Click(object sender, EventArgs e)
        {
            bool hitland = gameEngine.MAP.HeroGS.CheckRange(gameEngine.MAP.Enemies[enemylist.SelectedIndex]);
            if (hitland == true)
            {
                gameEngine.MAP.HeroGS.Attack(gameEngine.MAP.Enemies[enemylist.SelectedIndex]);
                enemylist.Text = gameEngine.MAP.Enemies[enemylist.SelectedIndex].ToString();
                enemylist.Items.Clear();
                for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
                {
                    if (gameEngine.MAP.Enemies[i].HP > 0)
                    {
                        enemylist.Items.Add(gameEngine.MAP.Enemies[i].ToString());
                    }
                }
                enemylist.SelectedIndex = 0;
                AtkLogBox.AppendText("Hit Landed!"+"\n");

                bool dead = gameEngine.MAP.Enemies[enemylist.SelectedIndex].IsDead();

                if (dead == true)
                {
                    AtkLogBox.AppendText(gameEngine.MAP.Enemies[enemylist.SelectedIndex].GetType().Name+" Killed!" + "\n");
                    gameEngine.MAP.HeroGS.Loot(gameEngine.MAP.Enemies[enemylist.SelectedIndex]);
                    gameEngine.MAP.MAPtiles[gameEngine.MAP.Enemies[enemylist.SelectedIndex].X, gameEngine.MAP.Enemies[enemylist.SelectedIndex].Y] = gameEngine.MAP.emptyTile;
                    //gameEngine.MAP.Enemies[enemylist.SelectedIndex] = null;
                    MAPlb.Text = gameEngine.ToString();
                    enemylist.Items.Clear();
                    for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
                    {
                        if (gameEngine.MAP.Enemies[i].HP > 0)
                        {
                            enemylist.Items.Add(gameEngine.MAP.Enemies[i].ToString());
                        }
                    }
                    enemylist.SelectedIndex = 0;
                    enemylist.Text = gameEngine.MAP.Enemies[enemylist.SelectedIndex].ToString();
                }

                //checks if all enemies are dead
                for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
                {
                    int counter = 0;

                    if (gameEngine.MAP.Enemies[i].HP <= 0)
                    {
                        counter++;
                    }

                    if (counter == gameEngine.MAP.Enemies.Length)
                    {
                        MessageBox.Show("YOU WIN !!!");
                        this.Close();
                    }
                }
            }
            else
            {
                enemylist.SelectedIndex = 0;
                AtkLogBox.AppendText("Hit Failed!"+"\n");
            }
            bool enemyatk; // enemies attacking
            for (int l = 0; l < gameEngine.MAP.Enemies.Length; l++)
            {
                if (gameEngine.MAP.Enemies[l].HP > 0)
                {
                    enemyatk = gameEngine.MAP.Enemies[l].CheckRange(gameEngine.MAP.HeroGS);
                    if (enemyatk == true)
                    {
                        gameEngine.EnemyAttacks(l);
                        AtkLogBox.AppendText(gameEngine.MAP.Enemies[l].GetType().Name + " Hit you from [" + gameEngine.MAP.Enemies[l].X + "," + gameEngine.MAP.Enemies[l].Y + "]" + "\n");
                        bool Hdead = gameEngine.MAP.HeroGS.IsDead();
                        if (Hdead == true)
                        {
                            MessageBox.Show("GAME OVER");
                            this.Close();
                        }
                        break;
                    }
                }
            }

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            gameEngine.Save();

            Savebtn.Enabled = false;
            Loadbtn.Enabled = true;
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            gameEngine.Load();
            shop = new Shop(gameEngine.MAP.HeroGS);
            MAPlb.Text = gameEngine.ToString();//refresh map
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            if (shop.CanBuy(weaponbuy) == false)
            {
                Shopbtn.Enabled = false;
            }
            else
            {
                Shopbtn.Enabled = true;
            }

            for (int i = 0; i < gameEngine.MAP.Enemies.Length; i++)
            {
                enemylist.Items.Add(gameEngine.MAP.Enemies[i].ToString());
            }
            enemylist.SelectedIndex = 0;

            Savebtn.Enabled = true;
            Loadbtn.Enabled = false;
        }

        private void Shopbtn_Click(object sender, EventArgs e)
        {
            shop.Buy(weaponbuy);
            weaponbuy = ran.Next(0, 3);
            Shopbtn.Text = shop.DisplayWeapon(weaponbuy);
            MAPlb.Text = gameEngine.ToString();//refresh map
            Statbx.Text = gameEngine.MAP.HeroGS.ToString();

            if (shop.CanBuy(weaponbuy) == false)
            {
                Shopbtn.Enabled = false;
            }
            else
            {
                Shopbtn.Enabled = true;
            }
        }
    }
}
