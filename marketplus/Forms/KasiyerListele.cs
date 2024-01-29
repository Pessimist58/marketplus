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
    public partial class KasiyerListele : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        public KasiyerListele()
        {
            InitializeComponent();
            this.Load += KasiyerListele_Load;
        }
        private void dgKasiyerListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void KasiyerListele_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From KasaGörevlisi", conn);
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        bool Mov;
        int MovX, MovY;

        private void KasiyerListele_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void KasiyerListele_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

        }

        private void KasiyerListele_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}
