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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

        public void temizle()
        {
            TxtId.Text = " ";
            MskTarih.Text = " ";
            MskSaat.Text = " ";
            CmbBrans.Text = " ";
            CmbDoktor.Text = " ";
            MskTc.Text = " ";
        }

        public string TCno;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = TCno; //TC yi taşıdım

            //Ad Soyad Çekme
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTc=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",LblTc.Text);
            SqlDataReader dr1=komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagride Çekme
            DataTable dt1=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1); //dataadapterı doldur dt1 ile
            dataGridView1.DataSource=dt1;

            //Doktorları listeye Aktarma
            DataTable dt2=new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource=dt2;

            //branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1",MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e) //branşa tıklayınca doktor da gelsin .
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut=new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0]+" " + dr[1]);
            }
            bgl.baglanti().Close();

        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm=new FrmDoktorPaneli();
            frm.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frm=new FrmBrans();
            frm.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm=new FrmRandevuListesi();
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm=new FrmDuyurular();
            frm.Show();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnİstekSikayet_Click(object sender, EventArgs e)
        {
            FrmİstekSikayetListesi frm=new FrmİstekSikayetListesi();
            frm.Show();
            
        }
    }
}
