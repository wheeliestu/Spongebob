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
using System.Timers;
using System.Media;
using System.IO;

namespace wordBingo
{
    public partial class Home : Form
    {
        public SoundPlayer sound = new SoundPlayer();
        public double winMultiplier = 0;
        public int time = 0;
        public Random ran = new Random();
        public int counter = 0;
        public Home(Form5 form, ref int Money)
        {
            InitializeComponent();
            form5Inst = form;
            money.Text = Money.ToString();
        }
        Form5 form5Inst;
        private string randomPic ()
        {
            string fileName = "";
            int num = ran.Next(1, 9);
            switch (num)
            {
                case 1:
                    fileName = "sponge.PNG";
                    break;
                case 2:
                    fileName = "pat2.PNG";
                    break;
                case 3:
                    fileName = "san2.PNG";
                    break;
                case 4:
                    fileName = "squid.PNG";
                    break;
                case 5:
                    fileName = "krabs.PNG";
                    break;
                case 6:
                    fileName = "gary2.JPG";
                    break;
                case 7:
                    fileName = "plan.JPG";
                    break;
                case 8:
                    fileName = "patty.JPG";
                    break;
            }
            return fileName;
        }

        private void Bonusses()
        {
            sound.SoundLocation = "Spongebob_promotion.wav";
            sound.Play();
            int num = ran.Next(1,21);
            if (num == 1)
            {
                MessageBox.Show("Guess the friend bonus acitivated!");
                Form2 friendBonus = new Form2(this);
                friendBonus.ShowDialog();
            }
            else if (num == 2)
            {
                Form4 pattyBonus = new Form4(this);
                MessageBox.Show("Flip the patty bonus activated!");
                pattyBonus.ShowDialog();
            }
            else if (num == 3)
            {
                Form6 driving = new Form6(this);
                MessageBox.Show("Spongebob driving test bonus activated!");
                driving.ShowDialog();
            }
        }

        private void column2()
        {
            string picName = randomPic();
            c2r1.Image = Image.FromFile(picName);
            c2r1.Image.Tag = picName;
            picName = randomPic();
            c2r2.Image = Image.FromFile(picName);
            c2r2.Image.Tag = picName;
            picName = randomPic();
            c2r3.Image = Image.FromFile(picName);
            c2r3.Image.Tag = picName;
        }

        private void column3()
        {
            string picName = randomPic();
            c3r1.Image = Image.FromFile(picName);
            c3r1.Image.Tag = picName;
            picName = randomPic();
            c3r2.Image = Image.FromFile(picName);
            c3r2.Image.Tag = picName;
            picName = randomPic();
            c3r3.Image = Image.FromFile(picName);
            c3r3.Image.Tag = picName;
        }
        
        private void column4()
        {
            string picName = randomPic();
            c4r1.Image = Image.FromFile(picName);
            c4r1.Image.Tag = picName;
            picName = randomPic();
            c4r2.Image = Image.FromFile(picName);
            c4r2.Image.Tag = picName;
            picName = randomPic();
            c4r3.Image = Image.FromFile(picName);
            c4r3.Image.Tag = picName;
        }

        private void runGrid()
        {
            string picName = randomPic();
            c1r1.Image = Image.FromFile(picName);
            c1r1.Image.Tag = picName;
            picName = randomPic();
            c1r2.Image = Image.FromFile(picName);
            c1r2.Image.Tag = picName;
            picName = randomPic();
            c1r3.Image = Image.FromFile(picName);
            c1r3.Image.Tag = picName;

            time = 4;
            timer1.Start();
        }

        private void resetImages()
        {
            c1r1.Image = null;
            c1r2.Image = null;
            c1r3.Image = null;
            c2r1.Image = null;
            c2r2.Image = null;
            c2r3.Image = null;
            c3r1.Image = null;
            c3r2.Image = null;
            c3r3.Image = null;
            c4r1.Image = null;
            c4r2.Image = null;
            c4r3.Image = null;
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            resetImages();
            removeWins();
            if(stake.Text == "")
            {
                sound.SoundLocation = "Spongebob_no.wav";
                sound.Play();
                MessageBox.Show("Please select a stake");
            }
            else if(form5Inst.Money < 20)
            {
                MessageBox.Show("You have ran out of money, YOU LOSE!");
                Application.Exit();
            }
            else if(Convert.ToInt32(stake.Text) > form5Inst.Money)
            {
                sound.SoundLocation = "Spongebob_no.wav";
                sound.Play();
                MessageBox.Show("You dont have enough money to play that stake");
            }
            else
            {
                Bonusses();
                sound.SoundLocation = "Spongebob_Laugh.wav";
                sound.Play();
                win.Text = "";
                form5Inst.Money = form5Inst.Money - Convert.ToInt32(stake.Text);
                runGrid();
            }
        }

