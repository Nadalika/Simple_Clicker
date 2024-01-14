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
            waluta_label.Text = string.Empty;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            waluta += ilosc;
            waluta_label.Text = waluta.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2Bought)
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (!pictureBox2Bought)
            {
                if (waluta >= 10)
                {
                    ilosc = 5;
                    waluta -= 10;
                    waluta_label.Text = waluta.ToString();
                }
                pictureBox2Bought = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3Bought)
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!pictureBox3Bought)
            {
                if (waluta >= 10)
                {
                    ilosc = 5;
                    waluta -= 10;
                    waluta_label.Text = waluta.ToString();
                }
                pictureBox3Bought = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4Bought)
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!pictureBox4Bought)
            {
                if (waluta >= 10)
                {
                    ilosc = 5;
                    waluta -= 10;
                    waluta_label.Text = waluta.ToString();
                }
                pictureBox4Bought = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7Bought)
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!pictureBox7Bought)
            {
                if (waluta >= 10)
                {
                    ilosc = 5;
                    waluta -= 10;
                    waluta_label.Text = waluta.ToString();
                }
                pictureBox7Bought = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6Bought)
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!pictureBox6Bought)
            {
                if (waluta >= 10)
                {
                    ilosc = 5;
                    waluta -= 10;
                    waluta_label.Text = waluta.ToString();
                }
                pictureBox6Bought = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5Bought)
            {
                MessageBox.Show("Nie można dokonać zakupu!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!pictureBox5Bought)
            {
                if (waluta >= 10)
                {
                    ilosc = 5;
                    waluta -= 10;
                    waluta_label.Text = waluta.ToString();
                }
                pictureBox5Bought = true;
            }
        }
    }
}
