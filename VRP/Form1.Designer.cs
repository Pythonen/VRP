namespace VRP
{
    partial class Vuokratut
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
            System.Windows.Forms.Button buttonPoistu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vuokratut));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelVari = new System.Windows.Forms.Panel();
            this.buttonLisaaTyokalu = new System.Windows.Forms.Button();
            this.buttonKaksi = new System.Windows.Forms.Button();
            this.buttonYksi = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelVittu = new System.Windows.Forms.Panel();
            buttonPoistu = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.panelSideMenu.Controls.Add(this.panelVittu);
            this.panelSideMenu.Controls.Add(this.buttonLisaaTyokalu);
            this.panelSideMenu.Controls.Add(this.panelVari);
            this.panelSideMenu.Controls.Add(this.buttonKaksi);
            this.panelSideMenu.Controls.Add(this.buttonYksi);
            this.panelSideMenu.Controls.Add(this.pictureBoxLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 540);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelVari
            // 
            this.panelVari.BackColor = System.Drawing.Color.White;
            this.panelVari.Location = new System.Drawing.Point(193, 100);
            this.panelVari.Name = "panelVari";
            this.panelVari.Size = new System.Drawing.Size(7, 97);
            this.panelVari.TabIndex = 4;
            // 
            // buttonPoistu
            // 
            buttonPoistu.BackgroundImage = global::VRP.Properties.Resources.cancel;
            buttonPoistu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonPoistu.FlatAppearance.BorderSize = 0;
            buttonPoistu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPoistu.Location = new System.Drawing.Point(764, 0);
            buttonPoistu.Name = "buttonPoistu";
            buttonPoistu.Size = new System.Drawing.Size(47, 41);
            buttonPoistu.TabIndex = 1;
            buttonPoistu.UseVisualStyleBackColor = true;
            buttonPoistu.Click += new System.EventHandler(this.buttonPoistu_Click);
            // 
            // buttonLisaaTyokalu
            // 
            this.buttonLisaaTyokalu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLisaaTyokalu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLisaaTyokalu.FlatAppearance.BorderSize = 0;
            this.buttonLisaaTyokalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLisaaTyokalu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLisaaTyokalu.Image = global::VRP.Properties.Resources.plus;
            this.buttonLisaaTyokalu.Location = new System.Drawing.Point(0, 294);
            this.buttonLisaaTyokalu.Name = "buttonLisaaTyokalu";
            this.buttonLisaaTyokalu.Size = new System.Drawing.Size(200, 97);
            this.buttonLisaaTyokalu.TabIndex = 3;
            this.buttonLisaaTyokalu.Text = "LISÄÄ VUOKRATTU VÄLINE";
            this.buttonLisaaTyokalu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLisaaTyokalu.UseVisualStyleBackColor = true;
            this.buttonLisaaTyokalu.Click += new System.EventHandler(this.buttonLisaaTyokalu_Click);
            // 
            // buttonKaksi
            // 
            this.buttonKaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKaksi.FlatAppearance.BorderSize = 0;
            this.buttonKaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaksi.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKaksi.Image = global::VRP.Properties.Resources.clock;
            this.buttonKaksi.Location = new System.Drawing.Point(0, 197);
            this.buttonKaksi.Name = "buttonKaksi";
            this.buttonKaksi.Size = new System.Drawing.Size(200, 97);
            this.buttonKaksi.TabIndex = 2;
            this.buttonKaksi.Text = "YLI VIIKON VANHAT VUOKRAUKSET";
            this.buttonKaksi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKaksi.UseVisualStyleBackColor = true;
            this.buttonKaksi.Click += new System.EventHandler(this.buttonKaksi_Click);
            // 
            // buttonYksi
            // 
            this.buttonYksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonYksi.FlatAppearance.BorderSize = 0;
            this.buttonYksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYksi.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYksi.Image = global::VRP.Properties.Resources.tools_cross_settings_symbol_for_interface__1_;
            this.buttonYksi.Location = new System.Drawing.Point(0, 100);
            this.buttonYksi.Name = "buttonYksi";
            this.buttonYksi.Size = new System.Drawing.Size(200, 97);
            this.buttonYksi.TabIndex = 1;
            this.buttonYksi.Text = "VUOKRATUT";
            this.buttonYksi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonYksi.UseVisualStyleBackColor = true;
            this.buttonYksi.Click += new System.EventHandler(this.buttonYksi_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::VRP.Properties.Resources.VRP_hyvanrakentajanovittunyt;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelVittu
            // 
            this.panelVittu.BackColor = System.Drawing.Color.White;
            this.panelVittu.Location = new System.Drawing.Point(193, 294);
            this.panelVittu.Name = "panelVittu";
            this.panelVittu.Size = new System.Drawing.Size(7, 97);
            this.panelVittu.TabIndex = 5;
            // 
            // Vuokratut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 540);
            this.Controls.Add(buttonPoistu);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vuokratut";
            this.Text = "Vuokratut";
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonYksi;
        private System.Windows.Forms.Panel panelVari;
        private System.Windows.Forms.Button buttonKaksi;
        private System.Windows.Forms.Button buttonLisaaTyokalu;
        private System.Windows.Forms.Panel panelVittu;
    }
}

