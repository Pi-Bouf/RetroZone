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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.bunifuImageButtonNavigator = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bunifuImageButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabelMainTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCenterMainActivity = new System.Windows.Forms.Panel();
            this.pictureBoxHotelMainView = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonNavigator)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCenterMainActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelLeftMenu.Controls.Add(this.bunifuImageButtonNavigator);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 30);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(46, 670);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // bunifuImageButtonNavigator
            // 
            this.bunifuImageButtonNavigator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonNavigator.Image = global::RetroZone.Properties.Resources.v22_1;
            this.bunifuImageButtonNavigator.ImageActive = null;
            this.bunifuImageButtonNavigator.Location = new System.Drawing.Point(7, 23);
            this.bunifuImageButtonNavigator.Name = "bunifuImageButtonNavigator";
            this.bunifuImageButtonNavigator.Size = new System.Drawing.Size(33, 36);
            this.bunifuImageButtonNavigator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonNavigator.TabIndex = 1;
            this.bunifuImageButtonNavigator.TabStop = false;
            this.bunifuImageButtonNavigator.Zoom = 10;
            this.bunifuImageButtonNavigator.Click += new System.EventHandler(this.bunifuImageButtonNavigator_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(184)))), ((int)(((byte)(238)))));
            this.panelTop.Controls.Add(this.bunifuImageButtonClose);
            this.panelTop.Controls.Add(this.bunifuCustomLabelMainTitle);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 30);
            this.panelTop.TabIndex = 1;
            this.panelTop.DoubleClick += new System.EventHandler(this.panelTop_DoubleClick);
            // 
            // bunifuImageButtonClose
            // 
            this.bunifuImageButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonClose.Image = global::RetroZone.Properties.Resources.cancel;
            this.bunifuImageButtonClose.ImageActive = null;
            this.bunifuImageButtonClose.Location = new System.Drawing.Point(1273, 8);
            this.bunifuImageButtonClose.Name = "bunifuImageButtonClose";
            this.bunifuImageButtonClose.Size = new System.Drawing.Size(15, 15);
            this.bunifuImageButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonClose.TabIndex = 2;
            this.bunifuImageButtonClose.TabStop = false;
            this.bunifuImageButtonClose.Zoom = 10;
            this.bunifuImageButtonClose.Click += new System.EventHandler(this.bunifuImageButtonClose_Click);
            // 
            // bunifuCustomLabelMainTitle
            // 
            this.bunifuCustomLabelMainTitle.AutoSize = true;
            this.bunifuCustomLabelMainTitle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelMainTitle.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelMainTitle.Location = new System.Drawing.Point(36, 6);
            this.bunifuCustomLabelMainTitle.Name = "bunifuCustomLabelMainTitle";
            this.bunifuCustomLabelMainTitle.Size = new System.Drawing.Size(92, 18);
            this.bunifuCustomLabelMainTitle.TabIndex = 1;
            this.bunifuCustomLabelMainTitle.Text = "Retro Zone";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RetroZone.Properties.Resources.tools_stickers;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCenterMainActivity
            // 
            this.panelCenterMainActivity.Controls.Add(this.pictureBoxHotelMainView);
            this.panelCenterMainActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterMainActivity.Location = new System.Drawing.Point(46, 30);
            this.panelCenterMainActivity.Name = "panelCenterMainActivity";
            this.panelCenterMainActivity.Size = new System.Drawing.Size(1254, 670);
            this.panelCenterMainActivity.TabIndex = 2;
            // 
            // pictureBoxHotelMainView
            // 
            this.pictureBoxHotelMainView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxHotelMainView.Image = global::RetroZone.Properties.Resources.hotel_ba57eb56;
            this.pictureBoxHotelMainView.Location = new System.Drawing.Point(216, 155);
            this.pictureBoxHotelMainView.Name = "pictureBoxHotelMainView";
            this.pictureBoxHotelMainView.Size = new System.Drawing.Size(849, 512);
            this.pictureBoxHotelMainView.TabIndex = 0;
            this.pictureBoxHotelMainView.TabStop = false;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelTop;
            this.bunifuDragControl.Vertical = true;
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
            this.panelLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonNavigator)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCenterMainActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenterMainActivity;
        private System.Windows.Forms.PictureBox pictureBoxHotelMainView;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonNavigator;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelMainTitle;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonClose;
    }
}

