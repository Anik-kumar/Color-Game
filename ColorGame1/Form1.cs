using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorGame1
{
    public partial class Form1 : Form
    {
        private Timer time;
        private Random rnd;
        private bool isEnd = true;
        private int score = 0;


        public Form1()
        {
            InitializeComponent();

            rnd = new Random();
            time = new Timer();

            time.Enabled = true;
            time.Interval = 725;
            time.Tick += time_Tick;
            isEnd = false;

        }

        public void time_Tick(object sender, EventArgs e)
        {
            int x = rnd.Next(12);
            

            if (x == 0)
            {
                
                this.button1.BackColor = Color.Blue;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;
            }
            else if (x == 1)
            {
                
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.Blue;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 2)
            {
                
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.Blue;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 3)
            {
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.Blue;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 4)
            {
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.Blue;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 5)
            {
                
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.Blue;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 6)
            {
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.Blue;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 7)
            {
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.Blue;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 8)
            {
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.Blue;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 9)
            {
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.Blue;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.White;

            }
            else if (x == 10)
            {
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.Blue;
                this.button12.BackColor = Color.White;

            }
            else
            {
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                this.button10.BackColor = Color.White;
                this.button11.BackColor = Color.White;
                this.button12.BackColor = Color.Blue;

            }
            

            if(score <= -200)
            {
                time.Enabled = false;
                MessageBox.Show("          You Are Far From Winning.     " , "Game Over");
                isEnd = true;
            }
            else if(score == 150)
            {
                time.Enabled = false;
                MessageBox.Show("            Congrats, You Won           ", "Game Over");
                isEnd = true;
            }

            //Console.WriteLine(x);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = this.button1.BackColor;
            if(c == Color.Blue && isEnd == false)
            {
                this.button1.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button1.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var c = this.button2.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button2.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button2.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var c = this.button3.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button3.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button3.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var c = this.button4.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button4.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button4.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var c = this.button5.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button5.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button5.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var c = this.button6.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button6.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button6.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var c = this.button7.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button7.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button7.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var c = this.button8.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button8.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button8.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var c = this.button9.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button9.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button9.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var c = this.button10.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button10.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button10.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var c = this.button11.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button11.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button11.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var c = this.button12.BackColor;
            if (c == Color.Blue && isEnd == false)
            {
                this.button12.BackColor = Color.Green;
                score += 10;
                this.scoreBox.Text = score.ToString();
            }
            else if (isEnd == false)
            {
                this.button12.BackColor = Color.Red;
                score -= 10;
                this.scoreBox.Text = score.ToString();
            }
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            scoreBox.Clear();
            time.Enabled = true;
            //time.Interval = 1000;
            //time.Tick += time_Tick;
            score = 0;
            isEnd = false;
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
