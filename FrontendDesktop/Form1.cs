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

        }



        private void pb_solo_MouseEnter(object sender, EventArgs e)
        {
            tm_solo.Start();
        }

        private void pb_solo_MouseLeave(object sender, EventArgs e)
        {
            tm_solo.Stop();
        }

        private void tm_solo_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Foi garaio");
            tm_solo.Stop();
        }

        private void tra(object sender, EventArgs e)
        {

        }
    }
}