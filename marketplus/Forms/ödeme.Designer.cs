namespace marketplus.Forms
{
    partial class ödeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ödeme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCVV = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.labelSKT = new System.Windows.Forms.Label();
            this.labelKartNo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OdemeButton = new System.Windows.Forms.Button();
            this.KartCVV = new System.Windows.Forms.MaskedTextBox();
            this.KartNo2 = new System.Windows.Forms.ComboBox();
            this.KartNo1 = new System.Windows.Forms.ComboBox();
            this.kartKartNo = new System.Windows.Forms.MaskedTextBox();
            this.kartAdSoyad = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelCVV);
            this.panel1.Controls.Add(this.labelAdSoyad);
            this.panel1.Controls.Add(this.labelSKT);
            this.panel1.Controls.Add(this.labelKartNo);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(348, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 461);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.BackColor = System.Drawing.Color.Black;
            this.labelCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCVV.Location = new System.Drawing.Point(241, 340);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(0, 17);
            this.labelCVV.TabIndex = 5;
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.BackColor = System.Drawing.Color.Black;
            this.labelAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyad.Location = new System.Drawing.Point(89, 175);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(0, 20);
            this.labelAdSoyad.TabIndex = 4;
            // 
            // labelSKT
            // 
            this.labelSKT.AutoSize = true;
            this.labelSKT.BackColor = System.Drawing.Color.Black;
            this.labelSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSKT.Location = new System.Drawing.Point(167, 157);
            this.labelSKT.Name = "labelSKT";
            this.labelSKT.Size = new System.Drawing.Size(0, 16);
            this.labelSKT.TabIndex = 3;
            // 
            // labelKartNo
            // 
            this.labelKartNo.AutoSize = true;
            this.labelKartNo.BackColor = System.Drawing.Color.Black;
            this.labelKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKartNo.Location = new System.Drawing.Point(88, 132);
            this.labelKartNo.Name = "labelKartNo";
            this.labelKartNo.Size = new System.Drawing.Size(0, 25);
            this.labelKartNo.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 161);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖDEME YERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "KART NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "S.K.T. YIL/AY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "CVV";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.OdemeButton);
            this.panel2.Controls.Add(this.KartCVV);
            this.panel2.Controls.Add(this.KartNo2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.KartNo1);
            this.panel2.Controls.Add(this.kartKartNo);
            this.panel2.Controls.Add(this.kartAdSoyad);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(28, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 236);
            this.panel2.TabIndex = 6;
            // 
            // OdemeButton
            // 
            this.OdemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(2)))));
            this.OdemeButton.FlatAppearance.BorderSize = 0;
            this.OdemeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.OdemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OdemeButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdemeButton.ForeColor = System.Drawing.Color.Transparent;
            this.OdemeButton.Location = new System.Drawing.Point(78, 188);
            this.OdemeButton.Name = "OdemeButton";
            this.OdemeButton.Size = new System.Drawing.Size(144, 37);
            this.OdemeButton.TabIndex = 12;
            this.OdemeButton.Text = "Ödeme Yap";
            this.OdemeButton.UseVisualStyleBackColor = false;
            this.OdemeButton.Click += new System.EventHandler(this.OdemeButton_Click);
            // 
            // KartCVV
            // 
            this.KartCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KartCVV.Location = new System.Drawing.Point(122, 150);
            this.KartCVV.Mask = "000";
            this.KartCVV.Name = "KartCVV";
            this.KartCVV.Size = new System.Drawing.Size(38, 26);
            this.KartCVV.TabIndex = 11;
            this.KartCVV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox2_KeyUp);
            // 
            // KartNo2
            // 
            this.KartNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KartNo2.FormattingEnabled = true;
            this.KartNo2.Location = new System.Drawing.Point(175, 114);
            this.KartNo2.Name = "KartNo2";
            this.KartNo2.Size = new System.Drawing.Size(47, 28);
            this.KartNo2.TabIndex = 10;
            this.KartNo2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // KartNo1
            // 
            this.KartNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KartNo1.FormattingEnabled = true;
            this.KartNo1.Location = new System.Drawing.Point(122, 114);
            this.KartNo1.Name = "KartNo1";
            this.KartNo1.Size = new System.Drawing.Size(47, 28);
            this.KartNo1.TabIndex = 9;
            this.KartNo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kartKartNo
            // 
            this.kartKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartKartNo.Location = new System.Drawing.Point(122, 81);
            this.kartKartNo.Mask = "0000 0000 0000 0000";
            this.kartKartNo.Name = "kartKartNo";
            this.kartKartNo.Size = new System.Drawing.Size(156, 26);
            this.kartKartNo.TabIndex = 8;
            this.kartKartNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyUp);
            // 
            // kartAdSoyad
            // 
            this.kartAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartAdSoyad.Location = new System.Drawing.Point(122, 45);
            this.kartAdSoyad.Multiline = true;
            this.kartAdSoyad.Name = "kartAdSoyad";
            this.kartAdSoyad.Size = new System.Drawing.Size(156, 26);
            this.kartAdSoyad.TabIndex = 6;
            this.kartAdSoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(2, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 27);
            this.button6.TabIndex = 18;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ödeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::marketplus.Properties.Resources.odeme_yeri;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ödeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ödeme";
            this.Load += new System.EventHandler(this.ödeme_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ödeme_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ödeme_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ödeme_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox kartAdSoyad;
        private System.Windows.Forms.MaskedTextBox kartKartNo;
        private System.Windows.Forms.ComboBox KartNo2;
        private System.Windows.Forms.ComboBox KartNo1;
        private System.Windows.Forms.MaskedTextBox KartCVV;
        private System.Windows.Forms.Label labelKartNo;
        private System.Windows.Forms.Label labelSKT;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.Button OdemeButton;
        private System.Windows.Forms.Button button6;
    }
}