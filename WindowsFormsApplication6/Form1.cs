using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public int players = 3;
        public int counter1 = 0;
        public int flag1=0, flag2=0, flag3=0, flag4=0;
        public int num;
        Joe joe_ob = new Joe();
        Bob bob_ob = new Bob();
        Al al_ob = new Al();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"Images\Track1.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            joe_ob.amount = 50;
            joe_ob.joe_bet_amount = 0;
            joe_ob.joe_bet_runner = 0;
            bob_ob.amount = 50;
            bob_ob.bob_bet_amount = 0;
            bob_ob.bob_bet_runner = 0;
            al_ob.amount = 50;
            al_ob.al_bet_amount = 0;
            al_ob.al_bet_runner = 0;

            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            pictureBox2.Location = new Point(50, pictureBox2.Location.Y);
            pictureBox3.Location = new Point(50, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(50, pictureBox4.Location.Y);
            pictureBox5.Location = new Point(50, pictureBox5.Location.Y);
            counter1 = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (joe_ob.amount == 0)
            {
                numericUpDown1.Value = 1;
                label2.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = joe_ob.amount;
                label2.Text = Convert.ToString("$"+joe_ob.amount);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (bob_ob.amount == 0)
            {
                numericUpDown1.Value = 1;
                label2.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = bob_ob.amount;
                label2.Text = Convert.ToString("$"+bob_ob.amount);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (al_ob.amount == 0)
            {
                numericUpDown1.Value = 1;
                label2.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = al_ob.amount;
                label2.Text = Convert.ToString("$"+al_ob.amount);
            }
        }
        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (joe_ob.joe_bet_runner != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    label1.Text = "Amount After Bet for Joe";
                    joe_ob.joe_bet_amount = Convert.ToInt16(numericUpDown1.Value);
                    joe_ob.joe_bet_runner = Convert.ToInt16(numericUpDown2.Value);
                    joe_ob.amount = joe_ob.amount - joe_ob.joe_bet_amount;
                    label2.Text = joe_ob.amount.ToString();
                    textBox1.Text = "Joe bets $" + joe_ob.joe_bet_amount + " on runner " + joe_ob.joe_bet_runner;
                }
                flag++;
            }
            else if (radioButton2.Checked==true)
            {
                if (bob_ob.bob_bet_runner != 0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    label1.Text = "Amount After Bet for Bob";
                    bob_ob.bob_bet_amount = Convert.ToInt16(numericUpDown1.Value);
                    bob_ob.bob_bet_runner = Convert.ToInt16(numericUpDown2.Value);
                    bob_ob.amount = bob_ob.amount - bob_ob.bob_bet_amount;
                    label2.Text = bob_ob.amount.ToString();
                    textBox2.Text = "Bob bets $" + bob_ob.bob_bet_amount + " on runner " + bob_ob.bob_bet_runner;
                }
                flag++;
            }
            else if (radioButton3.Checked==true)
            {
                if (al_ob.al_bet_runner!=0)
                {
                    MessageBox.Show("You already placed a bet");
                }
                else
                {
                    label1.Text = "Amount After Bet for Al";
                    al_ob.al_bet_amount = Convert.ToInt16(numericUpDown1.Value);
                    al_ob.al_bet_runner = Convert.ToInt16(numericUpDown2.Value);
                    al_ob.amount = al_ob.amount - al_ob.al_bet_amount;
                    label2.Text = al_ob.amount.ToString();
                    textBox3.Text = "Al bets $" + al_ob.al_bet_amount + " on runner " + al_ob.al_bet_runner;
                }
                flag++;
            }
            if (flag == 3)
            {
                button2.Enabled = true;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int i;
            Random r = new Random();
            num = r.Next(1, 5);

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 1)
            {
                flag1 = 1;
                pictureBox2.Left = pictureBox2.Left + 95;
                counter1++;
            }
            else if (num==2)
            {
                flag2 = 1;
                pictureBox3.Left = pictureBox3.Left + 95;
                counter1++;
            }
            else if (num==3)
            {
                flag3 = 1;
                pictureBox4.Left = pictureBox4.Left + 95;
                counter1++;
            }
            else if(num==4)
            {
                flag4 = 1;
                pictureBox5.Left = pictureBox5.Left + 95;
                counter1++;
            }
            if (counter1 == 10)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;

                MessageBox.Show("Winning bet is " + num);

                if (joe_ob.joe_bet_runner == num)
                {
                    joe_ob.amount = joe_ob.amount + joe_ob.joe_bet_amount;
                }

                if (bob_ob.bob_bet_runner == num)
                {
                    bob_ob.amount = bob_ob.amount + bob_ob.bob_bet_amount;
                }

                if (al_ob.al_bet_runner == num)
                {
                    al_ob.amount = al_ob.amount + al_ob.al_bet_amount;
                }

                if (joe_ob.amount == 0)
                {
                    radioButton1.Enabled = false;
                    textBox1.Text = "Busted";
                    textBox1.ForeColor = Color.Red;
                    players--;
                }

                if (bob_ob.amount == 0)
                {
                    radioButton2.Enabled = false;
                    textBox2.Text = "Busted";
                    textBox2.ForeColor = Color.Red;
                    players--;
                }

                if (al_ob.amount == 0)
                {
                    radioButton3.Enabled = false;
                    textBox3.Text = "Busted";
                    textBox3.ForeColor = Color.Red;
                    players--;
                }

                if (players == 0)
                {
                    MessageBox.Show("All Players Lose");
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
                else if (players == 1)
                {
                    MessageBox.Show("Bet End");
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
                joe_ob.joe_bet_amount = 0;
                joe_ob.joe_bet_runner = 0;
                bob_ob.bob_bet_amount = 0;
                bob_ob.bob_bet_runner = 0;
                al_ob.al_bet_amount = 0;
                al_ob.al_bet_runner = 0;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                numericUpDown1.Value = 1;
                numericUpDown2.Value = 1;

                pictureBox2.Location = new Point(50,pictureBox2.Location.Y);
                pictureBox3.Location = new Point(50, pictureBox3.Location.Y);
                pictureBox4.Location = new Point(50, pictureBox4.Location.Y);
                pictureBox5.Location = new Point(50, pictureBox5.Location.Y);
                counter1 = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (flag1 == 1)
            {
                pictureBox3.Left = pictureBox3.Left + 65;
                pictureBox4.Left = pictureBox4.Left + 70;
                pictureBox5.Left = pictureBox5.Left + 80;
            }
            else if (flag2 == 1)
            {
                pictureBox2.Left = pictureBox2.Left + 50;
                pictureBox4.Left = pictureBox4.Left + 75;
                pictureBox5.Left = pictureBox5.Left + 50;
            }
            else if (flag3 == 1)
            {
                pictureBox2.Left = pictureBox2.Left + 70;
                pictureBox3.Left = pictureBox3.Left + 50;
                pictureBox5.Left = pictureBox5.Left + 80;
            }
            else if (flag4==1)
            {
                pictureBox2.Left = pictureBox2.Left + 66;
                pictureBox3.Left = pictureBox3.Left + 80;
                pictureBox4.Left = pictureBox4.Left + 85;
            }
        }
    }
}
