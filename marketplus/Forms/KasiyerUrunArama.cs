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
    public partial class KasiyerUrunArama : Form
    {
        public KasiyerUrunArama()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FU3RIIU\\MSSQLSERVER01;Initial Catalog=MarketPlusDB;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            try {  
            int UrunKodu = 0, UrunMiktari = 0, UrunID = 0;
            decimal UrunBirimFiyati = 0;
            string UrunAciklama = " ";

            byte[] picturex = { };
            SqlCommand command = new SqlCommand("SELECT * FROM UrunTablosu WHERE UrunKodu=@UrunKodu", con);
            command.Parameters.AddWithValue("@UrunKodu", textBox1.Text);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UrunID = reader.GetInt32(0);
                UrunKodu = reader.GetInt32(1);
                UrunAciklama = reader.GetString(2);
                UrunBirimFiyati = reader.GetDecimal(3);
                UrunMiktari = reader.GetInt32(4);
                if (!reader.IsDBNull(5))
                    picturex = (byte[])reader["UrunPhoto"];
            }
            con.Close();
            txtBulunanUrun.Text = "Urun Kodu = " + UrunKodu.ToString() + " - Urun Aciklama = " + UrunAciklama + " - Urun Birim Fiyatı = " + UrunBirimFiyati.ToString() + " - Urun Miktarı = " + UrunMiktari.ToString();
            pictureBox1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(picturex));
            }
            catch(Exception ex) {
                MessageBox.Show("LÜtfen Doğru Urun Numaranızı Giriniz. Hata: " + ex.Message, "MarketPlus");
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

        bool Mov;
        int MovX, MovY;
        private void KasiyerUrunArama_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void KasiyerUrunArama_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void KasiyerUrunArama_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
