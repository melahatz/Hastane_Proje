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

namespace Hastane_Proje
{
    public partial class FrmİstekSikayetListesi : Form
    {
        public FrmİstekSikayetListesi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        

        private void FrmİstekListesi_Load(object sender, EventArgs e)
        {
            //İstek Listesi
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_İstek", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Şikayet Listesi
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Sikayet", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        
    }
}
