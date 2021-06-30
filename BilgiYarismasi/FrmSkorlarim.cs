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
    public partial class FrmSkorlarim : Form
    {
        public FrmSkorlarim()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();      

        private void FrmSkorlarim_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand("Select Soru_Sayisi,Dogru_Sayisi,Yanlis_Sayisi,Skor  from Tbl_Skorlar where Kullanici_Id=@Kullanici_Id order by Skor DESC", bgl.baglanti());
            komut.Parameters.AddWithValue("@Kullanici_Id", VeriTasima.kullaniciId); //burası değişecek
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            
        }
    }
}
