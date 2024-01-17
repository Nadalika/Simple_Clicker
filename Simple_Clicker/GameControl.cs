using Simple_Clicker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Clicker
{
    public partial class GameControl : UserControl
    {
        public static int Waluta { get; set; } = 0;
        public int ilosc = 1;
        private bool mousePressed = false;
        public bool pictureBox2Bought = false;
        public bool pictureBox3Bought = false;
        public bool pictureBox4Bought = false;
        public bool pictureBox7Bought = false;
        public bool pictureBox6Bought = false;
        public bool pictureBox5Bought = false;

        public event EventHandler UpgradeMenuClicked;
        public event EventHandler CreditsMenuClicked;

        public GameControl()
        {
            InitializeComponent();
            Waluta = GameStateManager.Instance.CollectedResources;
            waluta_label.Text = "Waluta: " + Waluta.ToString();
            label1.Text = "Koszt zakupu: 10 \n Klik = 5";
            label2.Text = "Koszt zakupu: 100 \n Klik = 15";
            label3.Text = "Koszt zakupu: 500 \n Klik = 25";
            label4.Text = "Koszt zakupu: 1000 \n Klik = 50";
            label5.Text = "Koszt zakupu: 2000 \n Klik = 75";
            label6.Text = "Koszt zakupu: 4000 \n Klik = 110";

            pictureBox1.MouseDown += pictureBox1_MouseDown;

        }

        public Label WalutaLabel
        {
            get { return waluta_label; }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !mousePressed)
            {
                mousePressed = true;
                Waluta += ilosc;
                GameStateManager.Instance.CollectedResources = Waluta;
                waluta_label.Text = "Waluta:" + Waluta.ToString();
                pictureBox1.Image = Resources._68308_click;
                pictureBox1.Size = new Size(130, 121);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
            pictureBox1.Image = Resources._68308;
            pictureBox1.Size = new Size(189, 176);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Waluta >= 10)
            {

                if (pictureBox2Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox2Bought)
                {
                    ilosc = 5;
                    Waluta -= 10;
                    waluta_label.Text = "Waluta: " + Waluta.ToString();
                    pictureBox2Bought = true;
                    pictureBox2.Image = Properties.Resources.Yellow_crystal1;
                }
            }
            else
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Waluta >= 100)
            {

                if (pictureBox3Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox3Bought)
                {
                    ilosc = 15;
                    Waluta -= 100;
                    waluta_label.Text = "Waluta: " + Waluta.ToString();
                    pictureBox3Bought = true;
                    pictureBox3.Image = Properties.Resources.Red_crystal1;
                }
            }
            else
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Waluta >= 500)
            {

                if (pictureBox4Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox4Bought)
                {
                    ilosc = 25;
                    Waluta -= 500;
                    waluta_label.Text = "Waluta: " + Waluta.ToString();
                    pictureBox4Bought = true;
                    pictureBox4.Image = Properties.Resources.Pink_crystal1;
                }
            }
            else
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Waluta >= 1000)
            {


                if (pictureBox7Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox7Bought)
                {
                    ilosc = 50;
                    Waluta -= 1000;
                    waluta_label.Text = "Waluta: " + Waluta.ToString();
                    pictureBox7Bought = true;
                    pictureBox7.Image = Properties.Resources.Black_crystal1;
                }
            }
            else
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Waluta >= 2000)
            {
                if (pictureBox6Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox6Bought)
                {
                    ilosc = 75;
                    Waluta -= 2000;
                    waluta_label.Text = "Waluta: " + Waluta.ToString();
                    pictureBox6Bought = true;
                    pictureBox6.Image = Properties.Resources.Violet_crystal1;
                }
            }
            else
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Waluta >= 4000)
            {
                if (pictureBox5Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox5Bought)
                {
                    ilosc = 110;
                    Waluta -= 4000;
                    waluta_label.Text = "Waluta: " + Waluta.ToString();
                    pictureBox5Bought = true;
                    pictureBox5.Image = Properties.Resources.White_crystal1;
                }
            }
            else
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpgradeMenuClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditsMenuClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
