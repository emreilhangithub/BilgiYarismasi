using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BilgiYarismasi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()  //method
        { //baglan nesne
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-E9UTSVL;Initial Catalog=BilgiYarismasi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }     

    }
}
