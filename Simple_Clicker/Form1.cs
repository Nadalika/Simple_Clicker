using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Clicker
{
    public partial class Form1 : Form
    {

        int waluta = 0;
        int ilosc = 1;
        public bool pictureBox2Bought = false;
        public bool pictureBox3Bought = false;
        public bool pictureBox4Bought = false;
        public bool pictureBox7Bought = false;
        public bool pictureBox6Bought = false;
        public bool pictureBox5Bought = false;

        public Form1()
        {
            InitializeComponent();
            waluta_label.Text = "Waluta: " + waluta.ToString();
            label1.Text = "Koszt zakupu: 10 \n Klik = 5";
            label2.Text = "Koszt zakupu: 100 \n Klik = 15";
            label3.Text = "Koszt zakupu: 500 \n Klik = 25";
            label4.Text = "Koszt zakupu: 1000 \n Klik = 50";
            label5.Text = "Koszt zakupu: 2000 \n Klik = 75";
            label6.Text = "Koszt zakupu: 4000 \n Klik = 110";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            waluta += ilosc;
            waluta_label.Text = "Waluta:" + waluta.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (waluta >= 10)
            {

                if (pictureBox2Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox2Bought)
                {
                    ilosc = 5;
                    waluta -= 10;
                    waluta_label.Text = "Waluta: " + waluta.ToString();
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
            if (waluta >= 100)
            {

                 if (pictureBox3Bought)
                 {
                       MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 }
                 else if (!pictureBox3Bought)
                 {
                     ilosc = 15;
                     waluta -= 100;
                     waluta_label.Text = "Waluta: " + waluta.ToString();
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
            if (waluta >= 500)
            {

                if (pictureBox4Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox4Bought)
                {
                    ilosc = 25;
                    waluta -= 500;
                    waluta_label.Text = "Waluta: " + waluta.ToString();
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
            if (waluta >= 1000)
            {


                if (pictureBox7Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox7Bought)
                {
                    ilosc = 50;
                    waluta -= 1000;
                    waluta_label.Text = "Waluta: " + waluta.ToString();
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
            if (waluta >= 2000)
            {
                if (pictureBox6Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox6Bought)
                {
                    ilosc = 75;
                    waluta -= 2000;
                    waluta_label.Text = "Waluta: " + waluta.ToString();
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
            if (waluta >= 4000)
            {
                if (pictureBox5Bought)
                {
                    MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!pictureBox5Bought)
                {
                    ilosc = 110;
                    waluta -= 4000;
                    waluta_label.Text = "Waluta: " + waluta.ToString();
                    pictureBox5Bought = true;
                    pictureBox5.Image = Properties.Resources.White_crystal1;
                }
            }
        }
    }
}
