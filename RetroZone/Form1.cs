using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser;
using DotNetBrowser.WinForms;

namespace RetroZone
{
    public partial class FormMain : Form
    {
        bool formMaximized = false;
        public BrowserView browserView;

        public FormMain()
        {
            BrowserPreferences.SetChromiumSwitches("--enable-npapi");

            InitializeComponent();
        }

        private void bunifuImageButtonClose_Click(object sender, EventArgs e)
        {
            browserView.Dispose();
            this.Close();
        }

        private void bunifuImageButtonNavigator_Click(object sender, EventArgs e)
        {
            browserView = new WinFormsBrowserView();
            browserView.Browser.CacheStorage.ClearCache(() =>
            {
                MessageBox.Show("Cache cleared ! :D <3");
            });
            this.pictureBoxHotelMainView.Visible = false;
            this.panelCenterMainActivity.Controls.Add((Control)browserView);
            browserView.Browser.LoadURL("http://51.38.184.88/cms");
            
        }

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
            if(this.formMaximized == true)
            {
                this.ResizableWindow();
            } else
            {
                this.MaximizeWindow();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            browserView.Dispose();
        }
    }
}
