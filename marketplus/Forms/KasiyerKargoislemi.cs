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

    public partial class KasiyerKargoislemi : Form
    {
        private const string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";
        public KasiyerKargoislemi()
        {
            InitializeComponent();
            LoadData();
        }

        private DataTable dataTable = new DataTable();

        

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Siparis_ID, siparis_no, tahmini_teslim_tarihi FROM SiparisBilgileri";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Kargoislemleri_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ListeleAktifSiparisler()
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir satır seçin.");
                return;
            }

            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

            int siparisId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Siparis_ID"].Value);

            string yeniSiparisNo = textBox1.Text;

            string yeniSiparisDurumu = comboBox1.SelectedItem.ToString(); 

            DateTime yeniTahminiTeslimTarihi = dateTimePicker1.Value;

            string updateQuery = "UPDATE SiparisBilgileri SET siparis_no = @YeniSiparisNo, siparis_durumu = @YeniSiparisDurumu, tahmini_teslim_tarihi = @YeniTahminiTeslimTarihi WHERE Siparis_ID = @SiparisId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@YeniSiparisNo", yeniSiparisNo);
                    updateCommand.Parameters.AddWithValue("@YeniSiparisDurumu", yeniSiparisDurumu);
                    updateCommand.Parameters.AddWithValue("@YeniTahminiTeslimTarihi", yeniTahminiTeslimTarihi);
                    updateCommand.Parameters.AddWithValue("@SiparisId", siparisId);

                    int affectedRows = updateCommand.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Güncelleme başarıyla gerçekleştirildi.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme sırasında bir hata oluştu.");
                    }
                }

                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SiparisBilgileri", con);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;
            }
            else
            {
                string sorgu = "SELECT Siparis_ID, siparis_no, siparis_durumu, tahmini_teslim_tarihi FROM SiparisBilgileri WHERE Siparis_ID LIKE '%' + @AramaMetni + '%'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                da.SelectCommand.Parameters.AddWithValue("@AramaMetni", aramaMetni);

                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;
            }
        }

        bool Mov;
        int MovX, MovY;
        private void KasiyerKargoislemi_MouseUp(object sender, MouseEventArgs e)
        {
            //Mov = false;
        }

        private void KasiyerKargoislemi_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }*/
        }

        private void KasiyerKargoislemi_MouseDown(object sender, MouseEventArgs e)
        {
            /*Mov = true;
            MovX = e.Y;
            MovY = e.X;*/
        }
    }
}
