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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            if (MskTc.Text==" " || TxtSifre.Text==" "|| MskTc.Text==String.Empty|| TxtSifre.Text==String.Empty)
            {
                MskTc.BackColor = Color.LightSkyBlue;
                TxtSifre.BackColor = Color.LightSkyBlue;
                MessageBox.Show("Mavi Alanlar Boş Geçilemez Lütfen Doldurunuz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTc.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    FrmDoktorDetay frm = new FrmDoktorDetay();
                    frm.Tc = MskTc.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı ve şifre");

                }
                bgl.baglanti().Close();
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frm=new FrmGirisler();
            frm.Show();
            this.Hide();
        }
    }
}
