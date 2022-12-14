using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_YHRS
{
    public partial class S_HastaPanel : Form
    {
        public S_HastaPanel()
        {
            InitializeComponent();
        }

        private void S_HastaPanel_Load(object sender, EventArgs e)
        {
            
            VeriTabanı.GridTumunuDoldur(dataGridView1, "Select R_Aciklama 'Randevu Türü',R_BGerceklesme 'Durumu',POL_Ad 'Poliklinik Adı', RD_Ad 'Doktor Adı', R_Tarih 'Tarihi', R_Saat 'Saati' from RandevularTablosu");
            VeriTabanı.GridTumunuDoldur(dataGridView2, "Select POL_Ad 'Poliklinik Adı', RD_Ad 'Doktor Adı', R_Tarih 'Tarihi', H_ReceteKod 'Reçete Kodu' from RandevularTablosu");
            VeriTabanı.LoginDataKontrol(VeriTabanı.usertc, VeriTabanı.userpass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_AsiRandevuAl s_AsiRandevuAl = new S_AsiRandevuAl();
            s_AsiRandevuAl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            S_Profilim s_Profilim = new S_Profilim();
            VeriTabanı.LoginDataKontrol(VeriTabanı.usertc, VeriTabanı.userpass);
            s_Profilim.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            S_Ayarlar s_Ayarlar = new S_Ayarlar();
            s_Ayarlar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S_HastaneRandevu s_HastaneRandevu = new S_HastaneRandevu();
            s_HastaneRandevu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_HekimleriGoruntule s_HekimleriGoruntule = new S_HekimleriGoruntule();
            s_HekimleriGoruntule.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "YHRS",
    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result2 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //boş kalacak.
            }
        }
    }
}
