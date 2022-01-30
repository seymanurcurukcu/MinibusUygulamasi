namespace minibusOrnegi
{
    partial class FrmMinibusUygulamasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHatKodu = new System.Windows.Forms.Label();
            this.lblYolcuSayisi = new System.Windows.Forms.Label();
            this.txtHatKodu = new System.Windows.Forms.TextBox();
            this.txtYolcuSayisi = new System.Windows.Forms.TextBox();
            this.btnMinibusKullan = new System.Windows.Forms.Button();
            this.grpDavranislar = new System.Windows.Forms.GroupBox();
            this.btnYolcuAl = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.btnBosKoltuk = new System.Windows.Forms.Button();
            this.btnYolcuIndir = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.rdbTamBiletliYolcu = new System.Windows.Forms.RadioButton();
            this.rdbOgrenciBiletYolcu = new System.Windows.Forms.RadioButton();
            this.lblBiletTipi = new System.Windows.Forms.Label();
            this.grpDavranislar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHatKodu
            // 
            this.lblHatKodu.AutoSize = true;
            this.lblHatKodu.Location = new System.Drawing.Point(58, 51);
            this.lblHatKodu.Name = "lblHatKodu";
            this.lblHatKodu.Size = new System.Drawing.Size(55, 13);
            this.lblHatKodu.TabIndex = 1;
            this.lblHatKodu.Text = "Hat Kodu:";
            // 
            // lblYolcuSayisi
            // 
            this.lblYolcuSayisi.AutoSize = true;
            this.lblYolcuSayisi.Location = new System.Drawing.Point(46, 77);
            this.lblYolcuSayisi.Name = "lblYolcuSayisi";
            this.lblYolcuSayisi.Size = new System.Drawing.Size(67, 13);
            this.lblYolcuSayisi.TabIndex = 2;
            this.lblYolcuSayisi.Text = "Yolcu Sayısı:";
            // 
            // txtHatKodu
            // 
            this.txtHatKodu.Location = new System.Drawing.Point(119, 44);
            this.txtHatKodu.Name = "txtHatKodu";
            this.txtHatKodu.Size = new System.Drawing.Size(100, 20);
            this.txtHatKodu.TabIndex = 3;
            // 
            // txtYolcuSayisi
            // 
            this.txtYolcuSayisi.Location = new System.Drawing.Point(119, 70);
            this.txtYolcuSayisi.Name = "txtYolcuSayisi";
            this.txtYolcuSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtYolcuSayisi.TabIndex = 4;
            // 
            // btnMinibusKullan
            // 
            this.btnMinibusKullan.Location = new System.Drawing.Point(263, 44);
            this.btnMinibusKullan.Name = "btnMinibusKullan";
            this.btnMinibusKullan.Size = new System.Drawing.Size(100, 46);
            this.btnMinibusKullan.TabIndex = 5;
            this.btnMinibusKullan.Text = "Minibüs Kullan";
            this.btnMinibusKullan.UseVisualStyleBackColor = true;
            this.btnMinibusKullan.Click += new System.EventHandler(this.btnMinibusKullan_Click);
            // 
            // grpDavranislar
            // 
            this.grpDavranislar.Controls.Add(this.lblDurum);
            this.grpDavranislar.Controls.Add(this.btnYolcuIndir);
            this.grpDavranislar.Controls.Add(this.btnYolcuAl);
            this.grpDavranislar.Controls.Add(this.btnBakiye);
            this.grpDavranislar.Controls.Add(this.btnBosKoltuk);
            this.grpDavranislar.Enabled = false;
            this.grpDavranislar.Location = new System.Drawing.Point(49, 129);
            this.grpDavranislar.Name = "grpDavranislar";
            this.grpDavranislar.Size = new System.Drawing.Size(314, 180);
            this.grpDavranislar.TabIndex = 6;
            this.grpDavranislar.TabStop = false;
            this.grpDavranislar.Text = "Davranışlar";
            // 
            // btnYolcuAl
            // 
            this.btnYolcuAl.Location = new System.Drawing.Point(50, 31);
            this.btnYolcuAl.Name = "btnYolcuAl";
            this.btnYolcuAl.Size = new System.Drawing.Size(100, 46);
            this.btnYolcuAl.TabIndex = 7;
            this.btnYolcuAl.Text = "Yolcu Al";
            this.btnYolcuAl.UseVisualStyleBackColor = true;
            this.btnYolcuAl.Click += new System.EventHandler(this.btnYolcuAl_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.Location = new System.Drawing.Point(50, 83);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(100, 46);
            this.btnBakiye.TabIndex = 8;
            this.btnBakiye.Text = "Bakiye";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // btnBosKoltuk
            // 
            this.btnBosKoltuk.Location = new System.Drawing.Point(174, 83);
            this.btnBosKoltuk.Name = "btnBosKoltuk";
            this.btnBosKoltuk.Size = new System.Drawing.Size(100, 46);
            this.btnBosKoltuk.TabIndex = 9;
            this.btnBosKoltuk.Text = "Boş Koltuk";
            this.btnBosKoltuk.UseVisualStyleBackColor = true;
            this.btnBosKoltuk.Click += new System.EventHandler(this.btnBosKoltuk_Click);
            // 
            // btnYolcuIndir
            // 
            this.btnYolcuIndir.Location = new System.Drawing.Point(174, 31);
            this.btnYolcuIndir.Name = "btnYolcuIndir";
            this.btnYolcuIndir.Size = new System.Drawing.Size(100, 46);
            this.btnYolcuIndir.TabIndex = 10;
            this.btnYolcuIndir.Text = "Yolcu İndir";
            this.btnYolcuIndir.UseVisualStyleBackColor = true;
            this.btnYolcuIndir.Click += new System.EventHandler(this.btnYolcuIndir_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(132, 146);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 13);
            this.lblDurum.TabIndex = 7;
            // 
            // rdbTamBiletliYolcu
            // 
            this.rdbTamBiletliYolcu.AutoSize = true;
            this.rdbTamBiletliYolcu.Location = new System.Drawing.Point(119, 106);
            this.rdbTamBiletliYolcu.Name = "rdbTamBiletliYolcu";
            this.rdbTamBiletliYolcu.Size = new System.Drawing.Size(69, 17);
            this.rdbTamBiletliYolcu.TabIndex = 7;
            this.rdbTamBiletliYolcu.TabStop = true;
            this.rdbTamBiletliYolcu.Text = "Tam Bilet";
            this.rdbTamBiletliYolcu.UseVisualStyleBackColor = true;
            // 
            // rdbOgrenciBiletYolcu
            // 
            this.rdbOgrenciBiletYolcu.AutoSize = true;
            this.rdbOgrenciBiletYolcu.Location = new System.Drawing.Point(194, 106);
            this.rdbOgrenciBiletYolcu.Name = "rdbOgrenciBiletYolcu";
            this.rdbOgrenciBiletYolcu.Size = new System.Drawing.Size(87, 17);
            this.rdbOgrenciBiletYolcu.TabIndex = 8;
            this.rdbOgrenciBiletYolcu.TabStop = true;
            this.rdbOgrenciBiletYolcu.Text = "Öğrenci Bileti";
            this.rdbOgrenciBiletYolcu.UseVisualStyleBackColor = true;
            // 
            // lblBiletTipi
            // 
            this.lblBiletTipi.AutoSize = true;
            this.lblBiletTipi.Location = new System.Drawing.Point(63, 108);
            this.lblBiletTipi.Name = "lblBiletTipi";
            this.lblBiletTipi.Size = new System.Drawing.Size(50, 13);
            this.lblBiletTipi.TabIndex = 9;
            this.lblBiletTipi.Text = "Bilet Tipi:";
            // 
            // FrmMinibusUygulamasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 351);
            this.Controls.Add(this.lblBiletTipi);
            this.Controls.Add(this.rdbOgrenciBiletYolcu);
            this.Controls.Add(this.rdbTamBiletliYolcu);
            this.Controls.Add(this.grpDavranislar);
            this.Controls.Add(this.btnMinibusKullan);
            this.Controls.Add(this.txtYolcuSayisi);
            this.Controls.Add(this.txtHatKodu);
            this.Controls.Add(this.lblYolcuSayisi);
            this.Controls.Add(this.lblHatKodu);
            this.Name = "FrmMinibusUygulamasi";
            this.Text = "Minibüs Uygulaması";
            this.grpDavranislar.ResumeLayout(false);
            this.grpDavranislar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHatKodu;
        private System.Windows.Forms.Label lblYolcuSayisi;
        private System.Windows.Forms.TextBox txtHatKodu;
        private System.Windows.Forms.TextBox txtYolcuSayisi;
        private System.Windows.Forms.Button btnMinibusKullan;
        private System.Windows.Forms.GroupBox grpDavranislar;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnYolcuIndir;
        private System.Windows.Forms.Button btnYolcuAl;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Button btnBosKoltuk;
        private System.Windows.Forms.RadioButton rdbTamBiletliYolcu;
        private System.Windows.Forms.RadioButton rdbOgrenciBiletYolcu;
        private System.Windows.Forms.Label lblBiletTipi;
    }
}

