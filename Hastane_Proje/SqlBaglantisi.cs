using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //kütüphanemi dahil ettim sql için


namespace Hastane_Proje
{
    
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-B2JOG7A;Initial Catalog=Hastane_Proje;Integrated Security=True");
            baglan.Open(); //sınıfmı çağırdığım zaman bağlantım açık gelsin
            return baglan;
        }
       

    }
}
