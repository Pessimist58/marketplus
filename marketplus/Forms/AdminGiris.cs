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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        static bool test = false;
        private void sifregoster_Click(object sender, EventArgs e)
        {
            if (test == false)
            {
                txtAdminParola.UseSystemPasswordChar = false;
            }
            else
            {
                txtAdminParola.UseSystemPasswordChar = true;
            }

            test = !test;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private void giris_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from AdminTablosu Where AdminAdi='" + txtAdminAdi.Text + "' And AdminParola='" + txtAdminParola.Text + "'";
            dr = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(txtAdminAdi.Text) || string.IsNullOrEmpty(txtAdminParola.Text))
            {
                MessageBox.Show("Lütfen Boşluk Olan Yerleri Doldunuruz!");

            }
            else if (dr.Read())
            {
                AdminAnaSayfaNew AdminSayfa = new AdminAnaSayfaNew();
                AdminSayfa.Show();
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

        private void AdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool Mov;
        int MovX, MovY;
        private void AdminGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void AdminGiris_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void AdminGiris_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }
    }
}
