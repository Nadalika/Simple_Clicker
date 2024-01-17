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
        private GameControl gameControl;
        private UpgradeMenu upgradeMenu;

        

        public Form1()
        {
            InitializeComponent();
            gameControl = new GameControl();
            gameControl.UpgradeMenuClicked += GameControl_UpgradeMenuClicked;
            gameControl.Dock = DockStyle.Fill;
            Controls.Add(gameControl);

            // Inicjalizacja kontrolki menu ulepszeń
            upgradeMenu = new UpgradeMenu();
            upgradeMenu.BackButtonClicked += UpgradeMenu_BackButtonClicked;
            upgradeMenu.Dock = DockStyle.Fill;
            Controls.Add(upgradeMenu);

            upgradeMenu.WalutaUpdated += UpgradeMenu_WalutaUpdated;
        }       

        private void GameControl_UpgradeMenuClicked(object sender, EventArgs e)
        {
            gameControl.Visible = false;
            upgradeMenu.Visible = true;
        }

        private void UpgradeMenu_BackButtonClicked( object sender, EventArgs e)
        {
            upgradeMenu.Visible = false;
            gameControl.Visible = true;
        }

        private void UpgradeMenu_WalutaUpdated(object sender, int totalWaluta)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => gameControl.WalutaLabel.Text = "Waluta:" + totalWaluta.ToString()));
            }
            else
            {
                gameControl.WalutaLabel.Text = "Waluta:" + totalWaluta.ToString();
            }
        }


    }
}
