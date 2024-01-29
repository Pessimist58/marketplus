using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketplus.Forms
{
    public partial class AdminSil : Form
    {
        public AdminSil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void AdminSilButon_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdminID.Text) || string.IsNullOrEmpty(txtAdminAd.Text) || string.IsNullOrEmpty(txtAdminParola.Text))
            {
                MessageBox.Show("Lütfen kayıt seçiniz.");

            }
            else
            {
                string sorgu = "Delete from AdminTablosu Where AdminID=@AdminID";
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@AdminID", txtAdminID.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Silindi.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminSil_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool Mov;
        int MovX, MovY;
        private void AdminSil_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void AdminSil_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void AdminSil_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
