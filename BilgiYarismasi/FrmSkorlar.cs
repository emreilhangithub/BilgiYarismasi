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
    public partial class FrmSkorlar : Form
    {
        public FrmSkorlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmSkorlar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();            
            SqlDataAdapter da = new SqlDataAdapter("Select Kullanici_Adi,Soru_Sayisi,Dogru_Sayisi,Yanlis_Sayisi,Skor from Tbl_Skorlar ORDER BY Skor DESC", bgl.baglanti());
            da.Fill(dt);           
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

        }
    }
}
