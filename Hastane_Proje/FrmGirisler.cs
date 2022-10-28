using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e) 
        {
            FrmHastaGiris frm=new FrmHastaGiris();
            frm.Show();
            this.Hide(); //Üzerinde Çalıştığım formu gizle bunu aç
        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm = new FrmDoktorGiris();
            frm.Show();
            this.Hide(); 
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frm = new FrmSekreterGiris();
            frm.Show();
            this.Hide();
        }

        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaKayıt frm=new FrmHastaKayıt();
            frm.Show();
            this.Hide();
        }

        private void doktorGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm=new FrmDoktorGiris();
            frm.Show();
            this.Hide();
        }

        private void sekreterGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frm = new FrmSekreterGiris();
            frm.Show();
            this.Hide();
        }

        private void hastaŞifreYenilemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaSifremiUnuttum frm = new FrmHastaSifremiUnuttum();
            frm.Show();
            this.Hide();

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {
            timer1.Start(); //form açılır açılmaz timer çalışmaya başlıcak
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToShortDateString();
        }

      

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tr/?hl=tr");

        }

        private void kanBagışKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKanBagıs frm=new FrmKanBagıs();
            frm.Show();
            this.Hide();
        }

        private void önerilerinizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmİstekSikayetGiris frm=new FrmİstekSikayetGiris();
            frm.Show();
            this.Hide();
        }
    }
}
