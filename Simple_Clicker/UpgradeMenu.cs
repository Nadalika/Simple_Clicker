using Simple_Clicker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Clicker
{
    public partial class UpgradeMenu : UserControl
    {
        private int[] upgradeCosts = { 500, 1000, 1500, 2000, 2500, 3000 }; // Koszty ulepszeń
        private int[] upgradeRates = { 2, 2, 4, 8, 16, 32 }; // Naliczanie waluty na sekundę
        private int[] upgradeLevels = { 0, 0, 0, 0, 0, 0 }; // Poziomy zakupionych ulepszeń
        private int walutaPerSecond = 0; // Aktualne naliczanie waluty na sekundę

        private Timer timer;

        public event EventHandler BackButtonClicked;
        public event EventHandler<int> WalutaUpdated;

        public UpgradeMenu()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Co sekundę
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int totalWaluta = 0;

            for (int i = 0; i < upgradeLevels.Length; i++)
            {
                totalWaluta += upgradeRates[i] * upgradeLevels[i];
            }

            GameControl.Waluta += totalWaluta;

            // Wywołaj zdarzenie, aby zaktualizować interfejs użytkownika
            WalutaUpdated?.Invoke(this, GameControl.Waluta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void up1Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(0);
            up1PictureBox.Image = Resources.Up1;
        }

        private void up2Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(1);
            up2PictureBox.Image = Resources.Up2;
        }

        private void up3Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(2);
            up3PictureBox.Image = Resources.Up4;
        }

        private void up4Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(3);
            up4PictureBox.Image = Resources.Up3;
        }

        private void up5Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(4);
            up5PictureBox.Image = Resources.Up5;
        }

        private void up6Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(5);
            up6PictureBox.Image = Resources.Up6;
        }

        private void BuyUpgrade(int upgradeIndex)
        {
            if (GameControl.Waluta >= upgradeCosts[upgradeIndex])
            {
                GameControl.Waluta -= upgradeCosts[upgradeIndex];
                upgradeLevels[upgradeIndex]++;
                walutaPerSecond += upgradeRates[upgradeIndex];

                // Wywołaj zdarzenie, aby zaktualizować interfejs użytkownika
                WalutaUpdated?.Invoke(this, GameControl.Waluta);
            }
            else
            {
                MessageBox.Show("Nie można dokonać zakupu ulepszenia!", "OKNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
