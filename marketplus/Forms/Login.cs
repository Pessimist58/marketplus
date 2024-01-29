using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketplus.Forms
{
    public partial class Login : Form
    {
        List<MusteriAnaSayfa.Urun> urunListesi = new List<MusteriAnaSayfa.Urun>();
        bool sideBar_Expand = true;
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register KayıtOl = new Register();
            KayıtOl.Show();
            this.Close();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public static class AuthenticationHelper
        {
            private static int loggedInUserId;

            public static bool IsUserLoggedIn()
            {
                return loggedInUserId != 0;
            }

            public static int GetLoggedInUserId()
            {
                return loggedInUserId;
            }

            public static void SetLoggedInUserId(int userId)
            {
                loggedInUserId = userId;
            }
        }

        int userId;
        private int getUserId(string str)
        {
            SqlCommand cmd = new SqlCommand("SELECT id FROM KullaniciPanel WHERE k_username=@k_username", con);
            cmd.Parameters.AddWithValue("@k_username", str);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userId = reader.GetInt32(0);
            }
            con.Close();

            return userId;
        }

        private void WriteIntToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\user.txt"))
                {
                    writer.Write(getUserId(giris_kullaniciadi.Text));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from KullaniciPanel where k_username='" + giris_kullaniciadi.Text + "' And k_sifre='" + giris_sifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                MusteriAnaSayfa MusteriAnasyfa = new MusteriAnaSayfa();
                MusteriAnasyfa.Show();
                WriteIntToFile();
                this.Close();
            }
            else
            {
                con.Close();
                MessageBox.Show("Hatalı kullanıcı adı ve şifre", "MarketPlus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool test = false;
        private void button4_Click(object sender, EventArgs e)
        {

            if(test == false)
            {
                giris_sifre.UseSystemPasswordChar = false;
            }
            else
            {
                giris_sifre.UseSystemPasswordChar = true;
            }

            test = !test;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Orange;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Orange;
        }

        private void slidebarTimer_Click(object sender, EventArgs e)
        {
            
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            AdminGiris AGiris = new AdminGiris();
            AGiris.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KasiyerGiris KGiris = new KasiyerGiris();
            KGiris.Show();
            this.Close();
        }

        private void giris_kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sifremiunuttum Parola = new Sifremiunuttum();
            Parola.Show();
            this.Close();
        }

        bool Mov;
        int MovX, MovY;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }
    }
}