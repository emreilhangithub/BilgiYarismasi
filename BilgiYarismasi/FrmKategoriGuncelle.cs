using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BilgiYarismasi
{
    public partial class FrmKategoriGuncelle : Form
    {
        public FrmKategoriGuncelle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        Kategoriler kategoriler = new Kategoriler();

        public void kategoriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kategoriler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKategoriAdi.DataSource = dt;
            cmbKategoriAdi.DisplayMember = "Kategori_Adi";
            cmbKategoriAdi.ValueMember = "Kategori_Id";
        }

        private void FrmKategoriGuncelle_Load(object sender, EventArgs e)
        {
            kategoriGetir();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            kategoriler.Kategori_Adi1 = txtKategoriAdi.Text;
            kategoriler.Kategori_Id1 = (int)cmbKategoriAdi.SelectedValue;
            kategoriler.Kategori_Durum1 = chcDurum.Checked;

            //btnKategoriGuncelle.Text = kategoriler.Kategori_Durum1.ToString();
            //btnKategoriGuncelle.Text = kategoriler.Kategori_Adi1;
            //btnKategoriGuncelle.Text = kategoriler.Kategori_Id1.ToString();


            if
               (
               string.IsNullOrEmpty(txtKategoriAdi.Text)
               )
            {
                MessageBox.Show("Lütfen Kategori Adı Giriniz");
                return;
            }


            SqlCommand guncellemekomutu = new SqlCommand("UPDATE Tbl_Kategoriler SET Kategori_Adi = @Kategori_Adi, Kategori_Durum = @Kategori_Durum WHERE Kategori_Id=@Kategori_Id; ", bgl.baglanti());
            guncellemekomutu.Parameters.AddWithValue("@Kategori_Adi", kategoriler.Kategori_Adi1);
            guncellemekomutu.Parameters.AddWithValue("@Kategori_Durum", kategoriler.Kategori_Durum1);
            guncellemekomutu.Parameters.AddWithValue("@Kategori_Id", kategoriler.Kategori_Id1);
            int adet = guncellemekomutu.ExecuteNonQuery();
            if (adet > 0)
            {
                MessageBox.Show("Kategori Güncelleme İşlemi Başarılı");
                FrmYoneticiEkrani fr = new FrmYoneticiEkrani();
                fr.kategoriGetir();
                this.Close();
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
            bgl.baglanti().Close();
        }

        private void cmbKategoriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
           //burada sorun var form girer girmez bir tane seçiligi oldugu için datarader yapamıyoruz
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            kategoriler.Kategori_Id1 = int.Parse(cmbKategoriAdi.SelectedValue.ToString());

            SqlCommand komut1 = new SqlCommand("select Kategori_Adi,Kategori_Durum  from Tbl_Kategoriler where Kategori_Id=@Kategori_Id", bgl.baglanti());
            komut1.Parameters.AddWithValue("@Kategori_Id", kategoriler.Kategori_Id1);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                txtKategoriAdi.Text = dr1[0].ToString();
                bool durum = bool.Parse(dr1[1].ToString());
                if (durum == true)
                {
                    chcDurum.Checked = true;
                }
                else
                {
                    chcDurum.Checked = false;
                }
            }

            bgl.baglanti().Close();
        }
    }
}
