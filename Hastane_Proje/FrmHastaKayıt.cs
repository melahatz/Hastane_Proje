using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //SINIF YAPISINDA EKLSEMDE BURDA HER DEFASINDA SINIF KÜTÜPHANESİNİ YAZMAM GEREKİR

namespace Hastane_Proje
{
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        //sınıfımı çağırmam gerekiyor bu nesne ile içinde bulunan bağlanti methoduma ulaşabileicem
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnKayıtYap_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            if(TxtAd.Text==" "||TxtSoyad.Text==" "|| MskTc.Text==" "||MskTelefon.Text==" "|| TxtSifre.Text==" "||CmbCinsiyet.Text==" "||
                TxtAd.Text==String.Empty||TxtSoyad.Text==String.Empty||MskTc.Text==String.Empty||MskTelefon.Text==String.Empty||
                TxtSifre.Text==String.Empty||CmbCinsiyet.Text==String.Empty)
            {
                TxtAd.BackColor = Color.LightSkyBlue;
                TxtSoyad.BackColor = Color.LightSkyBlue;
                MskTc.BackColor=Color.LightSkyBlue;
                MskTelefon.BackColor = Color.LightSkyBlue;
                TxtSifre.BackColor = Color.LightSkyBlue;
                CmbCinsiyet.BackColor = Color.LightSkyBlue;
                MessageBox.Show("Lütfen Mavi Renkteki Boş Alanları Doldurunuz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                //bağlantı açık oldugundan açmadım
                SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values " +
                    "(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTc.Text);
                komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
                komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
                komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text);
                komut.ExecuteNonQuery(); //insert delete update çalıştımak için kullandığımız
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Gerçekleşti ŞİFRENİZ:" + TxtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frm=new FrmHastaGiris();
            frm.Show();
            this.Hide();
        }

        
    }
}
