namespace marketplus.Forms
{
    partial class KasiyerUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerUrunEkle));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunMiktari = new System.Windows.Forms.TextBox();
            this.lblUrunMiktari = new System.Windows.Forms.Label();
            this.txtUrunBirimFiyati = new System.Windows.Forms.TextBox();
            this.lblUrunBirimFiyati = new System.Windows.Forms.Label();
            this.txtUrunTanimi = new System.Windows.Forms.TextBox();
            this.lblUrunTanimi = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Atıştırmalıklar",
            "İçecekler",
            "Dondurmalar",
            "Meyve Ve Sebze",
            "Bakım Ürünleri",
            "Elektronik"});
            this.comboBox1.Location = new System.Drawing.Point(195, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ürün Kategori:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunAdi.Location = new System.Drawing.Point(195, 150);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(181, 20);
            this.txtUrunAdi.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Ürün Adi:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(2)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(423, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 60;
            this.button3.Text = "Resim Seç";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(2)))));
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.ImageKey = "add-item-icon.png";
            this.btnUrunEkle.Location = new System.Drawing.Point(210, 353);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(144, 45);
            this.btnUrunEkle.TabIndex = 58;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunMiktari
            // 
            this.txtUrunMiktari.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunMiktari.Location = new System.Drawing.Point(195, 308);
            this.txtUrunMiktari.Name = "txtUrunMiktari";
            this.txtUrunMiktari.Size = new System.Drawing.Size(181, 20);
            this.txtUrunMiktari.TabIndex = 57;
            // 
            // lblUrunMiktari
            // 
            this.lblUrunMiktari.AutoSize = true;
            this.lblUrunMiktari.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunMiktari.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMiktari.ForeColor = System.Drawing.Color.White;
            this.lblUrunMiktari.Location = new System.Drawing.Point(73, 308);
            this.lblUrunMiktari.Name = "lblUrunMiktari";
            this.lblUrunMiktari.Size = new System.Drawing.Size(116, 23);
            this.lblUrunMiktari.TabIndex = 56;
            this.lblUrunMiktari.Text = "Ürün Miktarı:";
            // 
            // txtUrunBirimFiyati
            // 
            this.txtUrunBirimFiyati.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunBirimFiyati.Location = new System.Drawing.Point(195, 266);
            this.txtUrunBirimFiyati.Name = "txtUrunBirimFiyati";
            this.txtUrunBirimFiyati.Size = new System.Drawing.Size(181, 20);
            this.txtUrunBirimFiyati.TabIndex = 55;
            // 
            // lblUrunBirimFiyati
            // 
            this.lblUrunBirimFiyati.AutoSize = true;
            this.lblUrunBirimFiyati.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunBirimFiyati.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunBirimFiyati.ForeColor = System.Drawing.Color.White;
            this.lblUrunBirimFiyati.Location = new System.Drawing.Point(73, 266);
            this.lblUrunBirimFiyati.Name = "lblUrunBirimFiyati";
            this.lblUrunBirimFiyati.Size = new System.Drawing.Size(104, 23);
            this.lblUrunBirimFiyati.TabIndex = 54;
            this.lblUrunBirimFiyati.Text = "Ürün Fiyatı:";
            // 
            // txtUrunTanimi
            // 
            this.txtUrunTanimi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunTanimi.Location = new System.Drawing.Point(195, 193);
            this.txtUrunTanimi.Multiline = true;
            this.txtUrunTanimi.Name = "txtUrunTanimi";
            this.txtUrunTanimi.Size = new System.Drawing.Size(181, 54);
            this.txtUrunTanimi.TabIndex = 53;
            // 
            // lblUrunTanimi
            // 
            this.lblUrunTanimi.AutoSize = true;
            this.lblUrunTanimi.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunTanimi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunTanimi.ForeColor = System.Drawing.Color.White;
            this.lblUrunTanimi.Location = new System.Drawing.Point(73, 202);
            this.lblUrunTanimi.Name = "lblUrunTanimi";
            this.lblUrunTanimi.Size = new System.Drawing.Size(108, 23);
            this.lblUrunTanimi.TabIndex = 52;
            this.lblUrunTanimi.Text = "Ürün Tanımı:";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunKodu.Location = new System.Drawing.Point(195, 107);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(181, 20);
            this.txtUrunKodu.TabIndex = 51;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunKodu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.ForeColor = System.Drawing.Color.White;
            this.lblUrunKodu.Location = new System.Drawing.Point(73, 106);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(95, 23);
            this.lblUrunKodu.TabIndex = 50;
            this.lblUrunKodu.Text = "Ürün Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ketika Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::marketplus.Properties.Resources.urunekle;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(102, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 37);
            this.label3.TabIndex = 65;
            this.label3.Text = "       Urun Ekleme Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::marketplus.Properties.Resources.marketpluslogo1;
            this.pictureBox1.Location = new System.Drawing.Point(412, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::marketplus.Properties.Resources.minimazedbutton;
            this.button2.Location = new System.Drawing.Point(526, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 21);
            this.button2.TabIndex = 67;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::marketplus.Properties.Resources.closebutton;
            this.button1.Location = new System.Drawing.Point(554, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 21);
            this.button1.TabIndex = 66;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KasiyerUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::marketplus.Properties.Resources.urun_ekle;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.txtUrunMiktari);
            this.Controls.Add(this.lblUrunMiktari);
            this.Controls.Add(this.txtUrunBirimFiyati);
            this.Controls.Add(this.lblUrunBirimFiyati);
            this.Controls.Add(this.txtUrunTanimi);
            this.Controls.Add(this.lblUrunTanimi);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.lblUrunKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KasiyerUrunEkle";
            this.Text = "KasiyerUrunEkle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KasiyerUrunEkle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KasiyerUrunEkle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KasiyerUrunEkle_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunMiktari;
        private System.Windows.Forms.Label lblUrunMiktari;
        private System.Windows.Forms.TextBox txtUrunBirimFiyati;
        private System.Windows.Forms.Label lblUrunBirimFiyati;
        private System.Windows.Forms.TextBox txtUrunTanimi;
        private System.Windows.Forms.Label lblUrunTanimi;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}