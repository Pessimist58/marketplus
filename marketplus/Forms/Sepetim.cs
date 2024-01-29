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
    public partial class Sepetim : Form
    {
        private BindingList<MusteriAnaSayfa.Urun> sepet;

        public Sepetim(List<MusteriAnaSayfa.Urun> sepetList)
        {
            InitializeComponent();
            sepet = sepetList != null ? new BindingList<MusteriAnaSayfa.Urun>(sepetList) : new BindingList<MusteriAnaSayfa.Urun>();

            dataGridViewSepet.DataSource = sepet;

            ToplamFiyatiGuncelle();
        }

        private void ToplamFiyatiGuncelle()
        {
            decimal toplamFiyat = sepet.Sum(urun => urun.UrunFiyati);
            toplamLabel.Text = "Toplam Fiyat: " + toplamFiyat.ToString("C");
        }


        private void dataGridViewSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static int ReadIntFromFile()
        {
            int okunanSayi = 0;

            try
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\user.txt"))
                {
                    string satir = reader.ReadLine();
                    if (satir != null)
                    {
                        int.TryParse(satir, out okunanSayi);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            return okunanSayi;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sepet.Clear();
            dataGridViewSepet.DataSource = null;
            ToplamFiyatiGuncelle();
            ödeme odemeEkranı = new ödeme();
            odemeEkranı.Show();
            this.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            MusteriAnaSayfa deneme = new MusteriAnaSayfa();
            deneme.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KargoTakipForm kargoTakipForm = new KargoTakipForm();
            kargoTakipForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciProfili kullaniciProfili = new KullaniciProfili();
            kullaniciProfili.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewGecmisSiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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

        private string getUrunId(BindingList<Urun> sepet)
        {

            StringBuilder urunIdBuilder = new StringBuilder();
            foreach (Urun urun in sepet)
            {                      

                if (urunIdBuilder.Length > 0)
                {
                    urunIdBuilder.Append(";");
                }
                urunIdBuilder.Append(urun.UrunID);
            }

            return urunIdBuilder.ToString();
        }

        private void WriteUrunId()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\urunid.txt"))
                {
                    writer.Write(getUrunId(sepet).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }

        private string getUrunAdi(BindingList<Urun> sepet)
        {
            StringBuilder urunAdiBuilder = new StringBuilder();
            foreach (Urun urun in sepet)
            {
                if (urunAdiBuilder.Length > 0)
                {
                    urunAdiBuilder.Append(", ");
                }
                urunAdiBuilder.Append(urun.UrunAdi);
            }

            return urunAdiBuilder.ToString();
        }

        private void WriteUrunAdi()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\urunadi.txt"))
                {
                    writer.Write(getUrunAdi(sepet).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }

        private void ListeleGecmisSiparisler()
        {

            string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "SELECT siparis_no, STRING_AGG(ut.UrunAdi, ';') AS urun_adi, sb.siparis_tarihi FROM SiparisBilgileri sb CROSS APPLY STRING_SPLIT(sb.urun_id, ';') AS us JOIN UrunTablosu ut ON us.value = ut.UrunID WHERE user_id = @user_id AND siparis_durumu = 'Teslim Edildi' GROUP BY siparis_no, sb.siparis_tarihi;";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", ReadIntFromFile());
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewGecmisSiparisler.DataSource = dataTable;
                    }

                    connection.Close();
                }
            }
        }

        private void ListeleAktifSiparisler()
        {

            string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "SELECT siparis_no, STRING_AGG(ut.UrunAdi, ';') AS urun_adi, sb.siparis_tarihi FROM SiparisBilgileri sb CROSS APPLY STRING_SPLIT(sb.urun_id, ';') AS us JOIN UrunTablosu ut ON us.value = ut.UrunID WHERE user_id = @user_id AND siparis_durumu = 'Hazırlanıyor' GROUP BY siparis_no, sb.siparis_tarihi;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", ReadIntFromFile());
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAktifSiparisler.DataSource = dataTable;
                    }

                    connection.Close();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAktifSiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sepetim_Load(object sender, EventArgs e)
        {
            ListeleGecmisSiparisler();
            ListeleAktifSiparisler();
            WriteUrunId();
            WriteUrunAdi();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iadeForm iadeForm = new iadeForm();
            iadeForm.Show();
            this.Close();
        }

        bool Mov;
        int MovX, MovY;

        private void Sepetim_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void Sepetim_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login LoginBack = new Login();
            LoginBack.Show();
            this.Close();
        }

        private void Sepetim_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
