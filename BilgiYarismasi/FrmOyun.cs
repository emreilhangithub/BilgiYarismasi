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

        int soruno = 0, dogru = 0, yanlis = 0,bitissorusu=7;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-E9UTSVL;Initial Catalog=BilgiYarismasi;Integrated Security=True");
        public string kullaniciAdi;
        //Kullanici kullanici = new Kullanici();//kullanıcı bilgisini aldık

        private void button5_Click(object sender, EventArgs e)
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
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Tbl_Sorular where Soru_id = @Soru_id", baglanti);
                komut.Parameters.AddWithValue("@Soru_id", soruno);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    richTextBox1.Text = oku["Soru"].ToString();
                    BtnA.Text = oku["A"].ToString();
                    BtnB.Text = oku["B"].ToString();
                    BtnC.Text = oku["C"].ToString();
                    BtnD.Text = oku["D"].ToString();
                    label4.Text = oku["Cevap"].ToString();
                }
                baglanti.Close();
            }

           
            int sorusayisi = bitissorusu - 1;
            int skor = dogru * 5;
            
            if (soruno == bitissorusu)
            {
                richTextBox1.Text = "";
                LblSorunno.Text = "Bitti";
                BtnSonraki.Text = "Sonuçlar";
                BtnA.Enabled = false; //butona basınca sayac 4 ise şıkları engelledik
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;

                baglanti.Open();
                SqlCommand skorkayit = new SqlCommand("INSERT INTO Tbl_Skorlar (Skor,Soru_Sayisi,Dogru_Sayisi,Yanlis_Sayisi,Kullanici_Adi) VALUES (@Skor,@Soru_Sayisi,@Dogru_Sayisi,@Yanlis_Sayisi,@Kullanici_Adi)", baglanti);
                skorkayit.Parameters.AddWithValue("@Skor", skor);
                skorkayit.Parameters.AddWithValue("@Soru_Sayisi", sorusayisi);
                skorkayit.Parameters.AddWithValue("@Dogru_Sayisi", dogru);
                skorkayit.Parameters.AddWithValue("@Yanlis_Sayisi", yanlis);
                skorkayit.Parameters.AddWithValue("@Kullanici_Adi", lblkullaniciAdi.Text);
                skorkayit.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Soru Sayısı "+ sorusayisi + " Doğru: " + dogru + "\n" + "Yanlış:" + yanlis + "Skorunuz:" + skor);
                BtnYeni.Visible = true;

            }

        }



        private void BtnA_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false; //butona tıklamayı engelledik burada
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true; // sonraki butonu aktif ettik


            label5.Text = BtnA.Text; //label5 eiştirle a şıkkına yani verilen cevaba

            if (label4.Text == label5.Text) //eğer soru cevabı verilen cevaba eşit ise
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

            label5.Text = BtnB.Text;

            if (label4.Text == label5.Text) 
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
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("  SELECT TOP 1 MAX(Skor) AS Skor, Kullanici_Adi FROM Tbl_Skorlar GROUP BY Kullanici_Adi", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblEnYuksekSkor.Text = dr1[0] + " " + dr1[1];                
            }

            baglanti.Close();



            //En yüksek skorum
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT MAX (Skor) as Skor FROM Tbl_Skorlar where Kullanici_Adi='@Kullanici_Adi'", baglanti);
            komut1.Parameters.AddWithValue("@Kullanici_Adi", lblkullaniciAdi.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();           

            while (dr2.Read())
            {                
                lblEnYuksekSkorum.Text = dr2[0].ToString();               
            }

            baglanti.Close();



        }

        private void btnSkorlarim_Click(object sender, EventArgs e)
        {
            FrmSkorlarim fr = new FrmSkorlarim();
             fr.kullaniciAdi=lblkullaniciAdi.Text;
            fr.Show();
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Oyunu Başlatmak İçin Lütfen BAŞLAT Butonuna Basın";
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
            BtnYeni.Visible = false;
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

            label5.Text = BtnC.Text;

            if (label4.Text == label5.Text)
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

            label5.Text = BtnD.Text;

            if (label4.Text == label5.Text)
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
