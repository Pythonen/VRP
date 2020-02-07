using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRP
{
    public partial class Vuokratut : Form
    {
        public Vuokratut()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            t.Abort();
            panelVari.Height = buttonYksi.Height;
            panelVari.Top = buttonYksi.Top;
            panelVittu.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
        private void buttonLisaaTyokalu_Click(object sender, EventArgs e)
        {
            panelVari.Top = buttonLisaaTyokalu.Top;
            panelVari.Height = buttonLisaaTyokalu.Height;
            panelVittu.Show();
        }

        private void buttonYksi_Click(object sender, EventArgs e)
        {
            panelVari.Height = buttonYksi.Height;
            panelVari.Top = buttonYksi.Top;
            panelVittu.Hide();
        }

        private void buttonKaksi_Click(object sender, EventArgs e)
        {
            panelVari.Height = buttonKaksi.Height;
            panelVari.Top = buttonKaksi.Top;
            panelVittu.Hide();
        }

        
        private void buttonPoistu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreem());
        }
    }
}
