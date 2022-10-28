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
    public partial class FrmHastaSifremiUnuttum : Form
    {
        public FrmHastaSifremiUnuttum()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaSifre=@p4 where HastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("p6",MskTc.Text);
            komut2.ExecuteNonQuery(); //KAYDETMEK İÇİN İNSERT UPDATE DELETE
            bgl.baglanti().Close();
            MessageBox.Show("Şifreniz Yenilendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
