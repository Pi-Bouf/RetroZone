using System;
using System.Drawing;
using System.Windows.Forms;
using TabSystem.Tab;

namespace RetroZone
{
    public partial class FormMain : Form
    {

        private TabControlSystem tabControlSystem = null;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private bool formMaximized = false;

        public FormMain()
        {
            InitializeComponent();
        }

        #region Web browser (Noot to rewrite)
        private void FormMain_Shown(object sender, EventArgs e)
        {
            MaximizeWindow();
            tabControlSystem = new TabControlSystem(this.panelCenterMainActivity);
            tabControlSystem.newTabRequest("http://forum.ragezone.com/f353/", "Welcome");
            this.pictureBoxHotelMainView.Visible = false;
        }

        private void pictureBoxNavigator_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.tabControlSystem != null)
            {
                tabControlSystem.disposeTabControlSystem();
            }
        }
        #endregion

        #region Panel top event (Maximize, minimize, drag,...)

        private void MaximizeWindow()
        {
            var rectangle = Screen.FromControl(this).Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            Size = new Size(rectangle.Width, rectangle.Height);
            Location = new Point(0, 0);
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
            this.formMaximized = true;
        }

        private void ResizableWindow()
        {
            this.Size = new Size(1300, 700);
            this.CenterToScreen();
            this.formMaximized = false;
        }

        private void panelTop_DoubleClick(object sender, EventArgs e)
        {
            if (this.formMaximized == true)
            {
                this.ResizableWindow();
            }
            else
            {
                this.MaximizeWindow();
            }
        }

        private void bunifuImageButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
}
