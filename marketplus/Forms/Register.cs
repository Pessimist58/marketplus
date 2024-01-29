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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace marketplus.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login LoginBack = new Login();
            LoginBack.Show();
            this.Close();
        }

        static bool SayiMi(string deger)
        {
            try
            {
                long.Parse(deger);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void kayit_btn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || kadi.Text == "" || ksoyad.Text == "" || kno.Text == "" || kemail.Text == "" || ksifre.Text == "" || ksifretekrar.Text == "" || kadres.Text == "")
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            else if (SayiMi(kno.Text) == false)
                MessageBox.Show("Girdiğiniz telefon numarası geçersiz.");
            else if (ksifre.Text == ksifretekrar.Text)
            {
                string ekle = "INSERT INTO KullaniciPanel(k_username,k_ad, k_soyad, k_no, k_email, k_sifre, k_adres) values (@k_username, @k_ad, @k_soyad, @k_no, @k_email, @k_sifre, @k_adres)";

                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(ekle, con);
                con.Open();

                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@k_username", username.Text);
                cmd.Parameters.AddWithValue("@k_ad", kadi.Text);
                cmd.Parameters.AddWithValue("@k_soyad", ksoyad.Text);
                cmd.Parameters.AddWithValue("@k_no", kno.Text);
                cmd.Parameters.AddWithValue("@k_email", kemail.Text);
                cmd.Parameters.AddWithValue("@k_sifre", ksifre.Text);
                cmd.Parameters.AddWithValue("@k_adres", kadres.Text);
                MessageBox.Show("Üye Olma Başarılı");
                cmd.ExecuteNonQuery();
                Login giris = new Login();
                giris.Show();
                con.Close();
                this.Close();
            }
            else
                MessageBox.Show("Tekrar Deneyiniz.", "HAY AKSİ!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login LoginBack = new Login();
            LoginBack.Show();
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        bool Mov;
        int MovX, MovY;

        private void Register_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Login LoginBack = new Login();
            LoginBack.Show();
            this.Close();
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
