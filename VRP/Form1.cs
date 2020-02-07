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
using System.Data.SqlClient;

namespace VRP
{
    public partial class Vuokratut : Form
    {
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\tämäkohtauudestaankokonaan;Integrated Security=True;Connect Timeout=30");
        public Vuokratut()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            t.Abort();
            panelVari.Height = buttonYksi.Height;
            panelVari.Top = buttonYksi.Top;
            panelVari2.Hide();
            panelLisaaTyovaline.Hide();
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
            panelVari2.Show();
            panelLisaaTyovaline.Show();
            
        }

        private void buttonYksi_Click(object sender, EventArgs e)
        {
            panelVari.Height = buttonYksi.Height;
            panelVari.Top = buttonYksi.Top;
            panelVari2.Hide();
            panelLisaaTyovaline.Hide();
        }

        private void buttonKaksi_Click(object sender, EventArgs e)
        {
            panelVari.Height = buttonKaksi.Height;
            panelVari.Top = buttonKaksi.Top;
            panelVari2.Hide();
            panelLisaaTyovaline.Hide();
        }

        
        private void buttonPoistu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreem());
        }

        private void buttonLisaa_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo.Table1](Tyovaline_nimi, Tyovaline_numero, Vuokraus_pvm, Vuokraus_firma) VALUES(@Name, @Number, @PVM, @Firm)", sc);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = textBoxTyovaline.Text;
            cmd.Parameters.Add("@Number", SqlDbType.NVarChar, 50).Value = textBoxTyovalNumero.Text;
            cmd.Parameters.Add("@PVM", SqlDbType.NVarChar, 50).Value = textBoxVuokrauspvm.Text;
            cmd.Parameters.Add("@Firm", SqlDbType.NVarChar, 50).Value = textBoxFirma.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Työväline lisätty onnistuneesti");
            sc.Close();
        }
    }
}
