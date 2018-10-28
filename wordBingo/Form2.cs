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
    public partial class Form2 : Form
    {
        public double multiplier = 0;
        public Form2(Home home)
        {
            InitializeComponent();
            homeInst = home;
        }
        Home homeInst;
        private void button1_Click(object sender, EventArgs e)
        {
            if(characterSelection.Text == "")
            {
                homeInst.sound.SoundLocation = "Spongebob_no.wav";
                homeInst.sound.Play();
                MessageBox.Show("Please select a name");
            }
            else
            {
                Random ran = new Random();
                string name = "";
                switch(ran.Next(1, 7))
                {
                    case 1:
                        Photo.Image = Image.FromFile("pat2.PNG");
                        name = "Patrick";
                        break;
                    case 2:
                        Photo.Image = Image.FromFile("squid.PNG");
                        name = "Squidward";
                        break;
                    case 3:
                        Photo.Image = Image.FromFile("san2.PNG");
                        name = "Sandy";
                        break;
                    case 4:
                        Photo.Image = Image.FromFile("plan.JPG");
                        name = "Plankton";
                        break;
                    case 5:
                        Photo.Image = Image.FromFile("krabs.PNG");
                        name = "Mr krabs";
                        break;
                    case 6:
                        Photo.Image = Image.FromFile("gary2.JPG");
                        name = "Gary";
                        break;
                }

                if(characterSelection.Text == name)
                {
                    homeInst.winMultiplier = 10;
                    MessageBox.Show("Congratulations, you guessed correctly");
                }
                else
                {
                    MessageBox.Show("Unfortunately you guessed incorrectly" + "\n" + "Correct answer was " + name);
                }
                homeInst.Show();
                this.Close();
            }

        }
    }
}
