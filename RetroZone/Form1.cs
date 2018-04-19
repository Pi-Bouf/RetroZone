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
        //public BrowserView browserView = new WinFormsBrowserView();

        public FormMain()
        {
            InitializeComponent();
        }

        private void bunifuImageButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButtonNavigator_Click(object sender, EventArgs e)
        {
            /*
            this.pictureBoxHotelMainView.Visible = false;
            this.panelCenterMainActivity.Controls.Add((Control)browserView);
            browserView.Browser.LoadURL("http://google.fr");
            */
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
    }
}
