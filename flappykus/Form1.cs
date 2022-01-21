namespace flappykus
{
    public partial class Form1 : Form
    {

        int boruHizi = 8;
        int gravity = 10;
        int score = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Kus.Top += gravity;
            BoruAlt.Left -= boruHizi;
            BoruUst.Left -= boruHizi;
            scoreText.Text = "Score: " + score;
            if (BoruAlt.Left<-150)
            {
                BoruAlt.Left = 800;
                score++;
            }
            if (BoruUst.Left<-180)
            {
                BoruUst.Left = 950;
                score++;
            }
            if (Kus.Bounds.IntersectsWith(BoruAlt.Bounds)||Kus.Bounds.IntersectsWith(BoruUst.Bounds)||Kus.Bounds.IntersectsWith(Yer.Bounds))

            {
                endGame();
            }
            if (score > 5)
            {
                boruHizi = 15;
            }
            if (Kus.Top<-25)

            {
                endGame();

            }
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endGame()
            {
            Zaman.Stop();
            scoreText.Text = "Game Over!!!";

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }