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
        SqlConnection sc = new SqlConnection(@"Data Source=DESKTOP-L5AVSMU\SQLEXPRESS;Initial Catalog=tyovalineet;Integrated Security=True");
        public Vuokratut()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            t.Abort();
            panelVari.Height = buttonVuokratut.Height;
            panelVari.Top = buttonVuokratut.Top;
            panelVari2.Hide();
            panelLisaaTyovaline.Hide();
            dataGridViewTyovalineet.Hide();
            

        }

        private void buttonLisaaTyokalu_Click(object sender, EventArgs e)
        {
            panelVari.Top = buttonLisaaTyokalu.Top;
            panelVari.Height = buttonLisaaTyokalu.Height;
            panelVari2.Show();
            panelLisaaTyovaline.Show();
            buttonLisaa.Show();
            dataGridViewTyovalineet.Hide();



        }

        private void buttonVuokratut_Click(object sender, EventArgs e)
        {
            panelVari.Height = buttonVuokratut.Height;
            panelVari.Top = buttonVuokratut.Top;
            panelVari2.Hide();
            panelLisaaTyovaline.Hide();
            buttonLisaa.Hide();
            dataGridViewTyovalineet.Show();
        }

        private void buttonYliVK_Click(object sender, EventArgs e)
        {
            panelVari.Height = buttonYliVK.Height;
            panelVari.Top = buttonYliVK.Top;
            panelVari2.Hide();
            
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
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_tyovalineet(tyovaline_nimi, tyovaline_id, vuokraus_pvm, vuokraus_firma) VALUES(@Name, @Number, @PVM, @Firm)", sc);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = textBoxTyovaline.Text;
            cmd.Parameters.Add("@Number", SqlDbType.NVarChar, 50).Value = textBoxTyovalNumero.Text;
            cmd.Parameters.Add("@PVM", SqlDbType.NVarChar, 50).Value = textBoxVuokrauspvm.Text;
            cmd.Parameters.Add("@Firm", SqlDbType.NVarChar, 50).Value = textBoxFirma.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Työväline lisätty onnistuneesti");
            sc.Close();
        }

        private void Vuokratut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tyovalineetDataSet.tbl_tyovalineet' table. You can move, or remove it, as needed.
            this.tbl_tyovalineetTableAdapter.Fill(this.tyovalineetDataSet.tbl_tyovalineet);

        }
    }
}
