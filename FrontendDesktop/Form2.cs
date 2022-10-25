using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontendDesktop
{
    public partial class Form2 : Form
    {
        Bitmap bmp = null;
        Graphics g = null;
        World world = new World();
        public Form2()
        {
            InitializeComponent();
            ParticleBall p1 = new ParticleBall
            {
                Mass = 80,
                PositionX = 150,
                PositionY = pictureBox1.Height,
                DX = 400,
                DY = 500
            };
            world.Balls.Add(p1);

            ParticleBar b1 = new ParticleBar
            {
                Width = 15,
                Height = 100,
                PositionX = 250,
                PositionY = pictureBox1.Height / 2,
            };
            world.Bars.Add(b1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Width);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            timer1.Start();

            world.Draw(g);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            world.Draw(g);
            world.DrawRectangle(g);
            pictureBox1.Refresh();

            foreach (var et in world.Balls)
            {
                if (et.PositionX > (pictureBox1.Right - (et.Mass / 2)))
                {
                    et.DX *= -1;
                }

                if (et.PositionX < (pictureBox1.Left + (et.Mass / 2)))
                {
                    et.DX *= -1;
                }
                if (et.PositionY > (pictureBox1.Top + (et.Mass / 2)))
                {
                    et.DY *= -1;
                }
                if (et.PositionY < (pictureBox1.Bottom - (et.Mass / 2)))
                {
                    et.DY *= -1;
                }
            }
        }
    }
}
