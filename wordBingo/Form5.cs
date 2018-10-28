using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wordBingo
{
    public partial class Form5 : Form
    {
        public struct Array
        {
            public string name;
            public string password;
            public int money;
        }
        public static int count = 0;
        public int arrayReference = 0;
        public static Array[] names = new Array[10];
        public int Money;
        public Form5()
        {
            InitializeComponent();
            loadNames();
            MessageBox.Show("Game does include sound effects so volume is recomended (though it gets annoying after a while)" + "\n" + "Driving game little incomplete, the goal works but you can drive anywhere no penalty" + "\n" + "Hope you enjoy! :)");
        }

        private static void loadNames()
        {
            string line = "";
            StreamReader input = new StreamReader("Usernames.txt");
            while((line = input.ReadLine()) != null)
            {
                names[count].name = line.Substring(0, line.IndexOf("-"));
                line = line.Remove(0, line.IndexOf("-") + 1);
                names[count].password = line.Substring(0, line.IndexOf("-"));
                line = line.Remove(0, line.IndexOf("-") + 1);
                names[count].money = Convert.ToInt32(line);
                count = count + 1;
            }
            input.Close();

        }

        private void login_Click_1(object sender, EventArgs e)
        {
            Home home = new Home(this, ref Money);
            int i;
            for (i = 0; i < 10; i++)
            {
                if (nameTB.Text == names[i].name)
                {
                    if (passwordTB.Text == names[i].password)
                    {
                        Money = names[i].money;
                        arrayReference = i;
                        this.Hide();
                        home.ShowDialog();
                        break;
                    }
                }
            }
            if(i == 10)
            {
                MessageBox.Show("Username or password incorrect");
                arrayReference = 0;
            }
            else
            {
                names[arrayReference].money = Money;
                home.Close();
                StreamWriter output = new StreamWriter("Usernames.txt");
                for(int j = 0; j < 10; j++)
                {
                    string line = (names[j].name + "-" + names[j].password + "-" + names[j].money.ToString());
                    if(line[0] == '-')
                    {
                        break;
                    }
                    else
                    {
                        output.WriteLine(line);
                    }
                }
                output.Close();
                
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if((createTB.Text != "") && (createTB.Text == createCon.Text))
            {
                if((createPass.Text != "") && (createPass.Text == createPassCon.Text))
                {
                    names[count].name = createTB.Text;
                    names[count].password = createPass.Text;
                    names[count].money = 500;
                    MessageBox.Show("Account created, please log in");
                    createTB.Text = "";
                    createCon.Text = "";
                    createPass.Text = "";
                    createPassCon.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields entered correctly");
            }
        }
    }
}
