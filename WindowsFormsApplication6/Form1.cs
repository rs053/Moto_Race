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
    //form 1 coding 
    public partial class Form1 : Form
    {
        public int players = 3;
        public int counter1 = 0;
        public int flag1=0, flag2=0, flag3=0, flag4=0;
        public int num;
        simu simu_ob = new simu();
        navjot navjot_ob = new navjot();
        amit amit_ob = new amit();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"Images\baby.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            simu_ob.amount = 50;
            simu_ob.joe_bet_amount = 0;
            simu_ob.simu_bet_runner = 0;
            navjot_ob.amount = 50;
            navjot_ob.navjot_bet_amount = 0;
            navjot_ob.navjot_bet_runner = 0;
            amit_ob.amount = 50;
            amit_ob.amit_bet_amount = 0;
            amit_ob.amit_bet_runner = 0;

            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;

            label1.Text = "";
            label2.Text = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            pictureBox2.Location = new Point(50, pictureBox2.Location.Y);
            pictureBox3.Location = new Point(50, pictureBox3.Location.Y);
            pictureBox4.Location = new Point(50, pictureBox4.Location.Y);
            pictureBox5.Location = new Point(50, pictureBox5.Location.Y);
            counter1 = 0;
        }
        //radio button coding is here
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (simu_ob.amount == 0)
            {
                numericUpDown1.Value = 1;
                label2.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = simu_ob.amount;
                label2.Text = Convert.ToString("$"+simu_ob.amount);
            }
        }
        //radio button coding is here
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (navjot_ob.amount == 0)
            {
                numericUpDown1.Value = 1;
                label2.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = navjot_ob.amount;
                label2.Text = Convert.ToString("$"+navjot_ob.amount);
            }
        }
        //radio button coding is here
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            if (amit_ob.amount == 0)
            {
                numericUpDown1.Value = 1;
                label2.Text = Convert.ToString("$"+0);
            }
            else
            {
                numericUpDown1.Maximum = amit_ob.amount;
                label2.Text = Convert.ToString("$"+amit_ob.amount);
            }
        }
        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (simu_ob.simu_bet_runner != 0)
                {
                    MessageBox.Show("You already put the money");
                }
                else
                {
                    label1.Text = "money left for simu";
                    simu_ob.joe_bet_amount = Convert.ToInt16(numericUpDown1.Value);
                    simu_ob.simu_bet_runner = Convert.ToInt16(numericUpDown2.Value);
                    simu_ob.amount = simu_ob.amount - simu_ob.joe_bet_amount;
                    label2.Text = simu_ob.amount.ToString();
                    textBox1.Text = " bets $" + simu_ob.joe_bet_amount + " on runner " + simu_ob.simu_bet_runner;
                }
                flag++;
            }
            else if (radioButton2.Checked==true)
            {
                if (navjot_ob.navjot_bet_runner != 0)
                {
                    MessageBox.Show("You already put the money");
                }
                else
                {
                    label1.Text = "money left for navjot";
                    navjot_ob.navjot_bet_amount = Convert.ToInt16(numericUpDown1.Value);
                    navjot_ob.navjot_bet_runner = Convert.ToInt16(numericUpDown2.Value);
                    navjot_ob.amount = navjot_ob.amount - navjot_ob.navjot_bet_amount;
                    label2.Text = navjot_ob.amount.ToString();
                    textBox2.Text = "Bob bets $" + navjot_ob.navjot_bet_amount + " on runner " + navjot_ob.navjot_bet_runner;
                }
                flag++;
            }
            else if (radioButton3.Checked==true)
            {
                if (amit_ob.amit_bet_runner!=0)
                {
                    MessageBox.Show("You already put the money");
                }
                else
                {
                    label1.Text = "money left for amit";
                    amit_ob.amit_bet_amount = Convert.ToInt16(numericUpDown1.Value);
                    amit_ob.amit_bet_runner = Convert.ToInt16(numericUpDown2.Value);
                    amit_ob.amount = amit_ob.amount - amit_ob.amit_bet_amount;
                    label2.Text = amit_ob.amount.ToString();
                    textBox3.Text = "amit bets $" + amit_ob.amit_bet_amount + " on runner " + amit_ob.amit_bet_runner;
                }
                flag++;
            }
            if (flag == 3)
            {
                button2.Enabled = true;
            }
           
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        //button 2 coding
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

                if (simu_ob.simu_bet_runner == num)
                {
                    simu_ob.amount = simu_ob.amount + simu_ob.joe_bet_amount;
                }

                if (navjot_ob.navjot_bet_runner == num)
                {
                    navjot_ob.amount = navjot_ob.amount + navjot_ob.navjot_bet_amount;
                }

                if (amit_ob.amit_bet_runner == num)
                {
                    amit_ob.amount = amit_ob.amount + amit_ob.amit_bet_amount;
                }

                if (simu_ob.amount == 0)
                {
                    radioButton1.Enabled = false;
                    textBox1.Text = "Busted";
                    textBox1.ForeColor = Color.Red;
                    players--;
                }

                if (navjot_ob.amount == 0)
                {
                    radioButton2.Enabled = false;
                    textBox2.Text = "Busted";
                    textBox2.ForeColor = Color.Red;
                    players--;
                }

                if (amit_ob.amount == 0)
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
                simu_ob.joe_bet_amount = 0;
                simu_ob.simu_bet_runner = 0;
                navjot_ob.navjot_bet_amount = 0;
                navjot_ob.navjot_bet_runner = 0;
                amit_ob.amit_bet_amount = 0;
                amit_ob.amit_bet_runner = 0;

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
