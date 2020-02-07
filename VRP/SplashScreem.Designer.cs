namespace VRP
{
    partial class SplashScreem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCopyright = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImage = global::VRP.Properties.Resources.VRP_hyvanrakentaja2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.textBoxCopyright);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 322);
            this.panel1.TabIndex = 0;
            // 
            // textBoxCopyright
            // 
            this.textBoxCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxCopyright.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCopyright.Location = new System.Drawing.Point(0, 303);
            this.textBoxCopyright.Name = "textBoxCopyright";
            this.textBoxCopyright.Size = new System.Drawing.Size(629, 19);
            this.textBoxCopyright.TabIndex = 0;
            this.textBoxCopyright.Text = "©2020 Aleksi Puttonen All Rights Reserved";
            this.textBoxCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCopyright.TextChanged += new System.EventHandler(this.textBoxCopyright_TextChanged);
            // 
            // SplashScreem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 322);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreem";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCopyright;
    }
}