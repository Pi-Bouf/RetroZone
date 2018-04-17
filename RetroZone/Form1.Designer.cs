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
            this.bunifuElipseMainFrame = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenterMainActivity = new System.Windows.Forms.Panel();
            this.pictureBoxHotelMainView = new System.Windows.Forms.PictureBox();
            this.panelCenterMainActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipseMainFrame
            // 
            this.bunifuElipseMainFrame.ElipseRadius = 5;
            this.bunifuElipseMainFrame.TargetControl = this;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 36);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(211, 616);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(184)))), ((int)(((byte)(238)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1232, 36);
            this.panelTop.TabIndex = 1;
            // 
            // panelCenterMainActivity
            // 
            this.panelCenterMainActivity.Controls.Add(this.pictureBoxHotelMainView);
            this.panelCenterMainActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterMainActivity.Location = new System.Drawing.Point(211, 36);
            this.panelCenterMainActivity.Name = "panelCenterMainActivity";
            this.panelCenterMainActivity.Size = new System.Drawing.Size(1021, 616);
            this.panelCenterMainActivity.TabIndex = 2;
            // 
            // pictureBoxHotelMainView
            // 
            this.pictureBoxHotelMainView.Image = global::RetroZone.Properties.Resources.hotel_ba57eb56;
            this.pictureBoxHotelMainView.Location = new System.Drawing.Point(0, 104);
            this.pictureBoxHotelMainView.Name = "pictureBoxHotelMainView";
            this.pictureBoxHotelMainView.Size = new System.Drawing.Size(849, 512);
            this.pictureBoxHotelMainView.TabIndex = 0;
            this.pictureBoxHotelMainView.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1232, 652);
            this.Controls.Add(this.panelCenterMainActivity);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelCenterMainActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipseMainFrame;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenterMainActivity;
        private System.Windows.Forms.PictureBox pictureBoxHotelMainView;
    }
}

