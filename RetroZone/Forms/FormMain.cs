using HttpClient;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Reflection;
using System.Windows.Forms;
using TabSystem.Tab;

namespace RetroZone.Forms
{
    public partial class FormMain : MaterialForm
    {
        private TabControlSystem tabControlSystem = null;
        public FormMain()
        {
            this.loadDependencies();
            InitializeComponent();
        }

        private void loadDependencies()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                Console.WriteLine(resourceName);
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };
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
        #endregion

        private void pictureBoxEditBrowser_Click(object sender, EventArgs e)
        {
            ApiCaller.GetAllHotels();
        }
    }
}
