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
    public partial class KasiyerGiris : Form
    {
        public KasiyerGiris()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void giris_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from KasaGörevlisi where KasiyerAdSoyad='" + txtKasiyerAdSyoad.Text + "' And KasiyerParola='" + txtKasiyerParola.Text + "'";
            dr = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(txtKasiyerAdSyoad.Text) || string.IsNullOrEmpty(txtKasiyerParola.Text))
            {
                MessageBox.Show("Lütfen Boşluk Olan Yerleri Doldunuruz!");

            }
            else if (dr.Read())
            {
                KasiyerAnaSayfa MusteriAnasyfa = new KasiyerAnaSayfa();
                MusteriAnasyfa.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ve şifre", "MarketPlus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login LoginBack = new Login();
            LoginBack.Show();
            this.Close();
        }
        static bool test = false;
        private void sifregoster_Click(object sender, EventArgs e)
        {
            if (test == false)
            {
                txtKasiyerParola.UseSystemPasswordChar = false;
            }
            else
            {
                txtKasiyerParola.UseSystemPasswordChar = true;
            }

            test = !test;
        }

        private void KasiyerGiris_Load(object sender, EventArgs e)
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

        bool Mov;
        int MovX, MovY;

        private void KasiyerGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void KasiyerGiris_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void KasiyerGiris_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
