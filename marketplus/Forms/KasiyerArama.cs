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
    public partial class KasiyerArama : Form
    {
        public KasiyerArama()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");


        private void btnKasiyerAra_Click(object sender, EventArgs e)
        {
            int KasiyerID = 0;
            DateTime KasiyerDogumTarihi = DateTime.MinValue;
            string KasiyerAdSoyad = "", KasiyerTcNo = "", KasiyerParola = "", KasiyerAdres = "", KasiyerCinsiyet = "", KasiyerEmail = "", KasiyerKasaNo = "", KasiyerTelNo = "";

            SqlCommand command = new SqlCommand("SELECT * FROM KasaGörevlisi WHERE KasiyerAdSoyad=@KasiyerAdSoyad", con);
            command.Parameters.AddWithValue("@KasiyerAdSoyad", txtAranacakKasiyerAdSoyad.Text);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                KasiyerID = reader.GetInt32(0);
                KasiyerAdSoyad = reader.GetString(1);
                KasiyerTcNo = reader.GetString(2);
                KasiyerParola = reader.GetString(3);
                KasiyerTelNo = reader.GetString(4);
                KasiyerAdres = reader.GetString(5);
                KasiyerCinsiyet = reader.GetString(6);
                KasiyerDogumTarihi = reader.GetDateTime(7);
                KasiyerEmail = reader.GetString(8);
                KasiyerKasaNo = reader.GetString(9);

                break;
            }

            con.Close();
            txtBulunanKasiyer.Text = "Adı ve Soyadı = " + KasiyerAdSoyad + " - Tc No = " + KasiyerTcNo + " - Parola = " + KasiyerParola + "- Tel No = " + KasiyerParola + "- Adres = " + KasiyerAdres + " - Cinsiyet = " + KasiyerCinsiyet + " - Doğum Tarihi" + KasiyerDogumTarihi + " - E-mail = " + KasiyerEmail + " - Kasa No = " + KasiyerKasaNo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtBulunanKasiyer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KasiyerArama_Load(object sender, EventArgs e)
        {

        }

        bool Mov;
        int MovX, MovY;
        private void KasiyerArama_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void KasiyerArama_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void KasiyerArama_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
