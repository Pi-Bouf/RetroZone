namespace RetroZone.Forms
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
            this.panelRightMenu = new System.Windows.Forms.Panel();
            this.pictureBoxAboutBrowser = new System.Windows.Forms.PictureBox();
            this.pictureBoxEditBrowser = new System.Windows.Forms.PictureBox();
            this.pictureBoxHotelNavigator = new System.Windows.Forms.PictureBox();
            this.materialLabelUpdate = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBoxUpdateIndicator = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogoDuck = new System.Windows.Forms.PictureBox();
            this.pictureBoxHotelBackground = new System.Windows.Forms.PictureBox();
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.panelRightMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdateIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDuck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRightMenu
            // 
            this.panelRightMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRightMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.panelRightMenu.Controls.Add(this.pictureBoxAboutBrowser);
            this.panelRightMenu.Controls.Add(this.pictureBoxEditBrowser);
            this.panelRightMenu.Controls.Add(this.pictureBoxHotelNavigator);
            this.panelRightMenu.Location = new System.Drawing.Point(1188, 59);
            this.panelRightMenu.Name = "panelRightMenu";
            this.panelRightMenu.Size = new System.Drawing.Size(27, 672);
            this.panelRightMenu.TabIndex = 2;
            // 
            // pictureBoxAboutBrowser
            // 
            this.pictureBoxAboutBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAboutBrowser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAboutBrowser.Image")));
            this.pictureBoxAboutBrowser.Location = new System.Drawing.Point(7, 71);
            this.pictureBoxAboutBrowser.Name = "pictureBoxAboutBrowser";
            this.pictureBoxAboutBrowser.Size = new System.Drawing.Size(13, 17);
            this.pictureBoxAboutBrowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAboutBrowser.TabIndex = 3;
            this.pictureBoxAboutBrowser.TabStop = false;
            // 
            // pictureBoxEditBrowser
            // 
            this.pictureBoxEditBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEditBrowser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEditBrowser.Image")));
            this.pictureBoxEditBrowser.Location = new System.Drawing.Point(5, 38);
            this.pictureBoxEditBrowser.Name = "pictureBoxEditBrowser";
            this.pictureBoxEditBrowser.Size = new System.Drawing.Size(17, 17);
            this.pictureBoxEditBrowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEditBrowser.TabIndex = 3;
            this.pictureBoxEditBrowser.TabStop = false;
            this.pictureBoxEditBrowser.Click += new System.EventHandler(this.pictureBoxEditBrowser_Click);
            // 
            // pictureBoxHotelNavigator
            // 
            this.pictureBoxHotelNavigator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHotelNavigator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotelNavigator.Image")));
            this.pictureBoxHotelNavigator.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHotelNavigator.Name = "pictureBoxHotelNavigator";
            this.pictureBoxHotelNavigator.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxHotelNavigator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHotelNavigator.TabIndex = 4;
            this.pictureBoxHotelNavigator.TabStop = false;
            this.pictureBoxHotelNavigator.Click += new System.EventHandler(this.pictureBoxHotelNavigator_Click);
            // 
            // materialLabelUpdate
            // 
            this.materialLabelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelUpdate.AutoSize = true;
            this.materialLabelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelUpdate.Depth = 0;
            this.materialLabelUpdate.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelUpdate.FontSize = 11F;
            this.materialLabelUpdate.ForeColor = System.Drawing.Color.White;
            this.materialLabelUpdate.Location = new System.Drawing.Point(1073, 32);
            this.materialLabelUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelUpdate.Name = "materialLabelUpdate";
            this.materialLabelUpdate.Size = new System.Drawing.Size(96, 19);
            this.materialLabelUpdate.TabIndex = 4;
            this.materialLabelUpdate.Text = "New update !";
            // 
            // pictureBoxUpdateIndicator
            // 
            this.pictureBoxUpdateIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUpdateIndicator.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUpdateIndicator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpdateIndicator.Image")));
            this.pictureBoxUpdateIndicator.Location = new System.Drawing.Point(1168, 33);
            this.pictureBoxUpdateIndicator.Name = "pictureBoxUpdateIndicator";
            this.pictureBoxUpdateIndicator.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxUpdateIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUpdateIndicator.TabIndex = 5;
            this.pictureBoxUpdateIndicator.TabStop = false;
            // 
            // pictureBoxLogoDuck
            // 
            this.pictureBoxLogoDuck.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoDuck.Image = global::RetroZone.Properties.Resources.Duck;
            this.pictureBoxLogoDuck.Location = new System.Drawing.Point(12, 29);
            this.pictureBoxLogoDuck.Name = "pictureBoxLogoDuck";
            this.pictureBoxLogoDuck.Size = new System.Drawing.Size(23, 24);
            this.pictureBoxLogoDuck.TabIndex = 1;
            this.pictureBoxLogoDuck.TabStop = false;
            // 
            // pictureBoxHotelBackground
            // 
            this.pictureBoxHotelBackground.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxHotelBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHotelBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotelBackground.Image")));
            this.pictureBoxHotelBackground.Location = new System.Drawing.Point(185, 219);
            this.pictureBoxHotelBackground.Name = "pictureBoxHotelBackground";
            this.pictureBoxHotelBackground.Size = new System.Drawing.Size(849, 512);
            this.pictureBoxHotelBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHotelBackground.TabIndex = 6;
            this.pictureBoxHotelBackground.TabStop = false;
            // 
            // panelBrowser
            // 
            this.panelBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBrowser.BackColor = System.Drawing.Color.White;
            this.panelBrowser.Location = new System.Drawing.Point(1, 59);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(1188, 672);
            this.panelBrowser.TabIndex = 7;
            this.panelBrowser.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 732);
            this.Controls.Add(this.panelBrowser);
            this.Controls.Add(this.pictureBoxUpdateIndicator);
            this.Controls.Add(this.materialLabelUpdate);
            this.Controls.Add(this.pictureBoxLogoDuck);
            this.Controls.Add(this.panelRightMenu);
            this.Controls.Add(this.pictureBoxHotelBackground);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(763, 542);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RetroZone";
            this.TitleEnabled = true;
            this.TitleOffset = 30;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelRightMenu.ResumeLayout(false);
            this.panelRightMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAboutBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdateIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDuck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogoDuck;
        private System.Windows.Forms.Panel panelRightMenu;
        private System.Windows.Forms.PictureBox pictureBoxEditBrowser;
        private System.Windows.Forms.PictureBox pictureBoxHotelNavigator;
        private System.Windows.Forms.PictureBox pictureBoxAboutBrowser;
        private MaterialSkin.Controls.MaterialLabel materialLabelUpdate;
        private System.Windows.Forms.PictureBox pictureBoxUpdateIndicator;
        private System.Windows.Forms.PictureBox pictureBoxHotelBackground;
        private System.Windows.Forms.Panel panelBrowser;
    }
}

