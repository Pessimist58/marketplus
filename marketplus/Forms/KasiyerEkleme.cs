using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketplus.Forms
{
    public partial class KasiyerEkleme : Form
    {
        public KasiyerEkleme()
        {
            InitializeComponent();
        }

        private void KasiyerEkleme_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbKasaNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbKasiyerErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbKasiyerKadin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKasiyerEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KasaGörevlisi (KasiyerAdSoyad, KasiyerTcNo, KasiyerParola, KasiyerTelNo, KasiyerAdres, KasiyerCinsiyet, KasiyerDogumTarihi, KasiyerEmail, KasiyerKasaNo) VALUES (@KasiyerAdSoyad, @KasiyerTcNo, @KasiyerParola, @KasiyerTelNo, @KasiyerAdres, @KasiyerCinsiyet, @KasiyerDogumTarihi, @KasiyerEmail, @KasiyerKasaNo)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KasiyerAdSoyad", txtKasiyerAdSoyad.Text);
                    command.Parameters.AddWithValue("@KasiyerTcNo", txtKasiyerTcNo.Text);
                    command.Parameters.AddWithValue("@KasiyerTelNo", txtKasiyerTelefonNo.Text);
                    command.Parameters.AddWithValue("@KasiyerAdres", txtKasiyerAdresi.Text);
                    command.Parameters.AddWithValue("@KasiyerParola", txtKasiyerParola.Text);
                    command.Parameters.AddWithValue("@KasiyerCinsiyet", rbKasiyerErkek.Checked ? "Erkek" : "Kadın");
                    command.Parameters.AddWithValue("@KasiyerDogumTarihi", Convert.ToDateTime(dtpKasiyerDogumTarihi.Text));
                    command.Parameters.AddWithValue("@KasiyerEmail", txtKasiyerEmailAdresi.Text);
                    command.Parameters.AddWithValue("@KasiyerKasaNo", cbKasaNo.Text);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            MessageBox.Show("Kasiyer Ekleme İşlemi Başarılı.");

            cbKasaNo.SelectedItem = null;
            txtKasiyerAdSoyad.Text = "";
            txtKasiyerTcNo.Text = "";
            txtKasiyerTelefonNo.Text = "";
            txtKasiyerParola.Text = "";
            txtKasiyerEmailAdresi.Text = "";
            txtKasiyerAdresi.Text = "";
        }

        private void txtKasiyerTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKasiyerTcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKasiyerTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        bool Mov;
        int MovX, MovY;

        private void KasiyerEkleme_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void KasiyerEkleme_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void KasiyerEkleme_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }
    }
}
