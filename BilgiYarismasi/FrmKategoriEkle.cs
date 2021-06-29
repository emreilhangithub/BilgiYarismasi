using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BilgiYarismasi
{
    public partial class FrmKategoriEkle : Form
    {
        public FrmKategoriEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        Kategoriler kategoriler = new Kategoriler();
        bool mukerrerKategoriDurum;

        void kategoriMukerrerKontrol()
        {
            SqlCommand komut = new SqlCommand("select Kategori_Adi from Tbl_Kategoriler where Kategori_Adi=@Kategori_Adi", bgl.baglanti());
            komut.Parameters.AddWithValue("@Kategori_Adi", txtKategoriAdi.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                mukerrerKategoriDurum = true;
            }
            else
            {
                mukerrerKategoriDurum = false;
            }
            bgl.baglanti().Close();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            kategoriler.Kategori_Adi1 = txtKategoriAdi.Text;

            if
               (
               string.IsNullOrEmpty(txtKategoriAdi.Text)              
               )
            {
                MessageBox.Show("Lütfen Kategori Adı Giriniz");
                return;
            }

            kategoriMukerrerKontrol();
            if (mukerrerKategoriDurum == false) //yoksa kayit et
            {
                SqlCommand kaydetkomutu = new SqlCommand("INSERT INTO Tbl_Kategoriler (Kategori_Adi) VALUES(@Kategori_Adi)", bgl.baglanti());
                kaydetkomutu.Parameters.AddWithValue("@Kategori_Adi", kategoriler.Kategori_Adi1);
                int adet = kaydetkomutu.ExecuteNonQuery();
                if (adet > 0)
                {
                    MessageBox.Show("Kategori Ekleme İşlemi Başarılı");
                    FrmYoneticiEkrani fr = new FrmYoneticiEkrani();
                    fr.kategoriGetir();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ekleme Başarısız");
                }                
                bgl.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Kayıtlı Müşteri Numarası tekrar deneyiniz");
            }

           
        }
    }
}
