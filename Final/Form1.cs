using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            Enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }

        int collectedcoins = 0;



        Random r = new Random();
        int x, y;
        void Enemy(int speed)
        {
            if (Enemy1.Top >= 500)
            { x = r.Next(0, 100);
             // y = r.Next(0, 75);
                Enemy1.Location = new Point(x, 0);
            }
            else { Enemy1.Top += speed; }

            if (Enemy2.Top >= 500)
            {
                x = r.Next(100, 175);
               // y = r.Next(0, 75);
                Enemy2.Location = new Point(x, 0);
            }
            else { Enemy2.Top += speed; }

            if (Enemy3.Top >= 500)
            {
                x = r.Next(175, 290);
              //  y = r.Next(0, 75);
                Enemy3.Location = new Point(x, 0);
            }
            else { Enemy3.Top += speed; }

        }



        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 290);
                
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 290);

                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(0, 290);

                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 290);

                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }



        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(Enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }





        }


        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }



            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label1.Text="Coins="+collectedcoins.ToString();
                x = r.Next(0, 290);

                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, 290);

                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, 290);

                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(0, 290);

                coin4.Location = new Point(x, 0);
            }

        }


        int gamespeed = 0;


       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left >= 0)
                    car.Left += -15;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 280)
                    car.Left += 15;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
        }


    }
}
