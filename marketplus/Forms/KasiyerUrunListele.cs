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
    public partial class KasiyerUrunListele : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        public KasiyerUrunListele()
        {
            InitializeComponent();
            this.Load += KasiyerUrunListele_Load;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridViewUrunListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From UrunTablosu", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridViewUrunListele.DataSource = ds.Tables[0];
            con.Close();
        }

        private void KasiyerUrunListele_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From UrunTablosu", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridViewUrunListele.DataSource = ds.Tables[0];
            con.Close();
        }

        bool Mov;
        int MovX, MovY;
        private void KasiyerUrunListele_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void KasiyerUrunListele_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void KasiyerUrunListele_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
