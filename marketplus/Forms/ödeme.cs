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
using static marketplus.Forms.MusteriAnaSayfa;

namespace marketplus.Forms
{
    public partial class ödeme : Form
    {
        public ödeme()
        {
            InitializeComponent();
    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelAdSoyad.Text = kartAdSoyad.Text;
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            labelKartNo.Text = kartKartNo.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSKT.Text = KartNo1.Text+ "/" + KartNo2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSKT.Text = KartNo1.Text + "/" + KartNo2.Text;
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            labelCVV.Text = KartCVV.Text;
        }

        private void ödeme_Load(object sender, EventArgs e)
        {
            int ay;
            int yil;
            for(ay = 1;ay<13;ay++)
            {
                KartNo1.Items.Add(ay);
            }
            for(yil=21; yil<30; yil++)
            {
                KartNo2.Items.Add(yil);
            }
        }

        static int ReadUserId()
        {
            int user = 0;

            try
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\user.txt"))
                {
                    string satir = reader.ReadLine();
                    if (satir != null)
                    {
                        int.TryParse(satir, out user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            return user;
        }

        static string ReadUrunId()
        {
            string urunid = string.Empty;

            try
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\urunid.txt"))
                {
                    urunid = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            return urunid;
        }

        int miktar = 0;

        void miktarAzalt(int x)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");

            SqlCommand cmdUrun = new SqlCommand("SELECT urun_id FROM SiparisBilgileri WHERE siparis_no=@siparis_no", con);
            cmdUrun.Parameters.AddWithValue("@siparis_no", x);

            string urunId = "";

            con.Open();
            SqlDataReader reader = cmdUrun.ExecuteReader();
            while (reader.Read())
            {
                urunId = reader.GetString(0);
            }
            con.Close();

            string[] stringDizi = urunId.Split(';');

            int[] intDizi = Array.ConvertAll(stringDizi, int.Parse);

            foreach (int id in intDizi)
            {
                int urunMiktar = 0;
                SqlCommand cmdUrunID = new SqlCommand("SELECT UrunMiktari FROM UrunTablosu WHERE UrunID=@UrunID", con);
                cmdUrunID.Parameters.AddWithValue("@UrunID", id);

                con.Open();
                SqlDataReader readerMiktar = cmdUrunID.ExecuteReader();
                while (readerMiktar.Read())
                {
                    urunMiktar = readerMiktar.GetInt32(0);
                }
                con.Close();

                SqlCommand cmdMiktar = new SqlCommand("UPDATE UrunTablosu SET UrunMiktari=@UrunMiktari WHERE UrunID=@UrunID", con);
                cmdMiktar.Parameters.AddWithValue("@UrunMiktari", urunMiktar-1);
                cmdMiktar.Parameters.AddWithValue("@UrunID", id);

                con.Open();
                cmdMiktar.ExecuteNonQuery();
                con.Close();
            }
        }

        private void OdemeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kartAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(kartKartNo.Text) ||
                KartNo1.SelectedItem == null ||
                KartNo2.SelectedItem == null ||
                string.IsNullOrWhiteSpace(KartCVV.Text))
            {
                MessageBox.Show("Lütfen boş olan yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Random random = new Random();
                int siparisNo = random.Next(1000, 10000);

                string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO OdemeBilgi (ad_soyad, kart_no, ay, yil, cvv) VALUES " +
                        "(@kartAdSoyad, @kartKartNo, @ay, @yil, @cvv)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kartAdSoyad", kartAdSoyad.Text);
                        command.Parameters.AddWithValue("@kartKartNo", kartKartNo.Text);
                        command.Parameters.AddWithValue("@ay", KartNo1.Text);
                        command.Parameters.AddWithValue("@yil", KartNo2.Text);
                        command.Parameters.AddWithValue("@cvv", KartCVV.Text);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        connection.Close();
                    }

                    string sorgu2 = "INSERT INTO SiparisBilgileri (siparis_no, user_id, urun_id, siparis_durumu, siparis_tarihi, tahmini_teslim_tarihi)" +
                                    "SELECT DISTINCT @siparis_no, @user_id, @urun_id, 'Hazırlanıyor' as siparis_durumu, GETDATE() as siparis_tarihi, DATEADD(DAY, 3, GETDATE()) as tahmini_teslim_tarihi FROM KullaniciPanel";

                    using (SqlCommand command = new SqlCommand(sorgu2, connection))
                    {
                        command.Parameters.AddWithValue("@siparis_no", siparisNo);
                        command.Parameters.AddWithValue("@user_id", ReadUserId());
                        command.Parameters.AddWithValue("@urun_id", ReadUrunId());

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show($"Ödeme işlemi başarıyla tamamlandı. Sipariş Numarası: {siparisNo}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                miktarAzalt(siparisNo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriAnaSayfa back = new MusteriAnaSayfa();
            back.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MusteriAnaSayfa deneme = new MusteriAnaSayfa();
            deneme.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool Mov;
        int MovX, MovY;

        private void ödeme_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void ödeme_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void ödeme_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
