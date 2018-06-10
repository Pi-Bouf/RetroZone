using HttpClient;
using HttpClient.Entity;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using TabSystem.Tab;

namespace RetroZone.Forms
{
    public partial class FormMain : MaterialForm
    {
        private TabControlSystem tabControlSystem = null;
        private bool needUpdate = false;

        public FormMain()
        {
            InitializeComponent();
            checkUpdate();
        }

        #region Form Event
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(MaterialSkin.Primary.Green400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green100, Accent.Blue200, TextShade.WHITE);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.tabControlSystem != null)
            {
                tabControlSystem.disposeTabControlSystem();
            }
            System.Environment.Exit(1);
        }

        private void pictureBoxHotelNavigator_Click(object sender, System.EventArgs e)
        {
            if(this.needUpdate == true)
            {
                MessageBox.Show("Sorry, you can't use this version. Please, update on top right corner ! ;)");
                return;
            }

            if(this.tabControlSystem == null)
            {
                this.panelBrowser.Visible = true;
                tabControlSystem = new TabControlSystem(this.panelBrowser);
                tabControlSystem.newTabRequest("http://forum.ragezone.com/f353/", "Welcome");
                this.pictureBoxHotelBackground.Visible = false;

            } else
            {

            }
        }

        private async void pictureBoxEditBrowser_Click(object sender, EventArgs e)
        {
            List<Hotel> hotels = await ApiCaller.GetAllHotels();
            Console.WriteLine(hotels);
        }
        #endregion

        #region Update system
        public async void checkUpdate()
        {
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += async delegate
            {
                timer.Stop();
                HttpClient.Entity.Version version = await ApiCaller.checkVersion();
                if(version.lastUpdate != ApiCaller.APIVersion)
                {
                    materialLabelUpdate.Location = new Point(1050, 32);
                    materialLabelUpdate.Visible = true;
                    
                    pictureBoxUpdateIndicator.Visible = true;
                    materialLabelUpdate.Text = "Click to update !";
                    materialLabelUpdate.Click += delegate
                    {
                        if (File.Exists("RetroZone-Updater.exe"))
                        {
                            Process.Start("RetroZone-Updater.exe");
                        }
                    };
                }
                if(version.authorized != true)
                {
                    this.needUpdate = true;
                    if (this.tabControlSystem != null)
                    {
                        this.tabControlSystem.disposeTabControlSystem();
                        this.panelBrowser.Visible = false;
                        this.pictureBoxHotelBackground.Visible = true;
                        MessageBox.Show("Sorry, you can't use this version. Please, update on top right corner ! ;)");
                    }
                }
            };
            timer.Start();
        }
        #endregion
    }
}
