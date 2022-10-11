namespace FrontendDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pb_solo_MouseClick(object sender, MouseEventArgs e)
        {
            pb_solo.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\solopress2.jpg");
        }



        private void pb_solo_MouseEnter(object sender, EventArgs e)
        {
            pb_solo.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\soloup2.jpg");
        }

        private void pb_solo_MouseLeave(object sender, EventArgs e)
        {
            pb_solo.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\solofix2.jpg");
        }

        private void tm_solo_Tick(object sender, EventArgs e)
        {

        }

        private void tra(object sender, EventArgs e)
        {

        }

        private void pb_duo_Click(object sender, EventArgs e)
        {

        }

        private void pb_duo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pb_duo_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pb_duo_MouseLeave(object sender, EventArgs e)
        {
            pb_solo.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\duofix.jpg");
        }
    }
}