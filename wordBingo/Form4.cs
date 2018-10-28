using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordBingo
{
    public partial class Form4 : Form
    {
        public int time = 15;
        public Random ran = new Random();
        public int multiplier = 0;
        Home homeinst;
        public Form4(Home home)
        {
            InitializeComponent();
            showPatty();
            timer1.Start();
            homeinst = home;
        }

        private void start()
        {
            showPatty();
            timer1.Start();
        }

        private void showPatty()
        {
            switch (ran.Next(1, 12))
            {
                case 1:
                    button1.Enabled = true;
                    button1.Visible = true;
                    break;
                case 2:
                    button2.Enabled = true;
                    button2.Visible = true;
                    break;
                case 3:
                    button3.Enabled = true;
                    button3.Visible = true;
                    break;
                case 4:
                    button4.Enabled = true;
                    button4.Visible = true;
                    break;
                case 5:
                    button5.Enabled = true;
                    button5.Visible = true;
                    break;
                case 6:
                    button6.Enabled = true;
                    button6.Visible = true;
                    break;
                case 7:
                    button7.Enabled = true;
                    button7.Visible = true;
                    break;
                case 8:
                    button8.Enabled = true;
                    button8.Visible = true;
                    break;
                case 9:
                    button9.Enabled = true;
                    button9.Visible = true;
                    break;
                case 10:
                    button10.Enabled = true;
                    button10.Visible = true;
                    break;
                case 11:
                    button11.Enabled = true;
                    button11.Visible = true;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            if (time == 0)
            {
                MessageBox.Show("Time up" + "\n" + "Multiplier achieved: +" + multiplier);
                homeinst.winMultiplier = multiplier;
                homeinst.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button11.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button10.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.Visible = false;
            multiplier = multiplier + 1;
            showPatty();
        }
    }
}
