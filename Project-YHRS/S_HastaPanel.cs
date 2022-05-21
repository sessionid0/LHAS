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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_AsiRandevuAl s_AsiRandevuAl = new S_AsiRandevuAl();
            s_AsiRandevuAl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            S_Profilim s_Profilim = new S_Profilim();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_HekimleriGoruntule s_HekimleriGoruntule = new S_HekimleriGoruntule();
            s_HekimleriGoruntule.Show();
        }
    }
}
