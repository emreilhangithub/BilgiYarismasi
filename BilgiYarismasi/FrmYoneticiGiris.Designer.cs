﻿
namespace BilgiYarismasi
{
    partial class FrmYoneticiGiris
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
            this.txtSifre = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.AutoSize = true;
            this.txtSifre.Location = new System.Drawing.Point(51, 44);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(34, 13);
            this.txtSifre.TabIndex = 12;
            this.txtSifre.Text = "Şifre=";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(104, 41);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciSifre.TabIndex = 11;
            this.txtKullaniciSifre.Text = "123";
            this.txtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı=";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(104, 12);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 9;
            this.txtKullaniciAdi.Text = "test2";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(129, 89);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 23);
            this.btnGirisYap.TabIndex = 8;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // FrmYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 124);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnGirisYap);
            this.Name = "FrmYoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGirisYap;
    }
}