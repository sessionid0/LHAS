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
    public partial class B_YoneticiPanel : Form
    {
        public B_YoneticiPanel()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            B_DoktorEkleSil b_DoktorEkleSil = new B_DoktorEkleSil();
            b_DoktorEkleSil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B_HastaGrafik b_HastaGrafik = new B_HastaGrafik();
            b_HastaGrafik.Show();
        }
    }
}
