using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace marketplus.Forms
{
    public partial class MusteriAnaSayfa : Form
    {

        List<MusteriAnaSayfa.Urun> urunListesi = new List<MusteriAnaSayfa.Urun>();
        List<Urun> sepet = new List<Urun>();

        bool sidebarExpand;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public MusteriAnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void asd()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT UrunID,UrunAdi,UrunBirimFiyati,UrunMiktari,UrunAciklama From UrunTablosu", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void deneme_Load(object sender, EventArgs e)
        {
            asd();
            comboBox1.SelectedIndex = 0;
        }


        private void dataGridViewUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void menubutton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciProfili userProfile = new KullaniciProfili();
            userProfile.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                SqlCommand cmd = new SqlCommand("SELECT UrunID,UrunAdi,UrunBirimFiyati,UrunMiktari,UrunAciklama,KategoriID From UrunTablosu", con);
                DataTable dt = new DataTable();

                con.Open();
                dt.Load(cmd.ExecuteReader());
                con.Close();

                DataView dv = new DataView(dt);
                dv.RowFilter = "KategoriID =" + comboBox1.SelectedIndex;
                dataGridView1.DataSource = dv;
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                asd();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM UrunTablosu", con);
                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;
            }
            else
            {
                string sorgu = "SELECT * FROM UrunTablosu WHERE UrunAdi LIKE @AramaMetni";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                da.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                DataTable dt = new DataTable();

                con.Open();
                da.Fill(dt);
                con.Close();

                dataGridView1.DataSource = dt;
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string sorgu = "Select * from UrunTablosu Where UrunID=@UrunID";
            decimal UrunFiyati = 0;
            int UrunMik = 0;
            string UrunAdi = "";
            byte[] picturex = { };
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idR = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                using (SqlCommand command = new SqlCommand(sorgu, con))
                {
                    command.Parameters.AddWithValue("@UrunID", idR);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UrunAdi = reader.GetString(6);
                        UrunFiyati = reader.GetDecimal(3);
                        UrunMik = reader.GetInt32(4);
                        if (!reader.IsDBNull(5))
                            picturex = (byte[])reader["UrunPhoto"];
                    }
                    con.Close();
                }
                if (picturex.Length > 0)
                {
                    pictureBox2.Image = (Bitmap)((new ImageConverter()).ConvertFrom(picturex));
                }
                label6.Text = UrunAdi;
                label7.Text = UrunFiyati.ToString();
                label8.Text = UrunMik.ToString();
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string siralama = "";

            if (comboBox2.SelectedItem.ToString() == "Azalan")
            {
                siralama = "UrunBirimFiyati DESC";
            }
            else if (comboBox2.SelectedItem.ToString() == "Artan")
            {
                siralama = "UrunBirimFiyati ASC";
            }

            string sorgu = $"SELECT * FROM UrunTablosu ORDER BY {siralama};";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriAnaSayfa MainPage = new MusteriAnaSayfa();
            MainPage.Show();
            this.Close();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sepetim sepetForm = new Sepetim(sepet);
            sepetForm.Show();
            this.Close();
        }

        public class Urun
        {
            public int UrunID { get; set; }
            public string UrunAdi { get; set; }
            public decimal UrunFiyati { get; set; }
            public int UrunMiktar { get; set; }
        }

        private void sepeteEkle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idR = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                sepet.Add(new Urun
                {
                    UrunID = idR,
                    UrunAdi = label6.Text,
                    UrunFiyati = decimal.Parse(label7.Text),
                    UrunMiktar = int.Parse(label8.Text),
                });

                UpdateSepetDataGridView();
            }
        }
        private void UpdateSepetDataGridView()
        {
            dataGridViewSepet.DataSource = null;
            dataGridViewSepet.DataSource = sepet;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KargoTakipForm kargoTakipForm = new KargoTakipForm();
            kargoTakipForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridViewSepet.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewSepet.SelectedRows[0].Index;

                sepet.RemoveAt(selectedRowIndex);

                UpdateSepetDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iadeForm iadeForm = new iadeForm();
            iadeForm.Show();
            this.Close();
        }

        bool Mov;
        int MovX, MovY;

        private void MusteriAnaSayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void MusteriAnaSayfa_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void MusteriAnaSayfa_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
