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
    public partial class KasiyerAnaSayfa : Form
    {
        public KasiyerAnaSayfa()
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
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasiyerUrunEkle ue = new KasiyerUrunEkle();
            XForm(ue);
        }

        private void ürünAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasiyerUrunArama ue = new KasiyerUrunArama();
            XForm(ue);
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasiyerUrunListele ue = new KasiyerUrunListele();
            XForm(ue);
        }

        private void kargoİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KasiyerKargoislemi ue = new KasiyerKargoislemi();
            XForm(ue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KasiyerAnaSayfa_Load(object sender, EventArgs e)
        {
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kasiyerİadeİslemleri kii = new Kasiyerİadeİslemleri();
            XForm(kii);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KasiyerUrunEkle kue = new KasiyerUrunEkle();
            XForm(kue);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            KasiyerUrunArama kua = new KasiyerUrunArama();
            XForm(kua);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            KasiyerUrunListele kul  = new KasiyerUrunListele();
            XForm(kul);
        }

        bool Mov;
        int MovX, MovY;
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

        private void KasiyerAnaSayfa_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void KasiyerAnaSayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

        private void KasiyerAnaSayfa_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
           Login login = new Login();
           login.Show();
           this.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
    }
}
