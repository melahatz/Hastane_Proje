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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select * from Tbl_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())  //eğer okuma işlemim dopru şekilde gerçekleşiyorsa if çünkü doğrulama işlemi yapıyoruz. okuma işleminin dopru olup olmadığını kontrol ediyoruz
            {
                FrmSekreterDetay frm=new FrmSekreterDetay();
                frm.TCno=MskTc.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya Tc Girdiniz");
            }
            bgl.baglanti().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frm=new FrmGirisler();
            frm.Show();
            this.Hide();
        }

       
    }
}
