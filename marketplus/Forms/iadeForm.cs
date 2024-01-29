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
    public partial class iadeForm : Form
    {
        private const string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";
        private List<MusteriAnaSayfa.Urun> sepet;

        public iadeForm()
        {
            InitializeComponent();
            SebepListesiniDoldur();
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

        private void SebepListesiniDoldur()
        {
            comboBoxIadeSebebi.Items.Add("Kullanıcı isteği");
            comboBoxIadeSebebi.Items.Add("Kusurlu ürün");
            comboBoxIadeSebebi.Items.Add("Değişim isteği");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string iadeSebebi = comboBoxIadeSebebi.SelectedItem?.ToString();
            string siparisno = textBox1.Text;
            DateTime iadeTarihi = dateTimePicker1.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO iadeTablosu (siparis_no, iade_sebebi, iade_tarihi, iade_detay, user_id) " +
                                         "SELECT sb.siparis_no, @iade_sebebi, @iade_tarihi, @iade_detay, @user_id " +
                                         "FROM SiparisBilgileri sb " +
                                         "WHERE sb.siparis_no = @siparis_no";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@siparis_no", textBox1.Text);
                        command.Parameters.AddWithValue("@user_id", ReadIntFromFile());
                        command.Parameters.AddWithValue("@iade_sebebi", iadeSebebi);
                        command.Parameters.AddWithValue("@iade_tarihi", iadeTarihi);
                        command.Parameters.AddWithValue("@iade_detay", textBox2.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("İade Talebi Başarıyla Oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT it.siparis_no, it.iade_sebebi, it.iade_tarihi, it.iade_detay, it.iade_durumu FROM iadeTablosu it INNER JOIN SiparisBilgileri sb ON it.siparis_no = sb.siparis_no WHERE it.user_id = @user_id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", ReadIntFromFile());

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iadeForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            iadeForm iadeForm = new iadeForm();
            iadeForm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sepetim sepetForm = new Sepetim(null);
            sepetForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciProfili kullaniciProfili = new KullaniciProfili();
            kullaniciProfili.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KargoTakipForm kargoTakipForm = new KargoTakipForm();
            kargoTakipForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriAnaSayfa musteriAnaSayfa = new MusteriAnaSayfa();
            musteriAnaSayfa.Show();
            this.Close();
        }

        bool Mov;
        int MovX, MovY;

        private void iadeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void iadeForm_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iadeForm_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}

