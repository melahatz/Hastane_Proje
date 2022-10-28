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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)

        {
            FrmHastaKayıt frm = new FrmHastaKayıt(); //üye ol linkine basınca hasta kayıt formumuz açılsın
            frm.Show();
            this.Hide();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@p1 and HastaSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();  //okuma işlemi yapıyoruz.Komuttan gelen değerle birlikte okuyucuyu çalıştır
            if (dr.Read()) //komutum doğru okuma gerçekleştiriyorsa
            {
                FrmHastaDetay frm=new FrmHastaDetay();
                frm.tc=MskTc.Text;  //burda hasta detay formuna tc yi atadım
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre!");
            }
            bgl.baglanti().Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frm= new FrmGirisler();
            frm.Show();
            this.Hide();
        }

        private void SifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaSifremiUnuttum frm=new FrmHastaSifremiUnuttum();
            frm.Show();
            this.Hide();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
