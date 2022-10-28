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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl=new SqlBaglantisi();
        public string Tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = Tc; //giriş yapınca tc gelsin tc yi de doktor girişden alıcak 

            //dOKTOR aD Soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read()) //Tc nin okunan değerler içerisinde bizim verdiğimiz tc ye eşit olan tcyi getirmiş oluyor
            {
                LblAdSoyad.Text = dr[0]+" "+dr[1];
            }
            bgl.baglanti().Close();

            //RANDEVULAR
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+LblAdSoyad.Text+"'",bgl.baglanti());  
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           FrmDoktorBilgiDuzenle frm=new FrmDoktorBilgiDuzenle();
            frm.Tc = LblTc.Text;
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm=new FrmDuyurular();
            frm.Show();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit(); //komple programı kapatsın.
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//hücreye tıklayınca şikayetini görebilicek
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnInternet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tr/?hl=tr");
            
        }

       
    }
}
