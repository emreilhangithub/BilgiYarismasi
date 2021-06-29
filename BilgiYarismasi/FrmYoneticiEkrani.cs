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

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Soru_id,Soru,A,B,C,D,E,Cevap,Kat.Kategori_Adi FROM Tbl_Sorular as Sor INNER JOIN Tbl_Kategoriler as Kat ON Sor.Kategori_Id = Kat.Kategori_Id ORDER BY Soru_id DESC;", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Temizle()
        {
            txtId.Clear();
            rchSoru.Clear();
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
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kategoriler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKategori.DataSource = dt;
            cmbKategori.DisplayMember = "Kategori_Adi";
            cmbKategori.ValueMember = "Kategori_Id";
        }

        private void FrmYoneticiEkrani_Load(object sender, EventArgs e)
        {
            Listele();
            kategoriGetir();

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



            SqlCommand kaydetkomutu = new SqlCommand("INSERT INTO Tbl_Sorular (Soru,A,B,C,D,E,Cevap,Soruyu_Ekleyen,Kategori_Id) VALUES(@Soru,@A,@B,@C,@D,@E,@Cevap,@Soruyu_Ekleyen,@Kategori_Id)", bgl.baglanti());
            kaydetkomutu.Parameters.AddWithValue("@Soru", sorular.Soru1);
            kaydetkomutu.Parameters.AddWithValue("@A",  sorular.A1);
            kaydetkomutu.Parameters.AddWithValue("@B",  sorular.B1);
            kaydetkomutu.Parameters.AddWithValue("@C",  sorular.C1);
            kaydetkomutu.Parameters.AddWithValue("@D",  sorular.D1);
            kaydetkomutu.Parameters.AddWithValue("@E",  sorular.E1);
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
            rchSoru.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtA.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtC.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtD.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtE.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCevap.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sorular.Soru1 = rchSoru.Text;
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
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Sorular where Kategori_Id=@Kategori_Id", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@Kategori_Id", kategoriler.Kategori_Id1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FrmKategoriEkle fr =  new  FrmKategoriEkle();
            fr.ShowDialog();
            kategoriGetir();
        }
    }
}
