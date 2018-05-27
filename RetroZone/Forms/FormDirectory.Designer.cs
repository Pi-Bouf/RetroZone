namespace RetroZone.Forms
{
    partial class FormDirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxHotels = new System.Windows.Forms.ListBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bunifuImageButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBoxLogoDuck = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabelMainTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDuck)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxHotels
            // 
            this.listBoxHotels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.listBoxHotels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHotels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxHotels.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.listBoxHotels.ForeColor = System.Drawing.Color.White;
            this.listBoxHotels.FormattingEnabled = true;
            this.listBoxHotels.ItemHeight = 20;
            this.listBoxHotels.Items.AddRange(new object[] {
            "Hey",
            "Coucou",
            "Salut"});
            this.listBoxHotels.Location = new System.Drawing.Point(0, 33);
            this.listBoxHotels.Name = "listBoxHotels";
            this.listBoxHotels.Size = new System.Drawing.Size(624, 320);
            this.listBoxHotels.TabIndex = 0;
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
            this.panelTop.Size = new System.Drawing.Size(624, 33);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // bunifuImageButtonClose
            // 
            this.bunifuImageButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonClose.Image = global::RetroZone.Properties.Resources.cancel;
            this.bunifuImageButtonClose.ImageActive = null;
            this.bunifuImageButtonClose.Location = new System.Drawing.Point(597, 9);
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
            // FormDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(624, 353);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.listBoxHotels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDirectory";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDuck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHotels;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonClose;
        private System.Windows.Forms.PictureBox pictureBoxLogoDuck;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelMainTitle;
    }
}