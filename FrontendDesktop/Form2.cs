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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Width)
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }
    }
}
