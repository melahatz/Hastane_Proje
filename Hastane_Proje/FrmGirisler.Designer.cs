namespace Hastane_Proje
{
    partial class FrmGirisler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHastaGirisi = new System.Windows.Forms.Button();
            this.BtnDoktorGirisi = new System.Windows.Forms.Button();
            this.BtnSekreterGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTarih = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekreterGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaŞifreYenilemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.önerilerinizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanBagışKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnHastaGirisi
            // 
            this.BtnHastaGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGirisi.BackgroundImage")));
            this.BtnHastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHastaGirisi.Location = new System.Drawing.Point(61, 225);
            this.BtnHastaGirisi.Name = "BtnHastaGirisi";
            this.BtnHastaGirisi.Size = new System.Drawing.Size(247, 236);
            this.BtnHastaGirisi.TabIndex = 0;
            this.BtnHastaGirisi.UseVisualStyleBackColor = true;
            this.BtnHastaGirisi.Click += new System.EventHandler(this.BtnHastaGirisi_Click);
            // 
            // BtnDoktorGirisi
            // 
            this.BtnDoktorGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGirisi.BackgroundImage")));
            this.BtnDoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDoktorGirisi.Location = new System.Drawing.Point(348, 225);
            this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            this.BtnDoktorGirisi.Size = new System.Drawing.Size(240, 236);
            this.BtnDoktorGirisi.TabIndex = 1;
            this.BtnDoktorGirisi.UseVisualStyleBackColor = true;
            this.BtnDoktorGirisi.Click += new System.EventHandler(this.BtnDoktorGirisi_Click);
            // 
            // BtnSekreterGirisi
            // 
            this.BtnSekreterGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGirisi.BackgroundImage")));
            this.BtnSekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSekreterGirisi.Location = new System.Drawing.Point(626, 225);
            this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            this.BtnSekreterGirisi.Size = new System.Drawing.Size(243, 236);
            this.BtnSekreterGirisi.TabIndex = 2;
            this.BtnSekreterGirisi.UseVisualStyleBackColor = true;
            this.BtnSekreterGirisi.Click += new System.EventHandler(this.BtnSekreterGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // LblSaat
            // 
            this.LblSaat.AutoSize = true;
            this.LblSaat.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaat.Location = new System.Drawing.Point(812, 549);
            this.LblSaat.Name = "LblSaat";
            this.LblSaat.Size = new System.Drawing.Size(58, 25);
            this.LblSaat.TabIndex = 10;
            this.LblSaat.Text = "Saat";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTarih.Location = new System.Drawing.Point(812, 580);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(61, 25);
            this.LblTarih.TabIndex = 11;
            this.LblTarih.Text = "Tarih";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtToolStripMenuItem,
            this.doktorGirişToolStripMenuItem,
            this.sekreterGirişToolStripMenuItem,
            this.hastaŞifreYenilemeToolStripMenuItem});
            this.menüToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // hastaKayıtToolStripMenuItem
            // 
            this.hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            this.hastaKayıtToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.hastaKayıtToolStripMenuItem.Text = "Hasta Kayıt";
            this.hastaKayıtToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtToolStripMenuItem_Click);
            // 
            // doktorGirişToolStripMenuItem
            // 
            this.doktorGirişToolStripMenuItem.Name = "doktorGirişToolStripMenuItem";
            this.doktorGirişToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.doktorGirişToolStripMenuItem.Text = "Doktor Giriş";
            this.doktorGirişToolStripMenuItem.Click += new System.EventHandler(this.doktorGirişToolStripMenuItem_Click);
            // 
            // sekreterGirişToolStripMenuItem
            // 
            this.sekreterGirişToolStripMenuItem.Name = "sekreterGirişToolStripMenuItem";
            this.sekreterGirişToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.sekreterGirişToolStripMenuItem.Text = "Sekreter Giriş";
            this.sekreterGirişToolStripMenuItem.Click += new System.EventHandler(this.sekreterGirişToolStripMenuItem_Click);
            // 
            // hastaŞifreYenilemeToolStripMenuItem
            // 
            this.hastaŞifreYenilemeToolStripMenuItem.Name = "hastaŞifreYenilemeToolStripMenuItem";
            this.hastaŞifreYenilemeToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.hastaŞifreYenilemeToolStripMenuItem.Text = "Hasta Şifre Yenileme";
            this.hastaŞifreYenilemeToolStripMenuItem.Click += new System.EventHandler(this.hastaŞifreYenilemeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.önerilerinizToolStripMenuItem,
            this.internetToolStripMenuItem,
            this.kanBagışKaydıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // önerilerinizToolStripMenuItem
            // 
            this.önerilerinizToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.önerilerinizToolStripMenuItem.Name = "önerilerinizToolStripMenuItem";
            this.önerilerinizToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.önerilerinizToolStripMenuItem.Text = "İstek / Şikayet";
            this.önerilerinizToolStripMenuItem.Click += new System.EventHandler(this.önerilerinizToolStripMenuItem_Click);
            // 
            // internetToolStripMenuItem
            // 
            this.internetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.internetToolStripMenuItem.Name = "internetToolStripMenuItem";
            this.internetToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.internetToolStripMenuItem.Text = "İnternet";
            this.internetToolStripMenuItem.Click += new System.EventHandler(this.internetToolStripMenuItem_Click);
            // 
            // kanBagışKaydıToolStripMenuItem
            // 
            this.kanBagışKaydıToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kanBagışKaydıToolStripMenuItem.Name = "kanBagışKaydıToolStripMenuItem";
            this.kanBagışKaydıToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.kanBagışKaydıToolStripMenuItem.Text = "Kan Bagış Kaydı";
            this.kanBagışKaydıToolStripMenuItem.Click += new System.EventHandler(this.kanBagışKaydıToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(182, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(566, 78);
            this.label4.TabIndex = 12;
            this.label4.Text = "Özel Bilim Hastanesi";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.LblSaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGirisi);
            this.Controls.Add(this.BtnDoktorGirisi);
            this.Controls.Add(this.BtnHastaGirisi);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özel Bilim Hastanesi";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGirisi;
        private System.Windows.Forms.Button BtnDoktorGirisi;
        private System.Windows.Forms.Button BtnSekreterGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekreterGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaŞifreYenilemeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem internetToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem kanBagışKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem önerilerinizToolStripMenuItem;
    }
}

