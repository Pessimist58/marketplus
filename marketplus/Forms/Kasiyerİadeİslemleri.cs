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
    public partial class Kasiyerİadeİslemleri : Form
    {
        public Kasiyerİadeİslemleri()
        {
            InitializeComponent();
            LoadData();
        }

        private const string connectionString = "Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True";
        private DataTable dataTable = new DataTable();
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * From iadeTablosu";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            int iade_id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["iade_id"].Value);


            string YeniIadeDurumu = comboBox1.SelectedItem.ToString();

            string updateQuery = "UPDATE iadeTablosu SET iade_durumu = @iade_durumu WHERE iade_id = @iade_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@iade_durumu", YeniIadeDurumu);
                    updateCommand.Parameters.AddWithValue("@iade_id", iade_id);

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

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM iadeTablosu", con);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;
            }
            else
            {
                string sorgu = "SELECT * FROM iadeTablosu WHERE iade_id LIKE '%' + @AramaMetni + '%'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, connectionString);
                da.SelectCommand.Parameters.AddWithValue("@AramaMetni", aramaMetni);

                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;
            }
        }

        private void SebepListesiniDoldur()
        {
            comboBox1.Items.Add("Onaylandı");
            comboBox1.Items.Add("Reddedildi");
        }

        private void Kasiyerİadeİslemleri_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool Mov;
        int MovX, MovY;

        private void Kasiyerİadeİslemleri_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void Kasiyerİadeİslemleri_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void Kasiyerİadeİslemleri_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
 }
