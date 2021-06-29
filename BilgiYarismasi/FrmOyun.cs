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
    public partial class FrmOyun : Form
    {
        public FrmOyun()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0,bitisSoruSayisi;
        sqlbaglantisi  bgl = new sqlbaglantisi();
        public string kullaniciAdi;
        //Kullanici kullanici = new Kullanici();//kullanıcı bilgisini aldık

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true; //butona basınca engellemeyi kaldırdık
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false; //butona basınca sonrakinin özellgini engelledik
            BtnSonraki.Text = "Soraki";
            
            pictureBox1.Visible = false; //sonrakine her bastgında görünümü gizledik
            pictureBox2.Visible = false;

            btnSkorlarim.Visible = false;
            lblEnYkskSkor.Visible = false;
            lblEnYuksekSkor.Visible = false;
            lblEnYkskSkrm.Visible = false;
            lblEnYuksekSkorum.Visible = false;


            //soruno = soruno + 1; aynı mantık
            soruno++;
            LblSorunno.Text = soruno.ToString();

            if (soruno != 0)
            {
                
                SqlCommand komut = new SqlCommand("select * from Tbl_Sorular where Soru_id = @Soru_id", bgl.baglanti());
                komut.Parameters.AddWithValue("@Soru_id", soruno);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    rchSoru.Text = oku["Soru"].ToString();
                    BtnA.Text = oku["A"].ToString();
                    BtnB.Text = oku["B"].ToString();
                    BtnC.Text = oku["C"].ToString();
                    BtnD.Text = oku["D"].ToString();
                    lblDogruCevap.Text = oku["Cevap"].ToString();
                }
               
            }

           
            int sorusayisi = bitisSoruSayisi - 1;
            int skor = dogru * 5;
            
            if (soruno == bitisSoruSayisi)
            {
                rchSoru.Text = "";
                LblSorunno.Text = "Bitti";
                BtnSonraki.Text = "Sonuçlar";
                BtnA.Enabled = false; //butona basınca sayac 4 ise şıkları engelledik
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;

                
                SqlCommand skorkayit = new SqlCommand("INSERT INTO Tbl_Skorlar (Skor,Soru_Sayisi,Dogru_Sayisi,Yanlis_Sayisi,Kullanici_Adi) VALUES (@Skor,@Soru_Sayisi,@Dogru_Sayisi,@Yanlis_Sayisi,@Kullanici_Adi)", bgl.baglanti());
                skorkayit.Parameters.AddWithValue("@Skor", skor);
                skorkayit.Parameters.AddWithValue("@Soru_Sayisi", sorusayisi);
                skorkayit.Parameters.AddWithValue("@Dogru_Sayisi", dogru);
                skorkayit.Parameters.AddWithValue("@Yanlis_Sayisi", yanlis);
                skorkayit.Parameters.AddWithValue("@Kullanici_Adi", lblkullaniciAdi.Text);
                skorkayit.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Soru Sayısı "+ sorusayisi + " Doğru: " + dogru + "\n" + "Yanlış:" + yanlis + "Skorunuz:" + skor);
                BtnYeniOyunBaslat.Visible = true;

            }

        }



        private void BtnA_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false; //butona tıklamayı engelledik burada
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true; // sonraki butonu aktif ettik


            lblKisiCevap.Text = BtnA.Text; //label5 eiştirle a şıkkına yani verilen cevaba

            if (lblDogruCevap.Text == lblKisiCevap.Text) //eğer soru cevabı verilen cevaba eşit ise
            {
                dogru++; //dorğu sayısını 1 artır
                LblDogru.Text = dogru.ToString(); //texte dorğu sayısını at dönüştür
                pictureBox1.Visible = true; //resmi aktif et
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                
            }

        }       

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            lblKisiCevap.Text = BtnB.Text;

            if (lblDogruCevap.Text == lblKisiCevap.Text) 
            {
                dogru++; 
                LblDogru.Text = dogru.ToString(); 
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }



        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            //Kulanıcı adını çektik
            lblkullaniciAdi.Text = kullaniciAdi;
            //lblkullaniciAdi.Text = kullanici.Kullanici_Adi1;          



            //En yüksek skor            
            SqlCommand komut1 = new SqlCommand("  SELECT TOP 1 MAX(Skor) AS Skor, Kullanici_Adi FROM Tbl_Skorlar GROUP BY Kullanici_Adi", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblEnYuksekSkor.Text = dr1[0] + " " + dr1[1];                
            }



            //En yüksek skorum
            SqlCommand komut2 = new SqlCommand("SELECT MAX (Skor) as Skor FROM Tbl_Skorlar where Kullanici_Adi='@Kullanici_Adi'", bgl.baglanti()); //burada sıkıntı var
            komut1.Parameters.AddWithValue("@Kullanici_Adi", lblkullaniciAdi.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();           

            while (dr2.Read())
            {                
                lblEnYuksekSkorum.Text = dr2[0].ToString();               
            }

            //bitiş soru sayısını ekldik
            SqlCommand komut3 = new SqlCommand("  SELECT MAX(Soru_id)+1 FROM Tbl_Sorular", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                bitisSoruSayisi = int.Parse(dr3[0].ToString());
            }



        }

        private void btnSkorlarim_Click(object sender, EventArgs e)
        {
            FrmSkorlarim fr = new FrmSkorlarim();
             fr.kullaniciAdi=lblkullaniciAdi.Text;
            fr.Show();
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            rchSoru.Text = "Oyunu Başlatmak İçin Lütfen BAŞLAT Butonuna Basın";
            BtnA.Text = "A";
            BtnB.Text = "B";
            BtnC.Text = "C";
            BtnD.Text = "D";
            soruno = 0;
            LblSorunno.Text = soruno.ToString();
            dogru = 0;
            LblDogru.Text = dogru.ToString();
            yanlis = 0;
            LblYanlis.Text = yanlis.ToString();
            BtnSonraki.Text = "Başlat";
            BtnSonraki.Enabled = true;
            BtnYeniOyunBaslat.Visible = false;
            btnSkorlarim.Visible = true;
            lblEnYkskSkor.Visible = true;
            lblEnYuksekSkor.Visible = true;
            lblEnYkskSkrm.Visible = true;
            lblEnYuksekSkorum.Visible = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            lblKisiCevap.Text = BtnC.Text;

            if (lblDogruCevap.Text == lblKisiCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;            

            lblKisiCevap.Text = BtnD.Text;

            if (lblDogruCevap.Text == lblKisiCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

      
    }
}
