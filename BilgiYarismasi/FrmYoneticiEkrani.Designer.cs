
namespace BilgiYarismasi
{
    partial class FrmYoneticiEkrani
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtSoruArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.rchSoru = new System.Windows.Forms.RichTextBox();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtSoruNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNumaraVer = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriPasifYap = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriListele = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 406);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(821, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(566, 4);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(112, 34);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(686, 4);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 34);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(566, 46);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 34);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(686, 46);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 34);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(696, 364);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 34);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtSoruArama
            // 
            this.txtSoruArama.Location = new System.Drawing.Point(589, 369);
            this.txtSoruArama.Name = "txtSoruArama";
            this.txtSoruArama.Size = new System.Drawing.Size(100, 37);
            this.txtSoruArama.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soru İd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soru:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şık A)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şık B)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Şık C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Şık D)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Şık E)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cevap:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(92, 1);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 37);
            this.txtId.TabIndex = 16;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(92, 194);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(202, 37);
            this.txtA.TabIndex = 17;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(92, 230);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(202, 37);
            this.txtB.TabIndex = 18;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(92, 266);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(202, 37);
            this.txtC.TabIndex = 19;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(92, 302);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(202, 37);
            this.txtD.TabIndex = 20;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(92, 338);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(202, 37);
            this.txtE.TabIndex = 21;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(92, 374);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(202, 37);
            this.txtCevap.TabIndex = 22;
            // 
            // rchSoru
            // 
            this.rchSoru.Location = new System.Drawing.Point(92, 74);
            this.rchSoru.Name = "rchSoru";
            this.rchSoru.Size = new System.Drawing.Size(391, 78);
            this.rchSoru.TabIndex = 23;
            this.rchSoru.Text = "";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Location = new System.Drawing.Point(686, 88);
            this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(112, 34);
            this.btnAnasayfa.TabIndex = 24;
            this.btnAnasayfa.Text = "Ana Sayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(566, 88);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 34);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtSoruNo
            // 
            this.txtSoruNo.Enabled = false;
            this.txtSoruNo.Location = new System.Drawing.Point(92, 36);
            this.txtSoruNo.Name = "txtSoruNo";
            this.txtSoruNo.Size = new System.Drawing.Size(202, 37);
            this.txtSoruNo.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "Soru No:";
            // 
            // btnNumaraVer
            // 
            this.btnNumaraVer.Location = new System.Drawing.Point(301, 37);
            this.btnNumaraVer.Name = "btnNumaraVer";
            this.btnNumaraVer.Size = new System.Drawing.Size(109, 23);
            this.btnNumaraVer.TabIndex = 32;
            this.btnNumaraVer.Text = "Numara Ver";
            this.btnNumaraVer.UseVisualStyleBackColor = true;
            this.btnNumaraVer.Click += new System.EventHandler(this.btnNumaraVer_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(589, 160);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(36, 26);
            this.btnKategoriGuncelle.TabIndex = 40;
            this.btnKategoriGuncelle.Text = "G";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriPasifYap
            // 
            this.btnKategoriPasifYap.Location = new System.Drawing.Point(540, 160);
            this.btnKategoriPasifYap.Name = "btnKategoriPasifYap";
            this.btnKategoriPasifYap.Size = new System.Drawing.Size(36, 26);
            this.btnKategoriPasifYap.TabIndex = 39;
            this.btnKategoriPasifYap.Text = "-";
            this.btnKategoriPasifYap.UseVisualStyleBackColor = true;
            this.btnKategoriPasifYap.Click += new System.EventHandler(this.btnKategoriPasifYap_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(490, 160);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(36, 26);
            this.btnKategoriEkle.TabIndex = 38;
            this.btnKategoriEkle.Text = "+";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriListele
            // 
            this.btnKategoriListele.Location = new System.Drawing.Point(301, 159);
            this.btnKategoriListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriListele.Name = "btnKategoriListele";
            this.btnKategoriListele.Size = new System.Drawing.Size(182, 27);
            this.btnKategoriListele.TabIndex = 37;
            this.btnKategoriListele.Text = "Kategoriye Göre Listele";
            this.btnKategoriListele.UseVisualStyleBackColor = true;
            this.btnKategoriListele.Click += new System.EventHandler(this.btnKategoriListele_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(92, 159);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(202, 37);
            this.cmbKategori.TabIndex = 35;
            // 
            // FrmYoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 576);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.btnKategoriPasifYap);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnKategoriListele);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnNumaraVer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSoruNo);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.rchSoru);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoruArama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmYoneticiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmYoneticiEkrani_FormClosing);
            this.Load += new System.EventHandler(this.FrmYoneticiEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtSoruArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.RichTextBox rchSoru;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtSoruNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNumaraVer;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriPasifYap;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriListele;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}