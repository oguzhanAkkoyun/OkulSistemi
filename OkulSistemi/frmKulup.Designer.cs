namespace OkulSistemi
{
    partial class frmKulup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKulup));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKulupId = new System.Windows.Forms.TextBox();
            this.txtKulupAd = new System.Windows.Forms.TextBox();
            this.btnKulupListele = new System.Windows.Forms.Button();
            this.btnKulupEkle = new System.Windows.Forms.Button();
            this.btnKulupGuncelle = new System.Windows.Forms.Button();
            this.btnKulupSil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULÜP İŞLEMLERİ PANELİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "KULÜP ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "KULÜP ADI:";
            // 
            // txtKulupId
            // 
            this.txtKulupId.Enabled = false;
            this.txtKulupId.Location = new System.Drawing.Point(184, 231);
            this.txtKulupId.Name = "txtKulupId";
            this.txtKulupId.Size = new System.Drawing.Size(241, 33);
            this.txtKulupId.TabIndex = 5;
            // 
            // txtKulupAd
            // 
            this.txtKulupAd.Location = new System.Drawing.Point(184, 269);
            this.txtKulupAd.Name = "txtKulupAd";
            this.txtKulupAd.Size = new System.Drawing.Size(241, 33);
            this.txtKulupAd.TabIndex = 6;
            // 
            // btnKulupListele
            // 
            this.btnKulupListele.BackColor = System.Drawing.Color.Pink;
            this.btnKulupListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupListele.Location = new System.Drawing.Point(95, 318);
            this.btnKulupListele.Name = "btnKulupListele";
            this.btnKulupListele.Size = new System.Drawing.Size(158, 50);
            this.btnKulupListele.TabIndex = 7;
            this.btnKulupListele.Text = "LİSTELE";
            this.btnKulupListele.UseVisualStyleBackColor = false;
            this.btnKulupListele.Click += new System.EventHandler(this.btnKulupListele_Click);
            // 
            // btnKulupEkle
            // 
            this.btnKulupEkle.BackColor = System.Drawing.Color.Pink;
            this.btnKulupEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupEkle.Location = new System.Drawing.Point(95, 374);
            this.btnKulupEkle.Name = "btnKulupEkle";
            this.btnKulupEkle.Size = new System.Drawing.Size(158, 50);
            this.btnKulupEkle.TabIndex = 8;
            this.btnKulupEkle.Text = "EKLE";
            this.btnKulupEkle.UseVisualStyleBackColor = false;
            this.btnKulupEkle.Click += new System.EventHandler(this.btnKulupEkle_Click);
            // 
            // btnKulupGuncelle
            // 
            this.btnKulupGuncelle.BackColor = System.Drawing.Color.Pink;
            this.btnKulupGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupGuncelle.Location = new System.Drawing.Point(328, 318);
            this.btnKulupGuncelle.Name = "btnKulupGuncelle";
            this.btnKulupGuncelle.Size = new System.Drawing.Size(168, 50);
            this.btnKulupGuncelle.TabIndex = 9;
            this.btnKulupGuncelle.Text = "GÜNCELLE";
            this.btnKulupGuncelle.UseVisualStyleBackColor = false;
            this.btnKulupGuncelle.Click += new System.EventHandler(this.btnKulupGuncelle_Click);
            // 
            // btnKulupSil
            // 
            this.btnKulupSil.BackColor = System.Drawing.Color.Pink;
            this.btnKulupSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupSil.Location = new System.Drawing.Point(328, 371);
            this.btnKulupSil.Name = "btnKulupSil";
            this.btnKulupSil.Size = new System.Drawing.Size(168, 50);
            this.btnKulupSil.TabIndex = 10;
            this.btnKulupSil.Text = "SİL";
            this.btnKulupSil.UseVisualStyleBackColor = false;
            this.btnKulupSil.Click += new System.EventHandler(this.btnKulupSil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 374);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(259, 318);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(259, 371);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(479, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // frmKulup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(519, 433);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnKulupSil);
            this.Controls.Add(this.btnKulupGuncelle);
            this.Controls.Add(this.btnKulupEkle);
            this.Controls.Add(this.btnKulupListele);
            this.Controls.Add(this.txtKulupAd);
            this.Controls.Add(this.txtKulupId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmKulup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kulüp İşlemleri";
            this.Load += new System.EventHandler(this.frmKulup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKulupId;
        private System.Windows.Forms.TextBox txtKulupAd;
        private System.Windows.Forms.Button btnKulupListele;
        private System.Windows.Forms.Button btnKulupEkle;
        private System.Windows.Forms.Button btnKulupGuncelle;
        private System.Windows.Forms.Button btnKulupSil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}