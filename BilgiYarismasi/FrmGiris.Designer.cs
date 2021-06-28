
namespace BilgiYarismasi
{
    partial class FrmGiris
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
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.btnSkorlar = new System.Windows.Forms.Button();
            this.lnkKayitOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(202, 111);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(177, 8);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı=";
            // 
            // txtSifre
            // 
            this.txtSifre.AutoSize = true;
            this.txtSifre.Location = new System.Drawing.Point(124, 40);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(34, 13);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.Text = "Şifre=";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(177, 37);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciSifre.TabIndex = 3;
            // 
            // btnSkorlar
            // 
            this.btnSkorlar.Location = new System.Drawing.Point(111, 111);
            this.btnSkorlar.Name = "btnSkorlar";
            this.btnSkorlar.Size = new System.Drawing.Size(75, 23);
            this.btnSkorlar.TabIndex = 5;
            this.btnSkorlar.Text = "Skorlar";
            this.btnSkorlar.UseVisualStyleBackColor = true;
            this.btnSkorlar.Click += new System.EventHandler(this.btnSkorlar_Click);
            // 
            // lnkKayitOl
            // 
            this.lnkKayitOl.AutoSize = true;
            this.lnkKayitOl.Location = new System.Drawing.Point(222, 74);
            this.lnkKayitOl.Name = "lnkKayitOl";
            this.lnkKayitOl.Size = new System.Drawing.Size(43, 13);
            this.lnkKayitOl.TabIndex = 6;
            this.lnkKayitOl.TabStop = true;
            this.lnkKayitOl.Text = "Kayit Ol";
            this.lnkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUyeOl_LinkClicked);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 146);
            this.Controls.Add(this.lnkKayitOl);
            this.Controls.Add(this.btnSkorlar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGirisYap);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Button btnSkorlar;
        private System.Windows.Forms.LinkLabel lnkKayitOl;
    }
}