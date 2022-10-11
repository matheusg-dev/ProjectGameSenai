namespace FrontendDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // picture box solo
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

        // picture box duo
        private void pb_duo_MouseClick(object sender, MouseEventArgs e)
        {
            pb_duo.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\duopress.jpg");
        }

        private void pb_duo_MouseEnter(object sender, EventArgs e)
        {
            pb_duo.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\duoup.jpg");
        }

        private void pb_duo_MouseLeave(object sender, EventArgs e)
        {
            pb_duo.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\duofix.jpg");
        }

        // picture box placar
        private void pb_placar_MouseClick(object sender, MouseEventArgs e)
        {
            pb_placar.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\placarpress.jpg");

        }

        private void pb_placar_MouseEnter(object sender, EventArgs e)
        {
            pb_placar.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\placarup.jpg");
        }

        private void pb_placar_MouseLeave(object sender, EventArgs e)
        {
            pb_placar.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\placarfix.jpg");
        }

        //picture box cores
        private void pb_cores_MouseClick(object sender, MouseEventArgs e)
        {
            pb_cores.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\corespress.jpg");
        }

        private void pb_cores_MouseEnter(object sender, EventArgs e)
        {
            pb_cores.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\coresup.jpg");
        }

        private void pb_cores_MouseLeave(object sender, EventArgs e)
        {
            pb_cores.Image = Image.FromFile(@"E:\ProjetoPongII\FrontendDesktop\img\coresfix.jpg");
        }
    }
}