        public void checkWin()
        {
            if((c1r1.Image.Tag).ToString() == "patty.JPG")
            {
                c1r1.Image.Tag = c2r1.Image.Tag;
                if ((c2r1.Image.Tag).ToString() == "patty.JPG")
                {
                    c1r1.Image.Tag = c3r1.Image.Tag;
                    if((c3r1.Image.Tag).ToString() == "patty.JPG")
                    {
                        if((c4r1.Image.Tag).ToString() == "patty.JPG")
                        {
                            winMultiplier = winMultiplier + 15;
                            c1r1.Image.Tag = "Sponge.PNG";
                        }
                        else
                        {
                            c1r1.Image.Tag = c4r1.Image.Tag;
                        }
                    }
                }
            }
            if((c1r1.Image.Tag == c2r1.Image.Tag) || (c2r1.Image.Tag).ToString() == "patty.JPG")
            {
                winMultiplier = winMultiplier + 0.5;
                label4.Visible = true;
                label5.Visible = true;
                if ((c1r1.Image.Tag == c3r1.Image.Tag) || ((c3r1.Image.Tag).ToString() == "patty.JPG"))
                {
                    winMultiplier = winMultiplier + 2;
                    label6.Visible = true;
                    if ((c1r1.Image.Tag == c4r1.Image.Tag) || ((c4r1.Image.Tag).ToString() == "patty.JPG"))
                    {
                        winMultiplier = winMultiplier + 5;
                        label7.Visible = true;
                    }
                }
            }
            if ((c1r2.Image.Tag).ToString() == "patty.JPG")
            {
                c1r2.Image.Tag = c2r2.Image.Tag;
                if ((c2r2.Image.Tag).ToString() == "patty.JPG")
                {
                    c1r2.Image.Tag = c3r2.Image.Tag;
                    if ((c3r2.Image.Tag).ToString() == "patty.JPG")
                    {
                        if ((c4r2.Image.Tag).ToString() == "patty.JPG")
                        {
                            winMultiplier = winMultiplier + 15;
                            c1r2.Image.Tag = "Sponge.PNG";
                        }
                        else
                        {
                            c1r2.Image.Tag = c4r2.Image.Tag;
                        }
                    }
                }
            }
            if ((c1r2.Image.Tag == c2r2.Image.Tag) || (c2r2.Image.Tag).ToString() == "patty.JPG")
            {
                winMultiplier = winMultiplier + 0.5;
                label8.Visible = true;
                label9.Visible = true;
                if ((c1r2.Image.Tag == c3r2.Image.Tag) || ((c3r2.Image.Tag).ToString() == "patty.JPG"))
                {
                    winMultiplier = winMultiplier + 2;
                    label10.Visible = true;
                    if ((c1r2.Image.Tag == c4r2.Image.Tag) || ((c4r2.Image.Tag).ToString() == "patty.JPG"))
                    {
                        winMultiplier = winMultiplier + 5;
                        label11.Visible = true;
                    }
                }
            }
            if ((c1r3.Image.Tag).ToString() == "patty.JPG")
            {
                c1r3.Image.Tag = c2r3.Image.Tag;
                if ((c2r3.Image.Tag).ToString() == "patty.JPG")
                {
                    c1r3.Image.Tag = c3r3.Image.Tag;
                    if ((c3r3.Image.Tag).ToString() == "patty.JPG")
                    {
                        if ((c4r3.Image.Tag).ToString() == "patty.JPG")
                        {
                            winMultiplier = winMultiplier + 15;
                            c1r3.Image.Tag = "Sponge.PNG";
                        }
                        else
                        {
                            c1r3.Image.Tag = c4r3.Image.Tag;
                        }
                    }
                }
            }
            if ((c1r3.Image.Tag == c2r3.Image.Tag) || (c2r3.Image.Tag).ToString() == "patty.JPG")
            {
                winMultiplier = winMultiplier + 0.5;
                label12.Visible = true;
                label13.Visible = true;
                if ((c1r3.Image.Tag == c3r3.Image.Tag) || ((c3r3.Image.Tag).ToString() == "patty.JPG"))
                {
                    winMultiplier = winMultiplier + 2;
                    label14.Visible = true;
                    if ((c1r3.Image.Tag == c4r3.Image.Tag) || ((c4r3.Image.Tag).ToString() == "patty.JPG"))
                    {
                        winMultiplier = winMultiplier + 5;
                        label15.Visible = true;
                    }
                }
            }

            if(Convert.ToInt32(stake.Text) * winMultiplier != 0)
            {
                sound.SoundLocation = "Spongebob_victory.wav";
                sound.Play();
            }
            win.Text = ("Win: " + (Convert.ToInt32(stake.Text) * winMultiplier).ToString());
            form5Inst.Money = form5Inst.Money + Convert.ToInt32(Convert.ToInt32(stake.Text) * winMultiplier);
            money.Text = (form5Inst.Money).ToString();
            winMultiplier = 0;
        }

        public void removeWins()
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5Inst.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            if (time == 3)
            {
                column2();
            }
            else if(time == 2)
            {
                column3();
            }
            else if(time == 1)
            {
                column4();
            }
            else
            {
                sound.Stop();
                timer1.Stop();
                checkWin();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            form5Inst.Show();
        }
    }
}
