using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BilgiYarismasi
{
    public partial class FrmUyeOl : Form
    {
        public FrmUyeOl()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        Kullanici kullanici = new Kullanici();
        int durum;

        void mukerrerKontrol()
        {
            kullanici.Kullanici_Adi1 = txtKullaniciAdi.Text;
            kullanici.Kullanici_Sifre1 = txtKullaniciSifre.Text;

            SqlCommand mukerrerkontrol = new SqlCommand("SELECT Kullanici_Adi FROM Tbl_Kullanicilar WHERE Kullanici_Adi=@Kullanici_Adi", bgl.baglanti());
            mukerrerkontrol.Parameters.AddWithValue("@Kullanici_Adi", kullanici.Kullanici_Adi1);
            SqlDataReader dr1 = mukerrerkontrol.ExecuteReader();
            if (dr1.Read())
            {
                durum = 1;
            }
            else
            {
                durum = 0;
            }
        }
           


        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            mukerrerKontrol();

            if (durum != 1)
            {

                kullanici.Kullanici_Adi1 = txtKullaniciAdi.Text;
                kullanici.Kullanici_Sifre1 = txtKullaniciSifre.Text;

                SqlCommand kayitkomutu = new SqlCommand("INSERT INTO Tbl_Kullanicilar (Kullanici_Adi,Kullanici_Sifre) VALUES (@Kullanici_Adi,@Kullanici_Sifre)", bgl.baglanti());
                kayitkomutu.Parameters.AddWithValue("@Kullanici_Adi", kullanici.Kullanici_Adi1);
                kayitkomutu.Parameters.AddWithValue("@Kullanici_Sifre", kullanici.Kullanici_Sifre1);
                kayitkomutu.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşti Lütfen Giriş Yapınız");
                FrmKullaniciGiris fr = new FrmKullaniciGiris();
                fr.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Zaten böyle bir kullanıcı adı var lüften baska kullanıcı adı alınız");
            }




        }
    }
}
