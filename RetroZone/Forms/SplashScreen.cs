using System;
using System.Windows.Forms;

namespace RetroZone.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            timerSplashScreen.Stop();
            this.Hide();
            Form formMain = new FormMain();
            formMain.Show();
        }
    }
}
