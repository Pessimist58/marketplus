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
    public partial class KargoTakipForm : Form
    {
        List<MusteriAnaSayfa.Urun> urunListesi = new List<MusteriAnaSayfa.Urun>();

        public KargoTakipForm()
        {
            InitializeComponent();
        }

      
        private void btnKargoGonder_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciProfili kullaniciProfili = new KullaniciProfili();
            kullaniciProfili.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadCargoInformation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KargoTakipForm KargoPage = new KargoTakipForm();
            KargoPage.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriAnaSayfa MainPage = new MusteriAnaSayfa();
            MainPage.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sepetim sepetForm = new Sepetim(urunListesi);
            sepetForm.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KargoTakipForm_Load(object sender, EventArgs e)
        {
        }

        static string ReadStringFromFile()
        {
            string okunanString = "";

            try
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\urunadi.txt"))
                {
                    okunanString = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            return okunanString;
        }

        private void LoadCargoInformation()
        {
            string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT siparis_no, siparis_durumu, tahmini_teslim_tarihi FROM SiparisBilgileri WHERE siparis_no = @siparis_no";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@siparis_no", textBox1.Text);
                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    connection.Close();
                    StringBuilder urunAdlariBuilder = new StringBuilder();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (urunAdlariBuilder.Length > 0)
                        {
                            urunAdlariBuilder.Append(", ");
                        }
                        urunAdlariBuilder.Append(row["siparis_durumu"].ToString()); 
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iadeForm iadeForm = new iadeForm();
            iadeForm.Show();
            this.Close();
        }

        bool Mov;
        int MovX, MovY;
        private void KargoTakipForm_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void KargoTakipForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void urunAdlari_TextChanged(object sender, EventArgs e)
        {
        }

        private void KargoTakipForm_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }
    }
}
