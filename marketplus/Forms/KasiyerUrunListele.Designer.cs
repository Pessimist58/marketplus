namespace marketplus.Forms
{
    partial class KasiyerUrunListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerUrunListele));
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewUrunListele = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunListele)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ketika Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::marketplus.Properties.Resources.urunliste1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(126, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 37);
            this.label2.TabIndex = 53;
            this.label2.Text = "     Urun Listeleme Paneli";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::marketplus.Properties.Resources.minimazedbutton;
            this.button2.Location = new System.Drawing.Point(538, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 21);
            this.button2.TabIndex = 51;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewUrunListele
            // 
            this.dataGridViewUrunListele.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewUrunListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunListele.Location = new System.Drawing.Point(35, 111);
            this.dataGridViewUrunListele.Name = "dataGridViewUrunListele";
            this.dataGridViewUrunListele.Size = new System.Drawing.Size(523, 311);
            this.dataGridViewUrunListele.TabIndex = 52;
            this.dataGridViewUrunListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunListele_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::marketplus.Properties.Resources.closebutton;
            this.button3.Location = new System.Drawing.Point(569, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 21);
            this.button3.TabIndex = 50;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KasiyerUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::marketplus.Properties.Resources.K_urunarama1;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewUrunListele);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KasiyerUrunListele";
            this.Text = "KasiyerUrunListele";
            this.Load += new System.EventHandler(this.KasiyerUrunListele_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KasiyerUrunListele_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KasiyerUrunListele_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KasiyerUrunListele_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewUrunListele;
        private System.Windows.Forms.Button button3;
    }
}