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
        Sorular sorular = new Sorular();

        void yeniOyunBaslat()
        {
            rchSoru.Text = "Oyunu Başlatmak İçin Lütfen BAŞLAT Butonuna Basın";
            sikVisible(true); ///butona basınca şıkları gösterdik
            skorlar.Soru_Sayisi1 = 0;
            skorlar.Dogru_Sayisi1 = 0;
            skorlar.Yanlis_Sayisi1 = 0;
            LblSorunno.Text = skorlar.Soru_Sayisi1.ToString();
            LblDogru.Text = skorlar.Dogru_Sayisi1.ToString();          
            LblYanlis.Text = skorlar.Yanlis_Sayisi1.ToString();
            btnOyunuBaslat.Visible = true;
            BtnYeniOyunBaslat.Visible = false;
            pnlSkorlar.Visible = true;
        }

        void oyunBitir(int sorusayisi)
        {
            skorlar.Skor1 = skorlar.Dogru_Sayisi1 * 5;
            rchSoru.Text = "Oyun Bitti Yeni Oyun Başlat Butonuna Basınız...";
            LblSorunno.Text = "Bitti";
            sikVisible(false); //butona basınca oyun bitti ise şıkları sakladık
            sikEnabled(false);
            sikBaslangic();//siklari ilk haline getirdik
            BtnSonrakiSoru.Visible = false;
            btnOyunuBitir.Visible = false;
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
            sikEnabled(false);//butona tıklamayı engelledik burada tekrar tıklanmaması için
            //BtnSonraki.Enabled = true; // eğer boş bırakılmasını engellemek istiyotrsan bunu sonraki butonu aktif etmen gerekiyor
        }

        void sikEnabled(bool durum)
        {
            BtnA.Enabled = durum;
            BtnB.Enabled = durum;
            BtnC.Enabled = durum;
            BtnD.Enabled = durum;
            BtnE.Enabled = durum;
        }

        void sikVisible(bool durum)
        {
            BtnA.Visible = durum;
            BtnB.Visible = durum;
            BtnC.Visible = durum;
            BtnD.Visible = durum;
            BtnE.Visible = durum;
        }

        void sikBaslangic()
        {
            BtnA.Text = "A";
            BtnB.Text = "B";
            BtnC.Text = "C";
            BtnD.Text = "D";
            BtnE.Text = "E";
        }

        void sorulariGetir()
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

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            skorlar.Soru_Sayisi1=1; //oyun baslayınca 1.soruyu getir
            LblSorunno.Text = skorlar.Soru_Sayisi1.ToString(); // 1.soruyu labele at
            sikEnabled(true); //oyun baslayınca sıkları aktif hale getir
            btnOyunuBaslat.Visible = false;
            BtnSonrakiSoru.Visible = true;
            btnOyunuBitir.Visible = true; //oyun baslayınca butonu aktif hale getir
            btnOyunuBitir.Enabled = true; // oyun baslayınca butona basabilsinler
            pnlSkorlar.Visible = false; //oyun baslayınca skorlar panelini gizledik

            sorulariGetir();
        }

        private void BtnSonrakiSoru_Click(object sender, EventArgs e)
        {
            sikEnabled(true); //sonraki butona basınca şıkları basmayı engellemeyi kaldırdık
            //BtnSonraki.Enabled = true; //butona basınca sonrakinin özellgini engellersek boş cevap vermez bize      
            pctDogruCevap.Visible = false; //sonrakine her bastgında resimleri gizledik
            pctYanlisCevap.Visible = false;    

            //soruno = soruno + 1; aynı mantık
            skorlar.Soru_Sayisi1++; //butona her bastıgımızda burada sorunumarasını bire birer artıracagız
            LblSorunno.Text = skorlar.Soru_Sayisi1.ToString();

            if (skorlar.Soru_Sayisi1 != 0)
            {
                sorulariGetir();
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


        private void btnOyunuBitir_Click(object sender, EventArgs e)
        {
            int sorusayisi = int.Parse(LblSorunno.Text);

            oyunBitir(sorusayisi);            
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

        private void FrmOyun_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
