﻿using System;
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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;  //hasta girişteki tc yi buraya taşımak için
        SqlBaglantisi bgl=new SqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc; //form yüklediğinde Lbltc nin textine tc yi atıcaz.Hasta giriş den taşıdık.

            //Ad Soyad Çekme
            SqlCommand komut=new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text); //lbltc yazan değere eşit olan değeri getirsin

            SqlDataReader dr = komut.ExecuteReader(); //Veri okuyucumu çalıştırıcak dr
            while (dr.Read()) //while da tüm verileri okuyo if de sadece verilerin doğru okunup okunmadığı
            {
                LblAdSoyad.Text = dr[0]+" "+dr[1]; //2 sütun oldugundan 2 indeks gelir

            }
            bgl.baglanti().Close();  //veritabanına çekiyor 


            //Randevu Geçmişi
            DataTable dt = new DataTable();  //veri tablosu
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTc="+tc,bgl.baglanti()); //datagride verilerimi aktarmak için kullandığım command
            da.Fill(dt); //dataadapterin içini doldur tablodan gelicek değerle. sanal tablo oluşturma mantıpı
            dataGridView1.DataSource = dt; //datagriedin veri kaynağı=dt den gelen tablo

            //Branş Çekme
            SqlCommand komut2 = new SqlCommand("Select  BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

           
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)//branşa tıkladığımda doktorları çekmek istiyorum
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",CmbBrans.Text);
            SqlDataReader dr3=komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0]+" "+ dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e) //doktoru seçince randevular gelicek
        {

            //datagride veri çekicez
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuBrans='"+CmbBrans.Text+"'"+" and RandevuDoktor='"+CmbDoktor.Text+"' and RandevuDurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource=dt;
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            FrmBilgiDuzenle frm=new FrmBilgiDuzenle();
            frm.TCno = LblTc.Text;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e) //tıklandığında randevu paneline gelsin bilgiler
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            bgl.baglanti();
            if(RchSikayet.Text==" " || RchSikayet.Text == String.Empty)
            {
                RchSikayet.BackColor = Color.SkyBlue;
                MessageBox.Show("Lütfen Şikayetinizi Birkaç Kelimeyle İfade Ediniz..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //randevuid ye göre güncelleme işlemi gerçekleştiricem
                SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", LblTc.Text);
                komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
                komut.Parameters.AddWithValue("@p3", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGirisler frm=new FrmGirisler();
            frm.Show();
            this.Hide();
        }

        
    }
}
