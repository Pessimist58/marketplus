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
    public partial class Sifremiunuttum : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        public Sifremiunuttum()
        {
            InitializeComponent();
        }

        private void Sifremiunuttum_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            string telefonNo = textBoxTelefonNo.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(telefonNo))
            {
                MessageBox.Show("Kullanıcı adı ve telefon numarası boş bırakılamaz.", "MarketPlus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KullaniciBilgileriDogruMu(kullaniciAdi, telefonNo))
            {
                YeniSifreOlustur(kullaniciAdi);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya telefon numarası hatalı.", "MarketPlus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KullaniciBilgileriDogruMu(string kullaniciAdi, string telefonNo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM KullaniciPanel WHERE k_username=@kullaniciAdi AND k_no=@telefonNo";
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@telefonNo", telefonNo);

            int count = (int)cmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }
        private void YeniSifreOlustur(string kullaniciAdi)
        {
            string yeniSifre = SifreOlustur();

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE KullaniciPanel SET k_sifre=@yeniSifre WHERE k_username=@kullaniciAdi";
            cmd.Parameters.AddWithValue("@yeniSifre", yeniSifre);
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Yeni şifreniz: " + yeniSifre, "MarketPlus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private string SifreOlustur()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login Back = new Login();
            Back.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool Mov;
        int MovX, MovY;
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Sifremiunuttum_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;

        }

        private void Sifremiunuttum_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void Sifremiunuttum_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
