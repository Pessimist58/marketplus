namespace marketplus.Forms
{
    partial class KasiyerArama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerArama));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAranacakKasiyerAdSoyad = new System.Windows.Forms.Label();
            this.txtAranacakKasiyerAdSoyad = new System.Windows.Forms.TextBox();
            this.btnKasiyerAra = new System.Windows.Forms.Button();
            this.txtBulunanKasiyer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::marketplus.Properties.Resources.minimazedbutton;
            this.button2.Location = new System.Drawing.Point(540, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 21);
            this.button2.TabIndex = 3;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::marketplus.Properties.Resources.closebutton;
            this.button3.Location = new System.Drawing.Point(570, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 21);
            this.button3.TabIndex = 2;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblAranacakKasiyerAdSoyad
            // 
            this.lblAranacakKasiyerAdSoyad.AutoSize = true;
            this.lblAranacakKasiyerAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAranacakKasiyerAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAranacakKasiyerAdSoyad.ForeColor = System.Drawing.Color.White;
            this.lblAranacakKasiyerAdSoyad.Location = new System.Drawing.Point(120, 127);
            this.lblAranacakKasiyerAdSoyad.Name = "lblAranacakKasiyerAdSoyad";
            this.lblAranacakKasiyerAdSoyad.Size = new System.Drawing.Size(111, 25);
            this.lblAranacakKasiyerAdSoyad.TabIndex = 17;
            this.lblAranacakKasiyerAdSoyad.Text = "Ad Soyad:";
            // 
            // txtAranacakKasiyerAdSoyad
            // 
            this.txtAranacakKasiyerAdSoyad.Location = new System.Drawing.Point(228, 128);
            this.txtAranacakKasiyerAdSoyad.Multiline = true;
            this.txtAranacakKasiyerAdSoyad.Name = "txtAranacakKasiyerAdSoyad";
            this.txtAranacakKasiyerAdSoyad.Size = new System.Drawing.Size(144, 23);
            this.txtAranacakKasiyerAdSoyad.TabIndex = 18;
            // 
            // btnKasiyerAra
            // 
            this.btnKasiyerAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(2)))));
            this.btnKasiyerAra.FlatAppearance.BorderSize = 0;
            this.btnKasiyerAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKasiyerAra.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasiyerAra.ForeColor = System.Drawing.Color.White;
            this.btnKasiyerAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKasiyerAra.ImageKey = "Female-user-search-icon.png";
            this.btnKasiyerAra.Location = new System.Drawing.Point(378, 116);
            this.btnKasiyerAra.Name = "btnKasiyerAra";
            this.btnKasiyerAra.Size = new System.Drawing.Size(142, 43);
            this.btnKasiyerAra.TabIndex = 19;
            this.btnKasiyerAra.Text = "ARA";
            this.btnKasiyerAra.UseVisualStyleBackColor = false;
            this.btnKasiyerAra.Click += new System.EventHandler(this.btnKasiyerAra_Click);
            // 
            // txtBulunanKasiyer
            // 
            this.txtBulunanKasiyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.txtBulunanKasiyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBulunanKasiyer.ForeColor = System.Drawing.Color.White;
            this.txtBulunanKasiyer.Location = new System.Drawing.Point(32, 188);
            this.txtBulunanKasiyer.Multiline = true;
            this.txtBulunanKasiyer.Name = "txtBulunanKasiyer";
            this.txtBulunanKasiyer.Size = new System.Drawing.Size(536, 152);
            this.txtBulunanKasiyer.TabIndex = 44;
            this.txtBulunanKasiyer.TextChanged += new System.EventHandler(this.txtBulunanKasiyer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::marketplus.Properties.Resources.kasiyericon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(119, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 42);
            this.label1.TabIndex = 45;
            this.label1.Text = "    Kasiyer Arama Paneli";
            // 
            // KasiyerArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::marketplus.Properties.Resources.Kasiyer_arama;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtBulunanKasiyer);
            this.Controls.Add(this.btnKasiyerAra);
            this.Controls.Add(this.txtAranacakKasiyerAdSoyad);
            this.Controls.Add(this.lblAranacakKasiyerAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KasiyerArama";
            this.Text = "KasiyerEkleme";
            this.Load += new System.EventHandler(this.KasiyerArama_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KasiyerArama_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KasiyerArama_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KasiyerArama_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAranacakKasiyerAdSoyad;
        private System.Windows.Forms.TextBox txtAranacakKasiyerAdSoyad;
        private System.Windows.Forms.Button btnKasiyerAra;
        private System.Windows.Forms.TextBox txtBulunanKasiyer;
        private System.Windows.Forms.Label label1;
    }
}