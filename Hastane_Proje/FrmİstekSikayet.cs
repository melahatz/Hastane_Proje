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
    public partial class FrmİstekSikayet : Form
    {
        public FrmİstekSikayet()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnİstekSikayet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_İstek(İstek) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Rchİstek.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İstek Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnSikayet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Sikayet(Sikayet) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", RchSikayet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şikayet Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Hide();
        }
    }
}
