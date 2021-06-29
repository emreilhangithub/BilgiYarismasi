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
    public partial class FrmYoneticiGiris : Form
    {
        public FrmYoneticiGiris()
        {
            InitializeComponent();
        }

        Yonetici yonetici = new Yonetici();
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var result = new List<Yonetici>(); //liste oluşturduk         

            SqlCommand cmd = new SqlCommand("select Yonetici_Adi,Yonetici_Sifre from Tbl_Yoneticiler", bgl.baglanti());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            result = dt.AsEnumerable().Select(s => new Yonetici
            {
                Yonetici_Adi1 = s.Field<string>("Yonetici_Adi"),
                Yonetici_Sifre1 = s.Field<string>("Yonetici_Sifre")
            }).ToList();

            var user = result.FirstOrDefault(x => x.Yonetici_Adi1 == txtKullaniciAdi.Text && x.Yonetici_Sifre1 == txtKullaniciSifre.Text);
            if (user != null)
            {
                MessageBox.Show("Giriş başarılı Ana Sayfaya Hoş Geldiniz");
                FrmYoneticiEkrani fr = new FrmYoneticiEkrani();               
                yonetici.Yonetici_Adi1 = txtKullaniciAdi.Text;
                fr.yoneticiAdi = yonetici.Yonetici_Adi1;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz Giriş, lütfen kullanıcı adı ve şifreyi kontrol edin");
            }
        }
    }
}
