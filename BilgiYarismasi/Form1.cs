using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;     

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

            //soruno = soruno + 1; aynı mantık
            soruno++;
            LblSorunno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Beşiktaş hangi yılda kurulmuştur";
                BtnA.Text = "1900";
                BtnB.Text = "1901";
                BtnC.Text = "1902";
                BtnD.Text = "1903";
                label4.Text = "1903";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "İstanbul hangi bölgededir";
                BtnA.Text = "Akdeniz";
                BtnB.Text = "Karadeniz";
                BtnC.Text = "Marmara";
                BtnD.Text = "Ege";
                label4.Text = "Marmara";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Hangisi İstanbulun ilçelerinden biri değildir";
                BtnA.Text = "Küçükçekmece";
                BtnB.Text = "Kadıköy";
                BtnC.Text = "Kartal";
                BtnD.Text = "Adana";
                label4.Text = "Adana";
            }
            if (soruno == 4)
            {
                LblSorunno.Text = "Bitti";
                BtnSonraki.Text = "Sonuçlar";
                BtnA.Enabled = false; //butona basınca sayac 4 ise şıkları engelledik
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış:" + yanlis);
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
