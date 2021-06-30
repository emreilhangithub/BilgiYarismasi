using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BilgiYarismasi
{
    public partial class FrmYoneticiEkrani : Form
    {
        public FrmYoneticiEkrani()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        Sorular sorular = new Sorular();
        Kategoriler kategoriler = new Kategoriler();
        public string yoneticiAdi;
        private int yoneticiId;
        private int sonSoru;

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Soru_id,Soru_No,Soru,A,B,C,D,E,Cevap,Kat.Kategori_Adi FROM Tbl_Sorular as Sor INNER JOIN Tbl_Kategoriler as Kat ON Sor.Kategori_Id = Kat.Kategori_Id ORDER BY Soru_No DESC;", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            txtId.Clear();
            rchSoru.Clear();
            txtSoruNo.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            txtE.Clear();
            txtCevap.Clear();
            txtSoruArama.Clear();
        }

        public void kategoriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kategoriler where Kategori_Durum=1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKategori.DataSource = dt;
            cmbKategori.DisplayMember = "Kategori_Adi";
            cmbKategori.ValueMember = "Kategori_Id";
        }

        void sonSoruGetir()

        {
            //bitiş soru sayısını ekldik
            SqlCommand komut3 = new SqlCommand("  SELECT MAX(Soru_No)+1 FROM Tbl_Sorular", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                sonSoru = int.Parse(dr3[0].ToString());
                txtSoruNo.Text =dr3[0].ToString();
            }
        }

        private void FrmYoneticiEkrani_Load(object sender, EventArgs e)
        {
            Listele();
            kategoriGetir();
            sonSoruGetir();

            //Yöneticinin idsini aldık        

            SqlCommand yoneticiIdAl = new SqlCommand("select Yonetici_Id from Tbl_Yoneticiler where Yonetici_Adi=@Yonetici_Adi", bgl.baglanti());
            yoneticiIdAl.Parameters.AddWithValue("@Yonetici_Adi", yoneticiAdi);
            SqlDataReader dr1 = yoneticiIdAl.ExecuteReader();

            while (dr1.Read())
            {
                yoneticiId = int.Parse(dr1[0].ToString());
            }          
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sorular.Soru1 = rchSoru.Text;
            sorular.Soru_No1 = sonSoru;
            sorular.A1 = txtA.Text;
            sorular.B1 = txtB.Text;
            sorular.C1 = txtC.Text;
            sorular.D1 = txtD.Text;
            sorular.E1 = txtE.Text;
            sorular.Cevap1 = txtCevap.Text;
            kategoriler.Kategori_Id1 = int.Parse(cmbKategori.SelectedValue.ToString());

            if
                (
                string.IsNullOrEmpty(rchSoru.Text) ||
                string.IsNullOrEmpty(txtA.Text) ||
                string.IsNullOrEmpty(txtB.Text) ||
                string.IsNullOrEmpty(txtC.Text) ||
                string.IsNullOrEmpty(txtD.Text) ||
                string.IsNullOrEmpty(txtE.Text) ||
                string.IsNullOrEmpty(txtCevap.Text)
                )
            {
                MessageBox.Show("Lütfen Tüm Alanları eksiksiz doldurunuz");
                return;
            }

            if (sorular.A1 != sorular.Cevap1 && sorular.B1 != sorular.Cevap1 && sorular.C1 != sorular.Cevap1 && sorular.D1 != sorular.Cevap1 && sorular.E1 != sorular.Cevap1)
            {
                MessageBox.Show("Lütfen şıklarda olan bir cevabı giriniz");
                return;
            }


            SqlCommand kaydetkomutu = new SqlCommand("INSERT INTO Tbl_Sorular (Soru,Soru_No,A,B,C,D,E,Cevap,Soruyu_Ekleyen,Kategori_Id) VALUES(@Soru,@Soru_No,@A,@B,@C,@D,@E,@Cevap,@Soruyu_Ekleyen,@Kategori_Id)", bgl.baglanti());
            kaydetkomutu.Parameters.AddWithValue("@Soru", sorular.Soru1);
            kaydetkomutu.Parameters.AddWithValue("@Soru_No", sonSoru);
            kaydetkomutu.Parameters.AddWithValue("@A", sorular.A1);
            kaydetkomutu.Parameters.AddWithValue("@B", sorular.B1);
            kaydetkomutu.Parameters.AddWithValue("@C", sorular.C1);
            kaydetkomutu.Parameters.AddWithValue("@D", sorular.D1);
            kaydetkomutu.Parameters.AddWithValue("@E", sorular.E1);
            kaydetkomutu.Parameters.AddWithValue("@Cevap", sorular.Cevap1);
            kaydetkomutu.Parameters.AddWithValue("@Soruyu_Ekleyen", yoneticiId);
            kaydetkomutu.Parameters.AddWithValue("@Kategori_Id", kategoriler.Kategori_Id1);
            int adet = kaydetkomutu.ExecuteNonQuery();
            if (adet > 0)
            {
                MessageBox.Show("Ekleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Ekleme Başarısız");
            }
            bgl.baglanti().Close();
            Temizle();
            Listele();
            sonSoruGetir();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris fr = new FrmKullaniciGiris();
            fr.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand silmekomutu = new SqlCommand("DELETE FROM Tbl_Sorular WHERE Soru_id=@Soru_id", bgl.baglanti());
            silmekomutu.Parameters.AddWithValue("@Soru_id", txtId.Text);
            int adet = silmekomutu.ExecuteNonQuery();
            if (adet > 0)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Silme Başarısız");
            }
            bgl.baglanti().Close();
            Temizle();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSoruNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rchSoru.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtA.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtC.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtD.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtE.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCevap.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sorular.Soru1 = rchSoru.Text;
            sorular.Soru_No1 = int.Parse(txtSoruNo.Text);
            sorular.A1 = txtA.Text;
            sorular.B1 = txtB.Text;
            sorular.C1 = txtC.Text;
            sorular.D1 = txtD.Text;
            sorular.E1 = txtE.Text;
            sorular.Cevap1 = txtCevap.Text;
            kategoriler.Kategori_Id1 = int.Parse(cmbKategori.SelectedValue.ToString());

            if
               (
               string.IsNullOrEmpty(rchSoru.Text) ||
               string.IsNullOrEmpty(txtSoruNo.Text) ||
               string.IsNullOrEmpty(txtA.Text) ||
               string.IsNullOrEmpty(txtB.Text) ||
               string.IsNullOrEmpty(txtC.Text) ||
               string.IsNullOrEmpty(txtD.Text) ||
               string.IsNullOrEmpty(txtE.Text) ||
               string.IsNullOrEmpty(txtCevap.Text)
               )
            {
                MessageBox.Show("Lütfen Tüm Alanları eksiksiz doldurunuz");
                return;
            }

            if (sorular.A1 != sorular.Cevap1 && sorular.B1 != sorular.Cevap1 && sorular.C1 != sorular.Cevap1 && sorular.D1 != sorular.Cevap1 && sorular.E1 != sorular.Cevap1)
            {
                MessageBox.Show("Lütfen şıklarda olan bir cevabı giriniz");
                return;
            }

            SqlCommand guncellekomutu = new SqlCommand("UPDATE Tbl_Sorular SET Soru=@Soru,A=@A,B=@B,C=@C,D=@D,E=@E,Cevap=@Cevap,Soruyu_Guncelleyen=@Soruyu_Guncelleyen,Kategori_Id=@Kategori_Id WHERE Soru_id=@Soru_id", bgl.baglanti());
            guncellekomutu.Parameters.AddWithValue("@Soru", rchSoru.Text);
            guncellekomutu.Parameters.AddWithValue("@A", txtA.Text);
            guncellekomutu.Parameters.AddWithValue("@B", txtB.Text);
            guncellekomutu.Parameters.AddWithValue("@C", txtC.Text);
            guncellekomutu.Parameters.AddWithValue("@D", txtD.Text);
            guncellekomutu.Parameters.AddWithValue("@E", txtE.Text);
            guncellekomutu.Parameters.AddWithValue("@Cevap", txtCevap.Text);
            guncellekomutu.Parameters.AddWithValue("@Soruyu_Guncelleyen", yoneticiId);
            guncellekomutu.Parameters.AddWithValue("@Soru_id", txtId.Text);
            guncellekomutu.Parameters.AddWithValue("@Kategori_Id", kategoriler.Kategori_Id1);
            int adet = guncellekomutu.ExecuteNonQuery();
            if (adet > 0)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
            bgl.baglanti().Close();
            //Temizle();
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if
                (
                string.IsNullOrEmpty(txtSoruArama.Text)
                )
            {
                MessageBox.Show("Lütfen arama kutusunu doldurunuz");
                return;
            }

            SqlCommand aramakomutu = new SqlCommand("Select * from Tbl_Sorular where Soru like '%" + txtSoruArama.Text + "%' ", bgl.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(aramakomutu);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            //txtId.Text = cmbKategori.SelectedValue.ToString();
            kategoriler.Kategori_Id1 = int.Parse(cmbKategori.SelectedValue.ToString());

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Soru_id,Soru_No,Soru,A,B,C,D,E,Cevap,Kat.Kategori_Adi FROM Tbl_Sorular as Sor INNER JOIN Tbl_Kategoriler as Kat ON Sor.Kategori_Id = Kat.Kategori_Id  where Sor.Kategori_Id=@Kategori_Id ORDER BY Soru_No DESC", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@Kategori_Id", kategoriler.Kategori_Id1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FrmKategoriEkle fr = new FrmKategoriEkle();
            fr.ShowDialog();
            kategoriGetir();
        }

        private void btnNumaraVer_Click(object sender, EventArgs e)
        {
            sonSoruGetir();
        }

        private void btnKategoriPasifYap_Click(object sender, EventArgs e)
        {
            kategoriler.Kategori_Id1 = (int)cmbKategori.SelectedValue;

            SqlCommand silmekomutu = new SqlCommand("Update Tbl_Kategoriler SET Kategori_Durum=0 WHERE Kategori_Id=@Kategori_Id", bgl.baglanti());
            silmekomutu.Parameters.AddWithValue("@Kategori_Id", kategoriler.Kategori_Id1);
            int adet = silmekomutu.ExecuteNonQuery();
            if (adet > 0)
            {
                MessageBox.Show("Kategori Pasif Hale Getirildi Başarılı");
            }
            else
            {
                MessageBox.Show("Kategori Pasif Hale Getirilemedi Başarısız");
            }
            bgl.baglanti().Close();
            kategoriGetir();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            FrmKategoriGuncelle fr = new FrmKategoriGuncelle();
            fr.ShowDialog();
            kategoriGetir();
        }
    }
}
