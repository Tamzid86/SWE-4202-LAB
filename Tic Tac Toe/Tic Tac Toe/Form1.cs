namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool play = true;
        int count = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button a1 = (Button)sender;
            if (play)
                a1.Text = "X";
            else
                a1.Text = "O";
            play = !play;
            a1.Enabled = false;
            CheckWinner();
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Button a2 = (Button)sender;
            if (play)
                a2.Text = "X";
            else
                a2.Text = "O";
            play = !play;
            a2.Enabled = false;
            CheckWinner();
            count++;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Button a3 = (Button)sender;
            if (play)
                a3.Text = "X";
            else
                a3.Text = "O";
            play = !play;
            a3.Enabled = false;
            CheckWinner();
            count++;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Button b1 = (Button)sender;
            if (play)
                b1.Text = "X";
            else
                b1.Text = "O";
            play = !play;
            b1.Enabled = false;
            CheckWinner();
            count++;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Button b2 = (Button)sender;
            if (play)
                b2.Text = "X";
            else
                b2.Text = "O";
            play = !play;
            b2.Enabled = false;
            CheckWinner();
            count++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b3 = (Button)sender;
            if (play)
                b3.Text = "X";
            else
                b3.Text = "O";
            play = !play;
            b3.Enabled = false;
            CheckWinner();
            count++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button c1 = (Button)sender;
            if (play)
                c1.Text = "X";
            else
                c1.Text = "O";
            play = !play;
            c1.Enabled = false;
            CheckWinner();
            count++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button c2 = (Button)sender;
            if (play)
                c2.Text = "X";
            else
                c2.Text = "O";
            play = !play;
            c2.Enabled = false;
            CheckWinner();
            count++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button c3 = (Button)sender;
            if (play)
                c3.Text = "X";
            else
                c3.Text = "O";
            play = !play;
            c3.Enabled = false;
            CheckWinner();
            count++;
        }
        private void CheckWinner()
        {
            bool flag = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text))
            {
                flag = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text))
            {
                flag = true;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text))
            {
                flag = true;
            }
            else if((a1.Text == b1.Text) && (b1.Text == c1.Text))
            {
                flag = true;
            }
            else if((a2.Text == b2.Text) && (b2.Text == c2.Text))
            {
                flag = true;
            }
            else if((a3.Text == b3.Text) && (b3.Text == c3.Text))
            {
                flag = true;
            }
            else if(( a1.Text == b2.Text) && (b2.Text == c3.Text))
            {
                flag = true;
            }
            else if((a3.Text == b2.Text) && (b2.Text == c1.Text))
            {
                flag = true;
            }
            
            if(flag)
            {
                string winner;
                if(play)
                {
                    winner = "Player 1";
                }
                else
                {
                    winner = "Player 2";
                }
                MessageBox.Show(winner + " wins!");
               
            }
            else if(count == 8)
            {
                MessageBox.Show("The match is drawn");
                
            }
        }
        public void Reset()
        {
            a1.Text = "a1";
            a2.Text = "a2";
            a3.Text = "a3";
            b1.Text = "b1";
            b2.Text = "b2";
            b3.Text = "b3";
            c1.Text = "c1";
            c2.Text = "c2";
            c3.Text = "c3";
        }
    }
}