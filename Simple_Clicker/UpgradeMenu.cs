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
        private Image[] upgradeImages = { Resources.Up1, Resources.Up2, Resources.Up4, Resources.Up3, Resources.Up5, Resources.Up6 };
        private PictureBox[] upgradePictureBoxes;
        private int walutaPerSecond = 0; // Aktualne naliczanie waluty na sekundę

        private Timer timer;

        public event EventHandler BackButtonClicked;
        public event EventHandler<int> WalutaUpdated;

        public UpgradeMenu()
        {
            InitializeComponent();
            InitializeTimer();
            upgradePictureBoxes = new PictureBox[] { up1PictureBox, up2PictureBox, up3PictureBox, up4PictureBox, up5PictureBox, up6PictureBox };
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
        }

        private void up2Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(1);
        }

        private void up3Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(2);
        }

        private void up4Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(3);
        }

        private void up5Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(4);
        }

        private void up6Btn_Click(object sender, EventArgs e)
        {
            BuyUpgrade(5);
        }

        private void BuyUpgrade(int upgradeIndex)
        {
            if (GameControl.Waluta >= upgradeCosts[upgradeIndex])
            {
                GameControl.Waluta -= upgradeCosts[upgradeIndex];
                upgradeLevels[upgradeIndex]++;
                walutaPerSecond += upgradeRates[upgradeIndex];
                upgradePictureBoxes[upgradeIndex].Image = upgradeImages[upgradeIndex];

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
