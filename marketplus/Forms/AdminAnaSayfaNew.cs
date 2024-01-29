using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketplus.Forms
{
    public partial class AdminAnaSayfaNew : Form
    {
        public AdminAnaSayfaNew()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        void XForm(Form X)
        {
            bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == X.Text)
                {
                    durum = true;
                    eleman.Activate();
                }

            }

            if (durum == false)
            {
                X.MdiParent = this;
                X.Show();
            }
        }

        private void AdminAnaSayfaNew_Load(object sender, EventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUrunEkle ue = new AdminUrunEkle();
            XForm(ue);
        }

        private void ürünAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUrunArama ua = new AdminUrunArama();
            XForm(ua);
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunListele ua = new UrunListele();
            XForm(ua);
        }

        private void kasiyerAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasiyerEkleme ke = new KasiyerEkleme();
            XForm(ke);
        }

        private void kasiyerAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasiyerArama ka = new KasiyerArama();
            XForm(ka);
        }

        private void kasiyerListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasiyerListele kl = new KasiyerListele();
            XForm(kl);
        }

        private void kargoİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKargoİslemi Kargoislem = new AdminKargoİslemi();
            XForm(Kargoislem);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AdminEkle adminEkle = new AdminEkle();
            XForm(adminEkle);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AdminSil adminEkle = new AdminSil();
            XForm(adminEkle);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AdminListele listele = new AdminListele();
            XForm(listele);
        }

        private void adminİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adminİadeİslemleri aki = new Adminİadeİslemleri();
            XForm(aki);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool Mov;
        int MovX, MovY;
        private void AdminAnaSayfaNew_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void AdminAnaSayfaNew_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Close();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login loginback = new Login();
            loginback.Show();
            this.Close();
        }

        private void AdminAnaSayfaNew_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }
    }
}
