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
    public partial class AdminEkle : Form
    {
        public AdminEkle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        SqlCommand cmd;
        private void AdminEkle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminEkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO AdminTablosu (AdminAdi, AdminParola) VALUES (@AdminAdi, @AdminParola)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdminAdi", txtAdminAd.Text);
                        command.Parameters.AddWithValue("@AdminParola", txtAdminParola.Text);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        connection.Close();
                    }
                }
                MessageBox.Show("Admin Ekleme İşlemi Başarılı.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        bool Mov;
        int MovX, MovY;

        private void AdminEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void AdminEkle_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void AdminEkle_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }
    }
}

