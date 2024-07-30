using System;
using System.Windows.Forms;

namespace SteamedHamsLauncher
{
    public partial class FrmJumpscare : Form
    {
        private Timer closeTimer;

        public FrmJumpscare()
        {
            InitializeComponent();
        }

        private void FrmJumpscare_Load(object sender, EventArgs e)
        {
            // Initialisiere den Timer
            closeTimer = new Timer();
            closeTimer.Interval = 10000; // 30 Sekunden in Millisekunden
            closeTimer.Tick += CloseTimer_Tick;
            closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            // Stoppe den Timer und schließe die Anwendung
            closeTimer.Stop();
            Application.Exit();
        }

        private void pbxJumpscare_Click(object sender, EventArgs e)
        {

        }
    }
}
