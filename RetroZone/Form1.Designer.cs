namespace RetroZone
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bunifuImageButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBoxLogoDuck = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabelMainTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelCenterMainActivity = new System.Windows.Forms.Panel();
            this.pictureBoxNavigator = new System.Windows.Forms.PictureBox();
            this.pictureBoxHotelMainView = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.panelLeftMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDuck)).BeginInit();
            this.panelCenterMainActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelMainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelLeftMenu.Controls.Add(this.pictureBoxSettings);
            this.panelLeftMenu.Controls.Add(this.pictureBoxNavigator);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 33);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(55, 667);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(184)))), ((int)(((byte)(238)))));
            this.panelTop.Controls.Add(this.bunifuImageButtonClose);
            this.panelTop.Controls.Add(this.pictureBoxLogoDuck);
            this.panelTop.Controls.Add(this.bunifuCustomLabelMainTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 33);
            this.panelTop.TabIndex = 1;
            this.panelTop.DoubleClick += new System.EventHandler(this.panelTop_DoubleClick);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // bunifuImageButtonClose
            // 
            this.bunifuImageButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonClose.Image = global::RetroZone.Properties.Resources.cancel;
            this.bunifuImageButtonClose.ImageActive = null;
            this.bunifuImageButtonClose.Location = new System.Drawing.Point(1273, 9);
            this.bunifuImageButtonClose.Name = "bunifuImageButtonClose";
            this.bunifuImageButtonClose.Size = new System.Drawing.Size(15, 15);
            this.bunifuImageButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonClose.TabIndex = 2;
            this.bunifuImageButtonClose.TabStop = false;
            this.bunifuImageButtonClose.Zoom = 10;
            this.bunifuImageButtonClose.Click += new System.EventHandler(this.bunifuImageButtonClose_Click);
            // 
            // pictureBoxLogoDuck
            // 
            this.pictureBoxLogoDuck.Image = global::RetroZone.Properties.Resources.Duck;
            this.pictureBoxLogoDuck.Location = new System.Drawing.Point(16, 4);
            this.pictureBoxLogoDuck.Name = "pictureBoxLogoDuck";
            this.pictureBoxLogoDuck.Size = new System.Drawing.Size(23, 25);
            this.pictureBoxLogoDuck.TabIndex = 0;
            this.pictureBoxLogoDuck.TabStop = false;
            // 
            // bunifuCustomLabelMainTitle
            // 
            this.bunifuCustomLabelMainTitle.AutoSize = true;
            this.bunifuCustomLabelMainTitle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelMainTitle.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelMainTitle.Location = new System.Drawing.Point(49, 6);
            this.bunifuCustomLabelMainTitle.Name = "bunifuCustomLabelMainTitle";
            this.bunifuCustomLabelMainTitle.Size = new System.Drawing.Size(92, 18);
            this.bunifuCustomLabelMainTitle.TabIndex = 1;
            this.bunifuCustomLabelMainTitle.Text = "Retro Zone";
            // 
            // panelCenterMainActivity
            // 
            this.panelCenterMainActivity.Controls.Add(this.pictureBoxHotelMainView);
            this.panelCenterMainActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterMainActivity.Location = new System.Drawing.Point(55, 33);
            this.panelCenterMainActivity.Name = "panelCenterMainActivity";
            this.panelCenterMainActivity.Size = new System.Drawing.Size(1245, 667);
            this.panelCenterMainActivity.TabIndex = 2;
            // 
            // pictureBoxNavigator
            // 
            this.pictureBoxNavigator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNavigator.Image = global::RetroZone.Properties.Resources.UINavigator;
            this.pictureBoxNavigator.Location = new System.Drawing.Point(12, 15);
            this.pictureBoxNavigator.Name = "pictureBoxNavigator";
            this.pictureBoxNavigator.Size = new System.Drawing.Size(31, 44);
            this.pictureBoxNavigator.TabIndex = 1;
            this.pictureBoxNavigator.TabStop = false;
            this.pictureBoxNavigator.Click += new System.EventHandler(this.pictureBoxNavigator_Click);
            // 
            // pictureBoxHotelMainView
            // 
            this.pictureBoxHotelMainView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxHotelMainView.Image = global::RetroZone.Properties.Resources.HotelBackground;
            this.pictureBoxHotelMainView.InitialImage = global::RetroZone.Properties.Resources.HotelBackground;
            this.pictureBoxHotelMainView.Location = new System.Drawing.Point(211, 161);
            this.pictureBoxHotelMainView.Name = "pictureBoxHotelMainView";
            this.pictureBoxHotelMainView.Size = new System.Drawing.Size(849, 512);
            this.pictureBoxHotelMainView.TabIndex = 0;
            this.pictureBoxHotelMainView.TabStop = false;
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Image = global::RetroZone.Properties.Resources.UISettings;
            this.pictureBoxSettings.Location = new System.Drawing.Point(9, 78);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(36, 45);
            this.pictureBoxSettings.TabIndex = 2;
            this.pictureBoxSettings.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panelCenterMainActivity);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDuck)).EndInit();
            this.panelCenterMainActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelMainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenterMainActivity;
        private System.Windows.Forms.PictureBox pictureBoxHotelMainView;
        private System.Windows.Forms.PictureBox pictureBoxLogoDuck;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelMainTitle;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonClose;
        private System.Windows.Forms.PictureBox pictureBoxNavigator;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
    }
}

