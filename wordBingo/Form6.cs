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
    public partial class Form6 : Form
    {
        public int multiplier = 0;
        public int time = 31;
        public Form6(Home home)
        {
            InitializeComponent();
            homeInst = home;
            timer1.Start();
        }
        Home homeInst;

        private void test_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                car.Location = new Point(car.Location.X, car.Location.Y - 5);
            }
            else if (e.KeyCode == Keys.Right)
            {
                car.Location = new Point(car.Location.X + 5, car.Location.Y);
            }
            else if(e.KeyCode == Keys.Down)
            {
                car.Location = new Point(car.Location.X, car.Location.Y +5);
            }
            else if (e.KeyCode == Keys.Left)
            {
                car.Location = new Point(car.Location.X - 5, car.Location.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            if (time == 30)
            {
                MessageBox.Show("Arrow keys to move");
                timer1.Start();
                homeInst.sound.SoundLocation = "Spongebob_car.wav";
                homeInst.sound.Play();
            }
            if((car.Location.X <= 400) && ((car.Location.Y >= 290) && (car.Location.Y <= 500)))
            {
                timer1.Stop();
                if(time >= 20)
                {
                    multiplier = 10;
                }
                else if(time >= 10)
                {
                    multiplier = 5;
                }
                else if((time != 0) && (time < 10))
                {
                    multiplier = 2;
                }
                homeInst.winMultiplier = multiplier;
                MessageBox.Show("Multiplier achieved: " + multiplier.ToString());
                this.Close();
            }

            if(time == 0)
            {
                MessageBox.Show("Time up, no bonus score");
                homeInst.sound.Stop();
                this.Close();
            }

        }
    }
}
