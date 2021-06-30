using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BilgiYarismasi
{
    public partial class FrmOyun : Form
    {
        public FrmOyun()
        {
            InitializeComponent();
        }

        //int soruno = 0, dogru = 0, yanlis = 0, bitisSoruSayisi;
        sqlbaglantisi bgl = new sqlbaglantisi();
        Skorlar skorlar = new Skorlar();

        void yeniOyunBaslat()
        {
            rchSoru.Text = "Oyunu Başlatmak İçin Lütfen BAŞLAT Butonuna Basın";
            BtnA.Text = "A";
            BtnB.Text = "B";
            BtnC.Text = "C";
            BtnD.Text = "D";
            BtnE.Text = "E";
            skorlar.Soru_Sayisi1 = 0;
            skorlar.Dogru_Sayisi1 = 0;
            skorlar.Yanlis_Sayisi1 = 0;
            LblSorunno.Text = skorlar.Soru_Sayisi1.ToString();
            LblDogru.Text = skorlar.Dogru_Sayisi1.ToString();          
            LblYanlis.Text = skorlar.Yanlis_Sayisi1.ToString();
            BtnSonraki.Text = "Başlat";
            BtnSonraki.Enabled = true;
            BtnYeniOyunBaslat.Visible = false;
            pnlSkorlar.Visible = true;
        }

        void oyunBitir(int sorusayisi)
        {
            skorlar.Skor1 = skorlar.Dogru_Sayisi1 * 5;
            rchSoru.Text = "";
            LblSorunno.Text = "Bitti";
            BtnSonraki.Text = "Sonuçlar";
            BtnA.Enabled = false; //butona basınca sayac 4 ise şıkları engelledik
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnE.Enabled = false;
            BtnSonraki.Enabled = false;
            btnBitir.Enabled = false;
            BtnYeniOyunBaslat.Visible = true;
            pctDogruCevap.Visible = false;
            pctYanlisCevap.Visible = false;


            SqlCommand skorkayit = new SqlCommand("INSERT INTO Tbl_Skorlar (Skor,Soru_Sayisi,Dogru_Sayisi,Yanlis_Sayisi,Kullanici_Id) VALUES (@Skor,@Soru_Sayisi,@Dogru_Sayisi,@Yanlis_Sayisi,@Kullanici_Id)", bgl.baglanti());
            skorkayit.Parameters.AddWithValue("@Skor", skorlar.Skor1);
            skorkayit.Parameters.AddWithValue("@Soru_Sayisi", sorusayisi);
            skorkayit.Parameters.AddWithValue("@Dogru_Sayisi", skorlar.Dogru_Sayisi1);
            skorkayit.Parameters.AddWithValue("@Yanlis_Sayisi", skorlar.Yanlis_Sayisi1);
            skorkayit.Parameters.AddWithValue("@Kullanici_Id", VeriTasima.kullaniciId);
            skorkayit.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Soru Sayısı " + sorusayisi + " Doğru: " + skorlar.Dogru_Sayisi1 + "\n" + "Yanlış:" + skorlar.Yanlis_Sayisi1 + "Skorunuz:" + skorlar.Skor1);
        }

        void dogruCevap()
        {
            skorlar.Dogru_Sayisi1++;
            LblDogru.Text = skorlar.Dogru_Sayisi1.ToString();
            pctDogruCevap.Visible = true;
        }

        void yanlisCevap()
        {
            skorlar.Yanlis_Sayisi1++;
            LblYanlis.Text = skorlar.Yanlis_Sayisi1.ToString();
            pctYanlisCevap.Visible = true;
        }

        void cevapVerildi()
        {            
            BtnA.Enabled = false; //butona tıklamayı engelledik burada tekrar tıklanmaması için
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnE.Enabled = false;
            //BtnSonraki.Enabled = true; // eğer boş bırakılmasını engellemek istiyotrsan bunu sonraki butonu aktif etmen gerekiyor
        }


        private void FrmOyun_Load(object sender, EventArgs e)
        {
            //kullanıcı adını idsini set ettik
            SqlCommand kullaniciCek = new SqlCommand("  SELECT * FROM Tbl_Kullanicilar where Kullanici_Adi=@Kullanici_Adi", bgl.baglanti());
            kullaniciCek.Parameters.AddWithValue("@Kullanici_Adi", VeriTasima.kullaniciAdi);
            SqlDataReader drKullaniciOku = kullaniciCek.ExecuteReader();
            while (drKullaniciOku.Read())
            {
                VeriTasima.kullaniciId = (int)drKullaniciOku[0];
            }

            //En yüksek skor            
            SqlCommand komut1 = new SqlCommand("SELECT TOP 1 MAX(s.skor), k.Kullanici_Id FROM Tbl_Skorlar as s INNER JOIN Tbl_Kullanicilar as k ON s.Kullanici_Id = k.Kullanici_Id GROUP BY k.Kullanici_Id;", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader(); //burada sıkntı var kullanıcı id basıyor ekrana bunu önder abiye sor
            while (dr1.Read())
            {
                lblEnYuksekSkor.Text = dr1[0] + " " + dr1[1];
            }

            //En yüksek skorum
            SqlCommand komut2 = new SqlCommand("SELECT MAX (Skor) as Skor FROM Tbl_Skorlar where Kullanici_Id=@Kullanici_Id", bgl.baglanti()); //burada sıkıntı var
            komut2.Parameters.AddWithValue("@Kullanici_Id", VeriTasima.kullaniciId);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                lblEnYuksekSkorum.Text = dr2[0].ToString();
            }

            //bitiş soru sayısını ekldik
            SqlCommand komut3 = new SqlCommand("  SELECT MAX(Soru_No)+1 FROM Tbl_Sorular", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                skorlar.Bitis_Sayisi = int.Parse(dr3[0].ToString());
            }

            //skor değerlerini set ettik
            skorlar.Skor1 = 0;
            skorlar.Soru_Sayisi1 = 0;
            skorlar.Dogru_Sayisi1 = 0;
            skorlar.Yanlis_Sayisi1 = 0;
        }




        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true; //butona basınca engellemeyi kaldırdık
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnE.Enabled = true;
            //BtnSonraki.Enabled = true; //butona basınca sonrakinin özellgini engellersek boş cevap vermez bize
            BtnSonraki.Text = "Soraki";
            btnBitir.Visible = true; //oyun baslayınca butonu aktif hale getir
            btnBitir.Enabled = true; // oyun baslayınca butona basabilsinler

            pctDogruCevap.Visible = false; //sonrakine her bastgında görünümü gizledik
            pctYanlisCevap.Visible = false;

            pnlSkorlar.Visible = false;


            //soruno = soruno + 1; aynı mantık
            skorlar.Soru_Sayisi1++; //butona her bastıgımızda burada sorunumarasını bire birer artıracagız
            LblSorunno.Text = skorlar.Soru_Sayisi1.ToString();

            if (skorlar.Soru_Sayisi1 != 0)
            {

                SqlCommand komut = new SqlCommand("select * from Tbl_Sorular where Soru_No = @Soru_No", bgl.baglanti());
                komut.Parameters.AddWithValue("@Soru_No", skorlar.Soru_Sayisi1);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    rchSoru.Text = oku["Soru"].ToString();
                    BtnA.Text = oku["A"].ToString();
                    BtnB.Text = oku["B"].ToString();
                    BtnC.Text = oku["C"].ToString();
                    BtnD.Text = oku["D"].ToString();
                    BtnE.Text = oku["E"].ToString();
                    lblDogruCevap.Text = oku["Cevap"].ToString();
                }

            }


            if (skorlar.Soru_Sayisi1 == skorlar.Bitis_Sayisi)
            {
                int sorusayisi = skorlar.Bitis_Sayisi - 1;
                oyunBitir(sorusayisi);

            }

        }

        private void btnSkorlarim_Click(object sender, EventArgs e)
        {
            FrmSkorlarim fr = new FrmSkorlarim();
            fr.Show();
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            yeniOyunBaslat();
        }


        private void btnBitir_Click(object sender, EventArgs e)
        {
            int sorusayisi = int.Parse(LblSorunno.Text);

            oyunBitir(sorusayisi);            
            btnBitir.Visible = false;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            cevapVerildi();

            lblKisiCevap.Text = BtnA.Text; //label5 eiştirle a şıkkına yani verilen cevaba

            if (lblDogruCevap.Text == lblKisiCevap.Text) //eğer soru cevabı verilen cevaba eşit ise
            {
                dogruCevap();
            }
            else
            {
                yanlisCevap();
            }

        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            cevapVerildi();

            lblKisiCevap.Text = BtnB.Text;

            if (lblDogruCevap.Text == lblKisiCevap.Text)
            {
                dogruCevap();
            }
            else
            {
                yanlisCevap();
            }

        }      

        private void BtnC_Click(object sender, EventArgs e)
        {
            cevapVerildi();

            lblKisiCevap.Text = BtnC.Text;

            if (lblDogruCevap.Text == lblKisiCevap.Text)
            {
                dogruCevap();
            }
            else
            {
                yanlisCevap();

            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            cevapVerildi();

            lblKisiCevap.Text = BtnD.Text;

            if (lblDogruCevap.Text == lblKisiCevap.Text)
            {
                dogruCevap();
            }
            else
            {
                yanlisCevap();

            }
        }


        private void BtnE_Click(object sender, EventArgs e)
        {
            cevapVerildi();

            lblKisiCevap.Text = BtnE.Text;

            if (lblDogruCevap.Text == lblKisiCevap.Text)
            {
                dogruCevap();
            }
            else
            {
                yanlisCevap();
            }
        }



    }
}
