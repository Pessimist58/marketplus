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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace marketplus.Forms
{
    public partial class KullaniciProfili : Form
    {
        private const string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";

        List<Urun> urunListesi = new List<Urun>();

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
        public KullaniciProfili()
        {
            InitializeComponent();
            DoldurKullaniciProfili();
        }

        private System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void DoldurKullaniciProfili()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id,k_username, k_ad, k_soyad, k_no, k_email, k_adres, k_photo, k_sifre " +
                                   "FROM KullaniciPanel " +
                                   "WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", ReadIntFromFile());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string UserID = reader["k_username"].ToString();
                                string kullaniciAdi = reader["k_username"].ToString();
                                string ad = reader["k_ad"].ToString();
                                string soyad = reader["k_soyad"].ToString();
                                string telefonNo = reader["k_no"].ToString();
                                string email = reader["k_email"].ToString();
                                string adres = reader["k_adres"].ToString();
                                byte[] fotoByteDizisi = reader["k_photo"] as byte[];

                                textKadi.Text = kullaniciAdi;
                                textKad.Text = ad;
                                textKSoyad.Text = soyad;
                                textKTel.Text = telefonNo;
                                textKEmail.Text = email;
                                textKAdres.Text = adres;

                                if (fotoByteDizisi != null && fotoByteDizisi.Length > 0)
                                {
                                    pictureBox1.Image = ByteArrayToImage(fotoByteDizisi);
                                }
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login LoginBack = new Login();
            LoginBack.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriAnaSayfa deneme = new MusteriAnaSayfa();
            deneme.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            KargoTakipForm kargoTakipForm = new KargoTakipForm();
            kargoTakipForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KullaniciProfili userProfile = new KullaniciProfili();
            userProfile.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sepetim sepetForm = new Sepetim(urunListesi);
            sepetForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream stream = openFileDialog.OpenFile())
                    {
                        byte[] fotoByteDizisi;

                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            stream.CopyTo(memoryStream);
                            fotoByteDizisi = memoryStream.ToArray();
                        }

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "UPDATE KullaniciPanel SET k_photo = @k_photo WHERE id = @id";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@id", ReadIntFromFile());
                                command.Parameters.AddWithValue("@k_photo", fotoByteDizisi);

                                int affectedRows = command.ExecuteNonQuery();

                                if (affectedRows > 0)
                                {
                                    MessageBox.Show("Profil fotoğrafı güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    DoldurKullaniciProfili();
                                }
                                else
                                {
                                    MessageBox.Show("Güncelleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string mevcutSifre = textBox1.Text;
            string yeniSifre = textBox2.Text;
            string tekrarYeniSifre = textBox3.Text;

            if (!MevcutSifreDogrulama(mevcutSifre))
            {
                MessageBox.Show("Mevcut şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(tekrarYeniSifre))
            {
                MessageBox.Show("Yeni şifre alanları boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yeniSifre != tekrarYeniSifre)
            {
                MessageBox.Show("Yeni şifreler eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SifreyiGuncelle(yeniSifre))
            {
                MessageBox.Show("Şifre güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifre güncelleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    private bool MevcutSifreDogrulama(string mevcutSifre)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT k_sifre FROM KullaniciPanel WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ReadIntFromFile());

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string dogruSifre = result.ToString();
                        return dogruSifre == mevcutSifre;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return false;
    }

        private bool SifreyiGuncelle(string yeniSifre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE KullaniciPanel SET k_sifre = @k_sifre WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", ReadIntFromFile());
                        command.Parameters.AddWithValue("@k_sifre", yeniSifre);

                        int affectedRows = command.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            iadeForm iadeForm = new iadeForm();
            iadeForm.Show();
            this.Close();
        }

        private void textKad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE KullaniciPanel " +
                                   "SET k_ad = @k_ad, k_soyad = @k_soyad, k_no = @k_no, k_email = @k_email, k_adres = @k_adres " +
                                   "WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", ReadIntFromFile());
                        command.Parameters.AddWithValue("@k_ad", textKad.Text);
                        command.Parameters.AddWithValue("@k_soyad", textKSoyad.Text);
                        command.Parameters.AddWithValue("@k_no", textKTel.Text);
                        command.Parameters.AddWithValue("@k_email", textKEmail.Text);
                        command.Parameters.AddWithValue("@k_adres", textKAdres.Text);

                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DoldurKullaniciProfili();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Mov;
        int MovX, MovY;
        private void KullaniciProfili_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void KullaniciProfili_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            iadeForm iadeForm = new iadeForm();
            iadeForm.Show();
            this.Close();
        }

        private void KullaniciProfili_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}