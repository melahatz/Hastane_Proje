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
    public partial class FrmİstekSikayetGiris : Form
    {
        public FrmİstekSikayetGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        

        private void BtnİstekSikayet_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            if(MskKullaniciAd.Text==" "||TxtSifre.Text==" " || MskKullaniciAd.Text == String.Empty || TxtSifre.Text == String.Empty)
            {
                MskKullaniciAd.BackColor = Color.SkyBlue;
                TxtSifre.BackColor = Color.SkyBlue;
                MessageBox.Show("Lütfen Mavi Alanları Doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc = @p1 and HastaSifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    FrmİstekSikayet frm = new FrmİstekSikayet();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı Girdiniz");
                }
            }
            
        }
    }
}
