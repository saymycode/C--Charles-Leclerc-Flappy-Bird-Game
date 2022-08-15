namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int boruSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimeEvent(object sender, EventArgs e)
        {
            Leclerc.Top += gravity;
            BoruAlt.Left -= boruSpeed;
            BoruUst.Left -= boruSpeed;
            scoreText.Text = "Score: " + score;
            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800;
                score++;
            }
            if (BoruUst.Left < -180)
            {
                BoruUst.Left = 950;
                score++;
            }
            if (Leclerc.Bounds.IntersectsWith(BoruAlt.Bounds) || Leclerc.Bounds.IntersectsWith(BoruUst.Bounds) || Leclerc.Bounds.IntersectsWith(Way.Bounds)||Leclerc.Bounds.IntersectsWith(binotto.Bounds))
            {
                endGame();
            }
            if (score > 5)
            {
                boruSpeed = 12;
            }

            if (Leclerc.Top < -0)
            {
                endGame();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }
        private void endGame()
        {
            GameTime.Stop();
            scoreText.Text = "MAX VERSTAPPEN WDC!!!";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BoruUst_Click(object sender, EventArgs e)
        {

        }
    }
}