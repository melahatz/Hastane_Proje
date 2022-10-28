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
    public partial class FrmKanBagıs : Form
    {
        public FrmKanBagıs()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            if(TxtAd.Text==" " || TxtSoyad.Text==" "|| MskTc.Text==" "||CmbCinsiyet.Text==" "|| MskTel.Text==""||MskEkTel.Text==" "||CmbKanGrubu.Text==" " ||
                TxtAd.Text==String.Empty||TxtSoyad.Text== String.Empty||MskTc.Text== String.Empty||CmbCinsiyet.Text== String.Empty||MskTel.Text== String.Empty||
                MskEkTel.Text== String.Empty||CmbKanGrubu.Text== String.Empty)
            {
                TxtAd.BackColor = Color.SkyBlue;
                TxtSoyad.BackColor = Color.SkyBlue;
                MskTc.BackColor = Color.SkyBlue;
                CmbCinsiyet.BackColor = Color.SkyBlue;
                MskTel.BackColor = Color.SkyBlue;
                MskEkTel.BackColor = Color.SkyBlue;
                CmbKanGrubu.BackColor = Color.SkyBlue;
                MessageBox.Show("Mavi alanlar boş geçilemez","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Bagıs (BagısAd,BagısSoyad,BagısTc,BagısCinsiyet,BagısTel,EkTel,KanGrubu) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTc.Text);
                komut.Parameters.AddWithValue("@p4", CmbCinsiyet.Text);
                komut.Parameters.AddWithValue("@p5", MskTel.Text);
                komut.Parameters.AddWithValue("@p6", MskEkTel.Text);
                komut.Parameters.AddWithValue("@p7", CmbKanGrubu.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Yapıldı Formları Teslim Edebilirsiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Hide();
        }
    }
}
