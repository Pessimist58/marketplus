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
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem) 
            {
                this.Opacity += 0.009;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if(islem) 
            {
                this.Opacity -= 0.009;
                if(this.Opacity ==0)
                {
                    Login Login = new Login();
                    Login.Show();
                    timer1.Enabled = false;
                    this.Hide();
                }
            }
        }
        private void splashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
