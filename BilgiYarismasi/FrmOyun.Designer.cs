
namespace BilgiYarismasi
{
    partial class FrmOyun
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOyun));
            this.rchSoru = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSorunno = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.pctDogruCevap = new System.Windows.Forms.PictureBox();
            this.pctYanlisCevap = new System.Windows.Forms.PictureBox();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.lblKisiCevap = new System.Windows.Forms.Label();
            this.BtnYeniOyunBaslat = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.BtnE = new System.Windows.Forms.Button();
            this.pnlSkorlar = new System.Windows.Forms.Panel();
            this.lblEnYuksekSkorum = new System.Windows.Forms.Label();
            this.lblEnYuksekSkor = new System.Windows.Forms.Label();
            this.lblEnYkskSkrm = new System.Windows.Forms.Label();
            this.lblEnYkskSkor = new System.Windows.Forms.Label();
            this.btnSkorlarim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctDogruCevap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYanlisCevap)).BeginInit();
            this.pnlSkorlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchSoru
            // 
            this.rchSoru.Location = new System.Drawing.Point(21, 8);
            this.rchSoru.Margin = new System.Windows.Forms.Padding(2);
            this.rchSoru.Name = "rchSoru";
            this.rchSoru.Size = new System.Drawing.Size(366, 139);
            this.rchSoru.TabIndex = 0;
            this.rchSoru.Text = "Oyunu Başlatmak İçin Lütfen BAŞLAT Butonuna Basın\nHer bir doğru 5 puandır başarıl" +
    "ar ...";
            // 
            // BtnA
            // 
            this.BtnA.Enabled = false;
            this.BtnA.Location = new System.Drawing.Point(21, 159);
            this.BtnA.Margin = new System.Windows.Forms.Padding(2);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(120, 38);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Enabled = false;
            this.BtnB.Location = new System.Drawing.Point(158, 159);
            this.BtnB.Margin = new System.Windows.Forms.Padding(2);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(96, 38);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Enabled = false;
            this.BtnC.Location = new System.Drawing.Point(269, 159);
            this.BtnC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(105, 38);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Enabled = false;
            this.BtnD.Location = new System.Drawing.Point(21, 201);
            this.BtnD.Margin = new System.Windows.Forms.Padding(2);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(173, 38);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış";
            // 
            // LblSorunno
            // 
            this.LblSorunno.AutoSize = true;
            this.LblSorunno.Location = new System.Drawing.Point(459, 18);
            this.LblSorunno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSorunno.Name = "LblSorunno";
            this.LblSorunno.Size = new System.Drawing.Size(13, 13);
            this.LblSorunno.TabIndex = 8;
            this.LblSorunno.Text = "0";
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.Location = new System.Drawing.Point(459, 42);
            this.LblDogru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(13, 13);
            this.LblDogru.TabIndex = 9;
            this.LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Location = new System.Drawing.Point(459, 69);
            this.LblYanlis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(13, 13);
            this.LblYanlis.TabIndex = 10;
            this.LblYanlis.Text = "0";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(390, 97);
            this.BtnSonraki.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(139, 38);
            this.BtnSonraki.TabIndex = 11;
            this.BtnSonraki.Text = "Başlat";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // pctDogruCevap
            // 
            this.pctDogruCevap.Image = ((System.Drawing.Image)(resources.GetObject("pctDogruCevap.Image")));
            this.pctDogruCevap.Location = new System.Drawing.Point(389, 190);
            this.pctDogruCevap.Margin = new System.Windows.Forms.Padding(2);
            this.pctDogruCevap.Name = "pctDogruCevap";
            this.pctDogruCevap.Size = new System.Drawing.Size(65, 77);
            this.pctDogruCevap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDogruCevap.TabIndex = 12;
            this.pctDogruCevap.TabStop = false;
            this.pctDogruCevap.Visible = false;
            // 
            // pctYanlisCevap
            // 
            this.pctYanlisCevap.Image = ((System.Drawing.Image)(resources.GetObject("pctYanlisCevap.Image")));
            this.pctYanlisCevap.Location = new System.Drawing.Point(462, 190);
            this.pctYanlisCevap.Margin = new System.Windows.Forms.Padding(2);
            this.pctYanlisCevap.Name = "pctYanlisCevap";
            this.pctYanlisCevap.Size = new System.Drawing.Size(65, 77);
            this.pctYanlisCevap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctYanlisCevap.TabIndex = 13;
            this.pctYanlisCevap.TabStop = false;
            this.pctYanlisCevap.Visible = false;
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Location = new System.Drawing.Point(318, 254);
            this.lblDogruCevap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(70, 13);
            this.lblDogruCevap.TabIndex = 14;
            this.lblDogruCevap.Text = "Doğru Cevap";
            this.lblDogruCevap.Visible = false;
            // 
            // lblKisiCevap
            // 
            this.lblKisiCevap.AutoSize = true;
            this.lblKisiCevap.Location = new System.Drawing.Point(315, 274);
            this.lblKisiCevap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKisiCevap.Name = "lblKisiCevap";
            this.lblKisiCevap.Size = new System.Drawing.Size(73, 13);
            this.lblKisiCevap.TabIndex = 15;
            this.lblKisiCevap.Text = "Kişinin Cevabı";
            this.lblKisiCevap.Visible = false;
            // 
            // BtnYeniOyunBaslat
            // 
            this.BtnYeniOyunBaslat.Location = new System.Drawing.Point(403, 279);
            this.BtnYeniOyunBaslat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnYeniOyunBaslat.Name = "BtnYeniOyunBaslat";
            this.BtnYeniOyunBaslat.Size = new System.Drawing.Size(125, 25);
            this.BtnYeniOyunBaslat.TabIndex = 16;
            this.BtnYeniOyunBaslat.Text = "Yeni Oyun Başlat";
            this.BtnYeniOyunBaslat.UseVisualStyleBackColor = true;
            this.BtnYeniOyunBaslat.Visible = false;
            this.BtnYeniOyunBaslat.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(391, 139);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(2);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(139, 38);
            this.btnBitir.TabIndex = 23;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Visible = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // BtnE
            // 
            this.BtnE.Enabled = false;
            this.BtnE.Location = new System.Drawing.Point(198, 201);
            this.BtnE.Margin = new System.Windows.Forms.Padding(2);
            this.BtnE.Name = "BtnE";
            this.BtnE.Size = new System.Drawing.Size(176, 38);
            this.BtnE.TabIndex = 24;
            this.BtnE.Text = "E";
            this.BtnE.UseVisualStyleBackColor = true;
            this.BtnE.Click += new System.EventHandler(this.BtnE_Click);
            // 
            // pnlSkorlar
            // 
            this.pnlSkorlar.Controls.Add(this.lblEnYuksekSkorum);
            this.pnlSkorlar.Controls.Add(this.lblEnYkskSkor);
            this.pnlSkorlar.Controls.Add(this.lblEnYuksekSkor);
            this.pnlSkorlar.Controls.Add(this.btnSkorlarim);
            this.pnlSkorlar.Controls.Add(this.lblEnYkskSkrm);
            this.pnlSkorlar.Location = new System.Drawing.Point(54, 244);
            this.pnlSkorlar.Name = "pnlSkorlar";
            this.pnlSkorlar.Size = new System.Drawing.Size(200, 70);
            this.pnlSkorlar.TabIndex = 25;
            // 
            // lblEnYuksekSkorum
            // 
            this.lblEnYuksekSkorum.AutoSize = true;
            this.lblEnYuksekSkorum.Location = new System.Drawing.Point(151, 19);
            this.lblEnYuksekSkorum.Name = "lblEnYuksekSkorum";
            this.lblEnYuksekSkorum.Size = new System.Drawing.Size(13, 13);
            this.lblEnYuksekSkorum.TabIndex = 30;
            this.lblEnYuksekSkorum.Text = "0";
            // 
            // lblEnYuksekSkor
            // 
            this.lblEnYuksekSkor.AutoSize = true;
            this.lblEnYuksekSkor.Location = new System.Drawing.Point(151, 5);
            this.lblEnYuksekSkor.Name = "lblEnYuksekSkor";
            this.lblEnYuksekSkor.Size = new System.Drawing.Size(13, 13);
            this.lblEnYuksekSkor.TabIndex = 29;
            this.lblEnYuksekSkor.Text = "0";
            // 
            // lblEnYkskSkrm
            // 
            this.lblEnYkskSkrm.AutoSize = true;
            this.lblEnYkskSkrm.Location = new System.Drawing.Point(38, 19);
            this.lblEnYkskSkrm.Name = "lblEnYkskSkrm";
            this.lblEnYkskSkrm.Size = new System.Drawing.Size(107, 13);
            this.lblEnYkskSkrm.TabIndex = 28;
            this.lblEnYkskSkrm.Text = "En Yüksek Skorum =";
            // 
            // lblEnYkskSkor
            // 
            this.lblEnYkskSkor.AutoSize = true;
            this.lblEnYkskSkor.Location = new System.Drawing.Point(52, 5);
            this.lblEnYkskSkor.Name = "lblEnYkskSkor";
            this.lblEnYkskSkor.Size = new System.Drawing.Size(90, 13);
            this.lblEnYkskSkor.TabIndex = 27;
            this.lblEnYkskSkor.Text = "En Yüksek Skor=";
            // 
            // btnSkorlarim
            // 
            this.btnSkorlarim.Location = new System.Drawing.Point(89, 39);
            this.btnSkorlarim.Name = "btnSkorlarim";
            this.btnSkorlarim.Size = new System.Drawing.Size(75, 23);
            this.btnSkorlarim.TabIndex = 26;
            this.btnSkorlarim.Text = "Skorlarım";
            this.btnSkorlarim.UseVisualStyleBackColor = true;
            this.btnSkorlarim.Click += new System.EventHandler(this.btnSkorlarim_Click);
            // 
            // FrmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 326);
            this.Controls.Add(this.pnlSkorlar);
            this.Controls.Add(this.BtnE);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.BtnYeniOyunBaslat);
            this.Controls.Add(this.lblKisiCevap);
            this.Controls.Add(this.lblDogruCevap);
            this.Controls.Add(this.pctYanlisCevap);
            this.Controls.Add(this.pctDogruCevap);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.LblSorunno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.rchSoru);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun";
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDogruCevap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYanlisCevap)).EndInit();
            this.pnlSkorlar.ResumeLayout(false);
            this.pnlSkorlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchSoru;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSorunno;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.PictureBox pctDogruCevap;
        private System.Windows.Forms.PictureBox pctYanlisCevap;
        private System.Windows.Forms.Label lblDogruCevap;
        private System.Windows.Forms.Label lblKisiCevap;
        private System.Windows.Forms.Button BtnYeniOyunBaslat;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button BtnE;
        private System.Windows.Forms.Panel pnlSkorlar;
        private System.Windows.Forms.Label lblEnYuksekSkorum;
        private System.Windows.Forms.Label lblEnYkskSkor;
        private System.Windows.Forms.Label lblEnYuksekSkor;
        private System.Windows.Forms.Button btnSkorlarim;
        private System.Windows.Forms.Label lblEnYkskSkrm;
    }
}

