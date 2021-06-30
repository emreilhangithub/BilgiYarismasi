
namespace BilgiYarismasi
{
    partial class FrmKategoriGuncelle
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
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chcDurum = new System.Windows.Forms.CheckBox();
            this.cmbKategoriAdi = new System.Windows.Forms.ComboBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(147, 107);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriGuncelle.TabIndex = 5;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Adı";
            // 
            // chcDurum
            // 
            this.chcDurum.AutoSize = true;
            this.chcDurum.Location = new System.Drawing.Point(147, 84);
            this.chcDurum.Name = "chcDurum";
            this.chcDurum.Size = new System.Drawing.Size(75, 17);
            this.chcDurum.TabIndex = 7;
            this.chcDurum.Text = "Aktif/Pasif";
            this.chcDurum.UseVisualStyleBackColor = true;
            // 
            // cmbKategoriAdi
            // 
            this.cmbKategoriAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriAdi.FormattingEnabled = true;
            this.cmbKategoriAdi.Location = new System.Drawing.Point(101, 26);
            this.cmbKategoriAdi.Name = "cmbKategoriAdi";
            this.cmbKategoriAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbKategoriAdi.TabIndex = 8;
            this.cmbKategoriAdi.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriAdi_SelectedIndexChanged);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(101, 53);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKategoriAdi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kategori Adı";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(228, 24);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(55, 23);
            this.btnSec.TabIndex = 11;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // FrmKategoriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 142);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.cmbKategoriAdi);
            this.Controls.Add(this.chcDurum);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.label1);
            this.Name = "FrmKategoriGuncelle";
            this.Text = "Kategori Güncelleme";
            this.Load += new System.EventHandler(this.FrmKategoriGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chcDurum;
        private System.Windows.Forms.ComboBox cmbKategoriAdi;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSec;
    }
}