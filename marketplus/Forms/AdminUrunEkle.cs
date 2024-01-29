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
    public partial class AdminUrunEkle : Form
    {
        public AdminUrunEkle()
        {
            InitializeComponent();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        System.Drawing.Image image1;

        bool imgSelected = false;
        byte[] bytes;

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimSec = new OpenFileDialog();
            if (resimSec.ShowDialog() == DialogResult.OK)
            {
                image1 = System.Drawing.Image.FromFile(resimSec.FileName);
                bytes = (byte[])(new ImageConverter()).ConvertTo(image1, typeof(byte[]));
                imgSelected = true;
            }

            pictureBox1.Image = image1;
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UrunTablosu (UrunKodu, UrunAciklama, UrunBirimFiyati, UrunMiktari, UrunPhoto, UrunAdi, KategoriID) VALUES (@UrunKodu, @UrunAciklama, @UrunBirimFiyati, @UrunMiktari, @UrunPhoto, @UrunAdi, @KategoriID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UrunKodu", Convert.ToInt32(txtUrunKodu.Text));
                    command.Parameters.AddWithValue("@UrunAciklama", txtUrunTanimi.Text);
                    command.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                    command.Parameters.AddWithValue("@UrunBirimFiyati", Convert.ToDecimal(txtUrunBirimFiyati.Text));
                    command.Parameters.AddWithValue("@UrunMiktari", Convert.ToInt32(txtUrunMiktari.Text));
                    command.Parameters.Add("@UrunPhoto", SqlDbType.VarBinary).Value = (byte[])(new ImageConverter()).ConvertTo(pictureBox1.Image, typeof(byte[]));
                    command.Parameters.AddWithValue("@KategoriID", comboBox1.SelectedIndex+1);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    connection.Close();
                }
            }

            MessageBox.Show("Ürün Ekleme İşlemi Başarılı.");

            txtUrunKodu.Text = "";
            txtUrunTanimi.Text = "";
            txtUrunBirimFiyati.Text = "";
            txtUrunMiktari.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        bool Mov;
        int MovX, MovY;

        private void AdminUrunEkle_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void AdminUrunEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void AdminUrunEkle_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
