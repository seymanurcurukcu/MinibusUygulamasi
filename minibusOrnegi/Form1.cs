using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minibusOrnegi
{
    public partial class FrmMinibusUygulamasi : Form
    {
        public FrmMinibusUygulamasi()
        {
            InitializeComponent();
        }

        Minibus minibusum;
        private void btnMinibusKullan_Click(object sender, EventArgs e)
        {
            try
            {
                minibusum = new Minibus(txtHatKodu.Text, Convert.ToInt32(txtYolcuSayisi.Text));
                lblDurum.Text = "Minibüs hazır seni bekliyor...";
                grpDavranislar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Minibüs tanımlanırken hata oluştu", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDurum.Text = "Hata Oluştu.";
            }
        }

        private void btnYolcuAl_Click(object sender, EventArgs e)
        {
            if (rdbTamBiletliYolcu.Checked == true)
            {
                minibusum.yolcuAl(true);
                lblDurum.Text = "Tam bilet kesildi";
            }
            else if(rdbOgrenciBiletYolcu.Checked == true)
            {
                minibusum.yolcuAl(false);
                lblDurum.Text = "Öğrenci bileti kesildi";
            }
        }

        private void btnYolcuIndir_Click(object sender, EventArgs e)
        {
            minibusum.yolcuIndir();
            lblDurum.Text = "Yolcu indirildi.";
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            lblDurum.Text = "Bakiye= " + minibusum.bakiyeOgren().ToString()+"TL";
        }

        private void btnBosKoltuk_Click(object sender, EventArgs e)
        {
            lblDurum.Text = "Boş koltuk sayısı= " + minibusum.bosKoltukOgren().ToString();
        }
    }
}
